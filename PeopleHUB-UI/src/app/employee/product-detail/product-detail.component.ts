import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators ,FormGroup } from '@angular/forms';
import { Category } from 'src/app/models/category.model';
import { Location } from 'src/app/models/location.model';
import { DataService } from 'src/app/services/data.service';
import { Product } from 'src/app/models/product.model';
import { AuthService } from 'src/app/services/auth.service';
import { ProductService } from 'src/app/services/product.service';


@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  categories :Category[]=[];
  locations:Location[]=[];
  product:Product= new Product();

  productForm = this.fb.group({

  categoryId:['',Validators.required],
  isActive: ['',Validators.required],
  employeeId:['',Validators.required],
  description:['',[Validators.required,Validators.maxLength(500)]],
  locationId:['',Validators.required],
  specification:['',[Validators.required,Validators.maxLength(300)]],
  price:['',Validators.required],
  address:['',[Validators.required,Validators.maxLength(300)]],
  title:['',[Validators.required,Validators.maxLength(50)]],
  priceNegotiable: ['',Validators.required]
  });

  constructor(private fb:FormBuilder
              ,private dataService : DataService
              ,private authService :AuthService
              ,private productService :ProductService) { }

  ngOnInit() {
    this.dataService.getLocations().subscribe(data=>{
      this.locations=[...data];
    });
    this.dataService.getCategories().subscribe(data=>{
      this.categories=[...data];
    })
  }

  onSubmit(productFormValue){
      console.log(productFormValue);
      this.product.categoryId=productFormValue.categoryId;
      this.product.title=productFormValue.title;
      this.product.address=productFormValue.address;
      this.product.description=productFormValue.description;
      this.product.employeeId=this.authService.employee.employeeId;
      this.product.isActive=productFormValue.isActive;
      this.product.locationId=productFormValue.locationId;
      this.product.price=productFormValue.price;
      this.product.priceNegotiable=productFormValue.priceNegotiable;
      this.product.specification=productFormValue.specification;
      this.productService.addProduct(this.product).subscribe(data=>{
        this.productService.tempProduct=data;
        console.log("Inserted Product ==>")
        console.log(this.productService.tempProduct);
      });
      console.log('Product has been added');


  }

}
