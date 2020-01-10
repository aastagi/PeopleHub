import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators ,FormGroup } from '@angular/forms';

@Component({
  selector: 'app-product-detail-new',
  templateUrl: './product-detail-new.component.html',
  styleUrls: ['./product-detail-new.component.css']
})
export class ProductDetailNewComponent implements OnInit {

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
