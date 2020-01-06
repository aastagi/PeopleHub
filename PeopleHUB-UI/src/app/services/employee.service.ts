import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../models/employee';



@Injectable({
  providedIn: 'root'
})
export class EmployeeService {



constructor(private http:HttpClient) { }

    registerEmployee(employee){
          this.http.post<Employee>('https://localhost:44371/api/employee/register',employee)
          .subscribe(
            data=>console.log("success",data),
            error=>console.log("error occured",error)
          );
    }
}
