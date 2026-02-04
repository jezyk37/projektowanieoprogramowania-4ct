import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Poletrojkata } from './poletrojkata';

describe('Poletrojkata', () => {
  let component: Poletrojkata;
  let fixture: ComponentFixture<Poletrojkata>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Poletrojkata]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Poletrojkata);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
