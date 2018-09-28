import { Injectable } from '@angular/core';
import {Minds} from './Minds';
import{Http,Response,Headers,RequestOptions,RequestMethod} from '@angular/http';
import { Observable, pipe } from 'rxjs';
import { map } from "rxjs/operators";
import {NgModule} from'@angular/core';
//import { pipe } from "@angular/core/src/render3/pipe";

//import { map } from "rxjs/internal/operators/map";
//import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MindsService {
  mindsList:Minds[]

  constructor(private http:Http) { }
  getMindsList(){
return this.http.get('http://localhost:53624/api/MindDetails').pipe(map((data:Response)=>{
      return data.json() as Minds[];
    })).subscribe(x=>this.mindsList=x);

  }
}
