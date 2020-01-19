import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from '../models/category.model';
import { Location } from '../models/location.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {

constructor(private http:HttpClient) { }

getLocations()
{
  return this.http.get<Location[]>('https://localhost:44371/api/location');
}

getCategories()
{
  return this.http.get<Category[]>('https://localhost:44371/api/category');
}

getCarousalmages() :string[]
{
  var carousalImages= [];
    carousalImages.push("http://127.0.0.1:8887//banner1.png");
    carousalImages.push("http://127.0.0.1:8887//banner2.png")
    carousalImages.push("http://127.0.0.1:8887//banner3.png")


  return carousalImages;
}


}
