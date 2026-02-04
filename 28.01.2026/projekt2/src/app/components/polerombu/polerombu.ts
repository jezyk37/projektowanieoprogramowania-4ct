import { Component } from '@angular/core';

@Component({
  selector: 'app-polerombu',
  standalone: false,
  templateUrl: './polerombu.html',
  styleUrl: './polerombu.css',
})
export class Polerombu {
title: string = 'Pole Rombu'

Pole(a: number, h:number):number{
  return a * h;
}
}
