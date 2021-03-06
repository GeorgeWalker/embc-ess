import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import {
  SelfRegistrationComponent,
  SelfRegistrationOneComponent,
  SelfRegistrationTwoComponent,
  SelfRegistrationThreeComponent,
  SelfRegistrationFourComponent,
  SelfRegistrationErrorComponent,
} from './self-registration';
import { VolunteerLoginComponent } from './volunteer-login/volunteer-login.component';
import { VolunteerDashboardComponent } from './volunteer-dashboard/volunteer-dashboard.component';
import { EvacueeRegistrationComponent } from './evacuee-registration/evacuee-registration.component';
import { TesterPageComponent } from './tester-page/tester-page.component';
import { EvacueeRegistrationOneComponent } from './evacuee-registration/evacuee-registration-one/evacuee-registration-one.component';
import { EvacueeRegistrationConfirmationComponent } from './evacuee-registration';
import { EssEditorComponent } from './ess-editor/ess-editor.component';
import { EssEditorOneComponent } from './ess-editor/ess-editor-one/ess-editor-one.component';
import { EssEditorConfirmationComponent } from './ess-editor/ess-editor-confirmation/ess-editor-confirmation.component';
import { VolunteerTeamDashboardComponent } from './volunteer-team-dashboard/volunteer-team-dashboard.component';
import { VolunteerUsefulInformationComponent } from './volunteer-useful-information/volunteer-useful-information.component';
import { EvacueeSummaryComponent } from './evacuee-summary/evacuee-summary.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    // TODO: naming this should be "evacuee-self-registration"
    path: 'self-registration',
    component: SelfRegistrationComponent,
    children: [
      {
        path: '',
        redirectTo: 'step-1',
        pathMatch: 'full'
      },
      {
        path: 'step-1',
        component: SelfRegistrationOneComponent
      },
      {
        path: 'step-2',
        component: SelfRegistrationTwoComponent
      },
      {
        path: 'step-3',
        component: SelfRegistrationThreeComponent
      },
      {
        path: 'step-4',
        component: SelfRegistrationFourComponent
      },
      {
        path: 'error',
        component: SelfRegistrationErrorComponent
      },
    ]
  },
  {
    path: 'volunteer-login',
    component: VolunteerLoginComponent
  },
  {
    path: 'volunteer-info',
    component: VolunteerUsefulInformationComponent
  },
  {
    path: 'volunteer-dashboard',
    component: VolunteerDashboardComponent
  },
  {
    path: 'volunteer-team-dashboard',
    component: VolunteerTeamDashboardComponent
  },
  {
    path: 'evacuee-summary/:essFileNumber',
    component: EvacueeSummaryComponent
  },
  {
    // TODO: naming: this should be changed to be "evacuee-registration"
    path: 'register-evacuee',
    component: EvacueeRegistrationComponent,
    children: [
      {
        path: '',
        redirectTo: 'fill',
        pathMatch: 'full'
      },
      {
        path: 'fill/:essFileNumber',
        component: EvacueeRegistrationOneComponent
      },
      {
        path: 'fill',
        component: EvacueeRegistrationOneComponent
      },
      {
        path: 'confirmation',
        component: EvacueeRegistrationConfirmationComponent
      }
    ]
  },
  {
    path: 'user-edit',
    component: EssEditorComponent,
    children: [
      {
        path: '',
        redirectTo: 'fill',
        pathMatch: 'full'
      },
      {
        path: 'fill',
        component: EssEditorOneComponent
      },
      {
        path: 'fill/:essUser',
        component: EssEditorOneComponent
      },
      {
        path: 'confirmation',
        component: EssEditorConfirmationComponent
      }
    ]
  },
  {
    path: 'test',
    component: TesterPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'top' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
