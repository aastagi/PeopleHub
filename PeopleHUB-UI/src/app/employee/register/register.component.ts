import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators ,FormGroup, AbstractControl } from '@angular/forms';
import { Employee } from 'src/app/models/employee.model';
import { EmployeeService } from 'src/app/services/employee.service';
import { EmployeeModule } from '../employee.module';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  employee  = new Employee();

  profileForm = this.fb.group({
    firstName: ['', [Validators.required,Validators.minLength(4),Validators.pattern('^[a-zA-Z]+$')]],
    lastName: ['',[Validators.required,Validators.pattern('^[a-zA-Z]+$')]],
    email:['',[Validators.required,Validators.email]],
    countryCode:['',Validators.required],
    mobileNumber:['',[Validators.required,Validators.pattern('^[0-9]{10}$')]],
    location:['',Validators.required],
    password:['',[Validators.required,Validators.minLength(6)]],
    confirmPassword:['',[Validators.required]]
  } , {validator: this.passwordConfirming});


  constructor(private fb: FormBuilder ,private employeeService :EmployeeService) { }

  ngOnInit() {
  }

  passwordConfirming(c: AbstractControl): { invalid: boolean } {
    if (c.get('password').value !== c.get('confirmPassword').value) {
        return {invalid: true};
    }
}

  onSubmit(formValues){
      console.log(formValues);
      this.employee.firstName=formValues.firstName;
      this.employee.lastName=formValues.lastName;
      this.employee.email=formValues.email;
      this.employee.location=formValues.location;
      this.employee.countryCode=formValues.countryCode;
      this.employee.mobileNumber=formValues.mobileNumber;
      this.employee.password=formValues.password;
      this.employeeService.registerEmployee(this.employee);
  }

}
