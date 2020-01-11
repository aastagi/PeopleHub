import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators ,FormGroup } from '@angular/forms';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

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

  constructor(private fb:FormBuilder) { }

  ngOnInit() {
  }

  onSubmit(productFormValue){
      console.log(productFormValue);
  }

}
