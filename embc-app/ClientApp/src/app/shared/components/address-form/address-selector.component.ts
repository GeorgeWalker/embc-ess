import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';

import { AppState } from 'src/app/store';
import { Country } from 'src/app/core/models';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-address-selector',
  template: `
    <app-bc-address *ngIf="withinBC" [parent]="parent" [communities]="communities$ | async"></app-bc-address>
    <app-other-address *ngIf="!withinBC" [parent]="parent" [countries]="countries$ | async"></app-other-address>
  `,
  styles: []
})
export class AddressSelectorComponent implements OnInit, OnChanges {
  @Input() parent: FormGroup;
  @Input() withinBC = true;

  communities$ = this.store.select(state => state.lookups.communities.communities);
  countries$ = this.store.select(state => state.lookups.countries.countries);
  // Find out the country ID for Canada as it is hard-coded for BC addresses...
  canada$ = this.countries$.pipe(map(countries => countries.find(x => x.name === 'Canada')));

  constructor(private store: Store<AppState>) { }

  ngOnInit() {
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes.withinBC != null) {
      const withinBC = changes.withinBC.currentValue;
      this.canada$.subscribe(canada => this.toggleAddressForm(this.parent, withinBC, canada));
    }
  }

  private toggleAddressForm(form: FormGroup, withinBC: boolean, homeCountry: Country) {
    const values = withinBC
      ? { province: 'British Columbia', country: homeCountry }
      : { province: null, country: null };
    form.reset();
    form.enable();
    form.patchValue(values);
  }
}
