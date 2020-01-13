import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { HomeComponent } from '../employee/home/home.component';
import { Router } from '@angular/router';
import { DataService } from '../services/data.service';
import { Location } from '../models/location.model';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  collapsed = true;
  locations:Location[]=[];
  selectedLocation :Location={
    locationId:-1,
    locationName:'Select Location'
  };

  constructor(public authService: AuthService
              ,private router:Router
              ,private dataService: DataService) {}

  ngOnInit() {
    console.log(this.authService.isEmployeeLoggedIn);
    this.dataService.getLocations().subscribe(data=>{
       this.locations=[...data];
       this.locations.push(this.selectedLocation);
    });
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

  onLocationChange(){
    console.log("Nav bar location selected");
    console.log(this.selectedLocation);
  }
}
