import { Component } from '@angular/core';

@Component({
  selector: 'app-poletrapeza',
  standalone: false,
  templateUrl: './poletrapeza.html',
  styleUrl: './poletrapeza.css',
})
export class Poletrapeza {
title: string = 'Pole Trapeza'

Pole(a: number, b:number, h:number):number{
  return ((a + b) * h ) /2;
}
}
