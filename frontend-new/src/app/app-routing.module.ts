import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { CandidateComponent } from './candidate/candidate.component';
import { JobComponent } from './job/job.component';
import { ContestComponent } from './contest/contest.component';
import { UserComponent } from './user/user.component';
import { TenantComponent } from './tenant/tenant.component';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { DashboardLayoutComponent } from './layouts/dashboard-layout.component';
import { AuthGuard } from './auth/auth,guard';
import { LoginLayoutComponent } from './layouts/login-layout.component';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  // { path: 'home', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'candidates', component: CandidateComponent },
  { path: 'jobs', component: JobComponent },
  { path: 'contests', component: ContestComponent },
  { path: 'users', component: UserComponent },
  { path: 'tenants', component: TenantComponent }

  // {
  //   path: '',
  //   component: DashboardLayoutComponent,
  //   canActivate: [AuthGuard],
  //   children: [
  //     { path: '', redirectTo: 'login', pathMatch: 'full' },
  //     // { path: 'home', component: HomeComponent },
  //     { path: 'login', component: LoginComponent },
  //     { path: 'signup', component: SignupComponent },
  //     { path: 'dashboard', component: DashboardComponent },
  //     { path: 'candidates', component: CandidateComponent },
  //     { path: 'jobs', component: JobComponent },
  //     { path: 'contests', component: ContestComponent },
  //     { path: 'users', component: UserComponent },
  //     { path: 'tenants', component: TenantComponent }
  //   ]
  // },
  // {
  //   path: '',
  //   component: LoginLayoutComponent,
  //   children: [
  //     {
  //       path: 'login',
  //       component: LoginComponent
  //     }
  //   ]
  // },
  // { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
