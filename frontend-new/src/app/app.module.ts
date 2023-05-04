import { BrowserModule } from '@angular/platform-browser';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { MatTableModule} from '@angular/material/table';
import { CandidateComponent } from './candidate/candidate.component';
import { JobComponent } from './job/job.component';
import { UserComponent } from './user/user.component';
import { ContestComponent } from './contest/contest.component';
import { HttpClientModule } from '@angular/common/http';
import { MatTooltip } from '@angular/material/tooltip';
import { TenantComponent } from './tenant/tenant.component';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { MatFormFieldControl, MatFormFieldModule, MatLabel } from '@angular/material/form-field';
import {MatCardModule} from '@angular/material/card';
import {  MatSelectModule } from '@angular/material/select';
import { MatOptionModule } from '@angular/material/core';
import { MatInput, MatInputModule } from '@angular/material/input';
import { RouterModule } from '@angular/router';
import { AuthService } from './auth/auth.service';
import { AuthGuard } from './auth/auth,guard';
import { LoginLayoutComponent } from './layouts/login-layout.component';
import { DashboardLayoutComponent } from './layouts/dashboard-layout.component';



@NgModule({
  declarations: [		
    AppComponent,
    HeaderComponent,
    HomeComponent,
    DashboardComponent,
    SidenavComponent,
    CandidateComponent,
    JobComponent,
    UserComponent,
    ContestComponent,
    TenantComponent,
      LoginComponent,
      SignupComponent,
      LoginLayoutComponent,
      DashboardLayoutComponent
      
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,    
    HttpClientModule,
    RouterModule,
    // * MATERIAL IMPORTS
    MatSidenavModule,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    MatDividerModule,
    MatListModule,
    MatTableModule,
    MatSnackBarModule,
    MatFormFieldModule,
    MatCardModule,
    MatSelectModule,
    MatOptionModule,
MatInputModule,

    
  ],
  providers: [AuthService, AuthGuard],
  bootstrap: [AppComponent],  
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  entryComponents: [CandidateComponent]
})
export class AppModule {}
