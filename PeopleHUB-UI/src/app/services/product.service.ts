import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/product.model';



@Injectable({
  providedIn: 'root'
})
export class ProductService {



constructor(private http:HttpClient) { }

    addProduct(product){
          this.http.post<Product>('https://localhost:44371/api/product/addproduct',product)
          .subscribe(
            data=>console.log("success",data),
            error=>console.log("error occured",error)
          );
    }
}
