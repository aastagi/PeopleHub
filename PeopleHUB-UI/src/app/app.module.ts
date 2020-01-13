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
import { DataService } from './services/data.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// import { ProductCardComponent } from './shared/components/product-card/product-card.component';

@NgModule({
   declarations: [
      AppComponent,
      NavbarComponent,
      // ProductCardComponent
   ],
   imports: [
      BrowserModule,
      NgbModule,
      EmployeeModule,
      AppRoutingModule,RouterModule ,HttpClientModule,FormsModule,ReactiveFormsModule
   ],
   providers: [AuthService,EmployeeService,DataService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
