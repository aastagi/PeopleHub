import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeComponent } from './employee.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  imports: [CommonModule],
  exports: [HomeComponent],
  declarations: [EmployeeComponent, HomeComponent]
})
export class EmployeeModule {}
