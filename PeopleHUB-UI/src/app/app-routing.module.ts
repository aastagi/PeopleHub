import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule, Routes } from "@angular/router";
import { NavbarComponent } from "./navbar/navbar.component";
import { HomeComponent } from "./employee/home/home.component";
import { LoginComponent } from "./employee/login/login.component";
import { RegisterComponent } from './employee/register/register.component';
import { ProductDetailComponent } from './employee/product-detail/product-detail.component';
import { AllProductDetailsComponent } from './employee/all-product-details/all-product-details.component';

const routes: Routes = [
  // {
  //   path: "",
  //   component: HomeComponent
  // },
  {
    path: "home",
    component: HomeComponent
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "register",
    component: RegisterComponent
  },
  {
    path: "product-detail",
    component: AllProductDetailsComponent
  }
];
@NgModule({
  imports: [CommonModule, RouterModule.forRoot(routes)],
  declarations: []
})
export class AppRoutingModule {}
