import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { HomeComponent } from '../employee/home/home.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  collapsed = true;
  constructor(public authService: AuthService) {}

  ngOnInit() {
    console.log(this.authService.isEmployeeLoggedIn);
  }

  onLoginClicked() {
    this.authService.isEmployeeLoggedIn = true;
  }
}
