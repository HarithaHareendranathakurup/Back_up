import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{RouterModule,Routes} from '@angular/router';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MynavComponent } from './mynav/mynav.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatGridListModule, MatCardModule } from '@angular/material';
import { FirstPageComponent } from "src/app/first-page/first-page.component";
import { SecondPageComponent } from "src/app/second-page/second-page.component";
import { ThirdPageComponent } from "src/app/third-page/third-page.component";
import { MindsService } from "src/app/shared/minds.service";
import { HttpClientModule } from "@angular/common/http";
import { HttpModule } from "@angular/http";
import {MatTabsModule} from '@angular/material/tabs';

const appRoutes:Routes=[
      {path:'first-page',component:FirstPageComponent},
      {path:'second-page',component:SecondPageComponent},
      {path:'third-page',component:ThirdPageComponent}
];
@NgModule({
  declarations: [
    AppComponent,
    MynavComponent,
    FirstPageComponent,
    SecondPageComponent,
    ThirdPageComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(appRoutes),
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    HttpClientModule,
    HttpModule,
    MatCardModule,
    MatGridListModule,
    MatTabsModule
  ],
  providers: [MindsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
