import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeComponent } from './employee.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [CommonModule ,RouterModule],
  exports: [HomeComponent],
  declarations: [EmployeeComponent, HomeComponent,LoginComponent]
})
export class EmployeeModule {}
