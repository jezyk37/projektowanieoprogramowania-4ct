import { Component } from '@angular/core';

@Component({
  selector: 'app-poleprostowaka',
  standalone: false,
  templateUrl: './poleprostowaka.html',
  styleUrl: './poleprostowaka.css',
})
export class Poleprostowaka {
title: string = 'Pole Prostokata'

Pole(a: number, b:number):number{
  return a * b;
}
}
