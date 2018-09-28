import { Component, OnInit } from '@angular/core';
import { MindsService } from "src/app/shared/minds.service";
import {Minds} from '../shared/minds';
import {NgModule} from'@angular/core';

@Component({
  selector: 'app-first-page',
  templateUrl: './first-page.component.html',
  styleUrls: ['./first-page.component.css'],
  providers:[MindsService]
})
export class FirstPageComponent implements OnInit {

  constructor(private ms:MindsService) { }

  ngOnInit() {
    this.ms.getMindsList();
  }
  public cols: number=3;
  checkWidth()
  { var width = window.innerWidth;
  if (width <= 768) {
  this.cols=1;
  } else if (width > 768 && width<=992) {
  this.cols=2;
  } 
  else{
  this.cols=3;
  }
  } 
  

}
