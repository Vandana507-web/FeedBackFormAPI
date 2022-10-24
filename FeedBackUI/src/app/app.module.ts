import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FeedbackModule } from './feedback/feedback.module';
import { HttpClientModule } from '@angular/common/http';
import { MatModule } from './mat.module';
import { DialogModule } from '@angular/cdk/dialog';
import { DialogCustomModule } from './dialog-custom/dialog-custom.module';


@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FeedbackModule,
    HttpClientModule,
    MatModule,
    DialogCustomModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 

}
