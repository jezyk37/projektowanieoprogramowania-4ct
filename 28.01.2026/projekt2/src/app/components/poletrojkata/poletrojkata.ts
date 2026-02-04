import { Component } from '@angular/core';

@Component({
  selector: 'app-poletrojkata',
  standalone: false,
  templateUrl: './poletrojkata.html',
  styleUrl: './poletrojkata.css',
})
export class Poletrojkata {
title: string = 'Pole Trojkata'

Pole(a: number, h:number):number{
  return a * h/2;
}
}
