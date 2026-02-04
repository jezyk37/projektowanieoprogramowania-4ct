import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Poleprostowaka } from './poleprostowaka';

describe('Poleprostowaka', () => {
  let component: Poleprostowaka;
  let fixture: ComponentFixture<Poleprostowaka>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Poleprostowaka]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Poleprostowaka);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
