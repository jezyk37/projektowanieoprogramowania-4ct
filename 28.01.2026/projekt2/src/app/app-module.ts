import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Poletrojkata } from './components/poletrojkata/poletrojkata';
import { Polerombu } from './components/polerombu/polerombu';
import { Poletrapeza } from './components/poletrapeza/poletrapeza';
import { Poleprostowaka } from './components/poleprostowaka/poleprostowaka';

@NgModule({
  declarations: [
    App,
    Poletrojkata,
    Polerombu,
    Poletrapeza,
    Poleprostowaka
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
