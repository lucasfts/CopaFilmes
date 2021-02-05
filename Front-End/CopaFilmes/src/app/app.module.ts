import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';

import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { FaseSelecaoComponent } from './fase-selecao/fase-selecao.component';
import { ResultadoFinalComponent } from './resultado-final/resultado-final.component';
import { HttpClientModule } from '@angular/common/http';
import { CopaHeaderComponent } from './copa-header/copa-header.component';

@NgModule({
  declarations: [
    AppComponent,
    FaseSelecaoComponent,
    ResultadoFinalComponent,
    CopaHeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
