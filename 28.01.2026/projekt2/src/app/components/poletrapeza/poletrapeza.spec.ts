import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Poletrapeza } from './poletrapeza';

describe('Poletrapeza', () => {
  let component: Poletrapeza;
  let fixture: ComponentFixture<Poletrapeza>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Poletrapeza]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Poletrapeza);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
