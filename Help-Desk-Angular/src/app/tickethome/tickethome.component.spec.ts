import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TickethomeComponent } from './tickethome.component';

describe('TickethomeComponent', () => {
  let component: TickethomeComponent;
  let fixture: ComponentFixture<TickethomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TickethomeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TickethomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
