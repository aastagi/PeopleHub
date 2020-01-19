import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent implements OnInit {

  images:string[];
  constructor(private dataService:DataService) { }

  ngOnInit() {
    this.images=this.dataService.getCarousalmages();
  }

}
