import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { HomeComponent } from '../employee/home/home.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  collapsed = true;
  constructor(public authService: AuthService ,private router:Router) {}

  ngOnInit() {
    console.log(this.authService.isEmployeeLoggedIn);
  }

  onLoginClicked() {

  }

  onLogoutClick(){
    this.authService.isEmployeeLoggedIn=false;
    this.authService.employee=null;
    this.router.navigateByUrl('/home')

  }
  onAddProductClick(){
    this.router.navigateByUrl('/product-detail')
  }
}
