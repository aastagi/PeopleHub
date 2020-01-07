import { Injectable } from '@angular/core';
import { Employee } from '../models/employee.model';
import { HttpClient } from '@angular/common/http';
import { LoginModel } from '../models/login.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http : HttpClient) {}

  isEmployeeLoggedIn = false;
  employee = new Employee();

  Login(loginModel :LoginModel) {
    return  this.http.post<Employee>("https://localhost:44371/api/employee/login",loginModel)
  }
}
