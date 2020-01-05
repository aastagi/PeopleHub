import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor() {}

  isEmployeeLoggedIn = false;

  Login() {
    this.isEmployeeLoggedIn = true;
  }
}
