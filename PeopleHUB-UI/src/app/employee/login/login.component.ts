import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { LoginModel } from 'src/app/models/login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginModel = new LoginModel();
  constructor(private router :Router ,private authService :AuthService) { }

  ngOnInit() {
  }

  onLoginFormSubmit()
  {
      this.authService.Login(this.loginModel).subscribe(
        data =>{
          this.authService.employee=data;
          this.authService.isEmployeeLoggedIn=true;
          this.router.navigateByUrl('/home');

        },
        error=>{
          console.log('Error occured' ,error)
        }
      )

  }

  onRegisterClick()
  {

      this.router.navigateByUrl('/register')
  }

}
