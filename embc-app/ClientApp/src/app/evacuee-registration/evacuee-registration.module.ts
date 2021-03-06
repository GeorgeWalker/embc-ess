import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { SharedModule } from './../shared/shared.module';

import { EvacueeRegistrationComponent } from './evacuee-registration.component';
import { EvacueeRegistrationConfirmationComponent } from './evacuee-registration-confirmation/evacuee-registration-confirmation.component';
import { EvacueeRegistrationOneComponent } from './evacuee-registration-one/evacuee-registration-one.component';

@NgModule({
    declarations: [
        EvacueeRegistrationComponent,
        EvacueeRegistrationConfirmationComponent,
        EvacueeRegistrationOneComponent,
    ],
    imports: [
        CommonModule,
        RouterModule,
        SharedModule,
    ],
    exports: [
        EvacueeRegistrationComponent,
    ]
})
export class EvacueeRegistrationModule { }
