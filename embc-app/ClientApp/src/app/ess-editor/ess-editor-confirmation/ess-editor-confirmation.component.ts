import { Component, OnInit } from '@angular/core';
import { Volunteer } from 'src/app/core/models';
import { AppState } from 'src/app/store';
import { Store } from '@ngrx/store';
import { VolunteerService } from 'src/app/core/services/volunteer.service';
import { takeWhile } from 'rxjs/operators';
import { UpdateVolunteer } from 'src/app/store/volunteer/volunteer.actions';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ess-editor-confirmation',
  templateUrl: './ess-editor-confirmation.component.html',
  styleUrls: ['./ess-editor-confirmation.component.scss']
})
export class EssEditorConfirmationComponent implements OnInit {
  componentActive = true;
  currentVolunteer$ = this.store.select(s => s.volunteers.currentVolunteer);
  volunteer: Volunteer;

  // whatever came back from the service
  results: any;

  constructor(
    private store: Store<AppState>,
    private volunteerService: VolunteerService,
    private router: Router,
    // private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    this.currentVolunteer$.pipe(takeWhile(() => this.componentActive))
      .subscribe(v => {
        this.volunteer = v;
      });
  }
  back() {
    this.onSave();
    this.router.navigate(['/user-edit']);
  }
  onSave() {
    // update the stored version
    const volunteer = this.volunteer;
    this.store.dispatch(new UpdateVolunteer({ volunteer }))
  }
  submit(addAnother?: boolean) {
    // TODO the add another flag should route the user back to the create page in the subscription

    // check if this is an update
    if (this.volunteer.id) {
      // alert("Update Volunteer");

      // if the volunteer has an ID we need to update
      this.volunteerService.updateVolunteer(this.volunteer)
        .subscribe(v => {
          alert(JSON.stringify(v));
        });
    } else {
      // if the volunteer has no id we need to create a new one
      this.volunteerService.createVolunteer(this.volunteer)
        .subscribe(v => {
          alert(JSON.stringify(v));
        });
    }
  }
}
