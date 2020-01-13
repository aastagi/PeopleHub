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


}
