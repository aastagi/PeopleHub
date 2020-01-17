import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';
import { ProductImage } from 'src/app/models/product-image.model';

@Component({
  selector: 'app-product-image-upload',
  templateUrl: './product-image-upload.component.html',
  styleUrls: ['./product-image-upload.component.css']
})
export class ProductImageUploadComponent implements OnInit {


  productId: number;
  uploadedFile:string ="Choose File";
  productImages :ProductImage[]=[];
  productImage :ProductImage
  public uploadFolderPath="C:\\PeopleHub\\UploadedProductImages\\";
  @ViewChild('fileInput', {static: false}) fileInput :ElementRef;
  constructor(private productService: ProductService) { }

  ngOnInit() {

  }

  uploadImage(){
    this.productImage = new ProductImage();
    this.productImage.imageOriginalName=this.fileInput.nativeElement.value;
    this.productImage.isActive=true;
    this.productImage.isThumbnailImage=true;
    this.productImage.productId=this.productService.tempProduct.productId;
    this.uploadedFile=this.fileInput.nativeElement.value
    var nativeElement :HTMLInputElement=this.fileInput.nativeElement;
    this.productService.uploadImage(this.productImage.productId,nativeElement.files[0])
    .subscribe(x=>{
      this.getProductImages();
    });
  }

  onFileSelected(){
      this.uploadedFile=this.fileInput.nativeElement.value
  }

  getProductImages(){
    this.productService.getProductImages(this.productService.tempProduct.productId).subscribe(data=>{
      this.productImages=[...data]
      console.log("these are product images fetched");
      console.log(this.productImages);
    })
  }

}
