import { Component, OnInit } from '@angular/core';
import {Minds} from '../shared/minds';

import { MindsService } from "src/app/shared/minds.service";

@Component({
  selector: 'app-third-page',
  templateUrl: './third-page.component.html',
  styleUrls: ['./third-page.component.css']
})
export class ThirdPageComponent implements OnInit {

  constructor(private ms:MindsService) { }

  ngOnInit() {
    this.ms.getMindsList();
  }

}
