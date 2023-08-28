import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalcCDBComponent } from './calc-cdb.component';

describe('CalcCDBComponent', () => {
  let component: CalcCDBComponent;
  let fixture: ComponentFixture<CalcCDBComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CalcCDBComponent]
    });
    fixture = TestBed.createComponent(CalcCDBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
