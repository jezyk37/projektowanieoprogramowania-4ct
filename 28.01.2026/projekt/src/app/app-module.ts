import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Dodawanie } from './components/dodawanie/dodawanie';
import { Dzielenie } from './components/dzielenie/dzielenie';
import { Odejmowanie } from './components/odejmowanie/odejmowanie';
import { Mnozenie } from './components/mnozenie/mnozenie';
import { Potegowanie } from './components/potegowanie/potegowanie';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    App,
    Dodawanie,
    Dzielenie,
    Odejmowanie,
    Mnozenie,
    Potegowanie
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
  ],
  bootstrap: [App]
})
export class AppModule { }
