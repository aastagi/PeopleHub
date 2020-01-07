import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AuthService } from './services/auth.service';
import { EmployeeModule } from './employee/employee.module';
import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { EmployeeService } from './services/employee.service';
import { HttpClientModule }    from '@angular/common/http';
import { BannerComponent } from './shared/components/banner/banner.component';

@NgModule({
   declarations: [
      AppComponent,
      NavbarComponent
   ],
   imports: [
      BrowserModule,
      NgbModule,
      EmployeeModule,
      AppRoutingModule,RouterModule ,HttpClientModule
   ],
   providers: [AuthService,EmployeeService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
