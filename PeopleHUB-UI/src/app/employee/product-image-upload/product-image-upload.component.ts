import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product-image-upload',
  templateUrl: './product-image-upload.component.html',
  styleUrls: ['./product-image-upload.component.css']
})
export class ProductImageUploadComponent implements OnInit {

  productId: number;
  @ViewChild('fileInput', {static: false}) fileInput :ElementRef;
  constructor(private productService: ProductService) { }

  ngOnInit() {
  }

  uploadImage(){
    var nativeElement :HTMLInputElement=this.fileInput.nativeElement;
    this.productService.uploadImage(this.productId,nativeElement.files[0])
    .subscribe(x=>console.log(x));
  }

}
