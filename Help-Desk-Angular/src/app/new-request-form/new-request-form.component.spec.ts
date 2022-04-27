import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewRequestFormComponent } from './new-request-form.component';

describe('NewRequestFormComponent', () => {
  let component: NewRequestFormComponent;
  let fixture: ComponentFixture<NewRequestFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewRequestFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewRequestFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
