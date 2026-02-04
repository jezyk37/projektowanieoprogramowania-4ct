import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Polerombu } from './polerombu';

describe('Polerombu', () => {
  let component: Polerombu;
  let fixture: ComponentFixture<Polerombu>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Polerombu]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Polerombu);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
