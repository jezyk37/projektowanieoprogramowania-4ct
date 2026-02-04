import { Component } from '@angular/core';

@Component({
  selector: 'app-potegowanie',
  standalone: false,
  templateUrl: './potegowanie.html',
  styleUrl: './potegowanie.css',
})
export class Potegowanie {
title: string = 'Potegowanie'

potegowanie(a: number, b:number):number{
return Math.pow(a,b)
}
}
