import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeComponent } from './employee.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { ProductDetailComponent} from './product-detail/product-detail.component';

@NgModule({
  imports: [CommonModule ,RouterModule,FormsModule,ReactiveFormsModule],
  exports: [HomeComponent],
  declarations: [EmployeeComponent, HomeComponent,LoginComponent,RegisterComponent,ProductDetailComponent]
})
export class EmployeeModule {}
