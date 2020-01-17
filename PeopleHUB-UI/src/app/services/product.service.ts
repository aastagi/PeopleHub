import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/product.model';
import { ProductImage } from '../models/product-image.model';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  tempProduct : Product = new Product();



constructor(private http:HttpClient) { }

    addProduct(product){
         return this.http.post<Product>('https://localhost:44371/api/product/addproduct',product)

    }

    uploadImage(productid,file)
    {
      var formData = new FormData();
      formData.append('file',file)
        return this.http.post('https://localhost:44371/api/product/'+productid+'/productImage',formData)
    }

    getProductImages(productid)
    {
      return this.http.get<ProductImage[]>('https://localhost:44371/api/product/'+productid+'/productImage')
    }


}
