import { Component, OnInit } from '@angular/core';
import {Minds} from '../shared/minds';

import { MindsService } from "src/app/shared/minds.service";

@Component({
  selector: 'app-second-page',
  templateUrl: './second-page.component.html',
  styleUrls: ['./second-page.component.css']
})
export class SecondPageComponent implements OnInit {

  constructor(private ms:MindsService) { }

  ngOnInit() {
    this.ms.getMindsList();
  }

}
