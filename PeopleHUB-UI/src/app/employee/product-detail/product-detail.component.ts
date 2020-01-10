import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators ,FormGroup } from '@angular/forms';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { ThrowStmt } from '@angular/compiler';
import { from } from 'rxjs';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product = new Product();
  profileForm = this.fb.group({
    title: ['',[Validators.required]],
    category:['',[Validators.required]],
    location:['',[Validators.required]],
    specification:[''],
    price:['',[Validators.required]],
    address:['',[Validators.required]],
    priceNegotiable:[''],
    description:['',[Validators.required]]
  });
  constructor(private fb: FormBuilder,private productService :ProductService) { }

  ngOnInit() {
  }
  onSubmit(formValues){
    this.product.title = formValues.title;
    //this.product.category = formValues.category;
    //this.product.location = formValues.location;
    this.product.specification = formValues.specification;
    this.product.price = formValues.price;
    this.product.address = formValues.address;
    this.product.priceNegotiable = formValues.priceNegotiable;
    this.product.description = formValues.description;
    this.productService.addProduct(this.product);
  }
}
