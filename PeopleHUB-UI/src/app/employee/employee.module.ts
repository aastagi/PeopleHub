import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeComponent } from './employee.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { ProductDetailComponent} from './product-detail/product-detail.component';
import { BannerComponent } from '../shared/components/banner/banner.component';
import { MainSearchComponent } from '../shared/components/main-search/main-search.component';

@NgModule({
  imports: [CommonModule ,RouterModule,FormsModule,ReactiveFormsModule],
  exports: [HomeComponent],
  declarations: [EmployeeComponent, HomeComponent,LoginComponent,RegisterComponent,
    ProductDetailComponent,BannerComponent,MainSearchComponent]
})
export class EmployeeModule {}
