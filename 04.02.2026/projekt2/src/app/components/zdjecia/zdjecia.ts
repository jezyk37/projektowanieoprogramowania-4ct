import { Component } from '@angular/core';

@Component({
  selector: 'app-zdjecia',
  standalone: false,
  templateUrl: './zdjecia.html',
  styleUrl: './zdjecia.css',
})
export class Zdjecia {
isActive1: boolean = false;
isActive2: boolean = false;
isActive3: boolean = false;
isActive4: boolean = false;
isActive5: boolean = false; 

foto1:string = 'public/zdjecia/k1.jpg'
foto2:string = 'public/zdjecia/k2.jpg'
foto3:string = 'public/zdjecia/k3.jpg'
foto4:string = 'public/zdjecia/k4.jpg'
foto5:string = 'public/zdjecia/k5.jpg'
}
