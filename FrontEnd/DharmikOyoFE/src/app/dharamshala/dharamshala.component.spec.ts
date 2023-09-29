import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DharamshalaComponent } from './dharamshala.component';

describe('DharamshalaComponent', () => {
  let component: DharamshalaComponent;
  let fixture: ComponentFixture<DharamshalaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DharamshalaComponent]
    });
    fixture = TestBed.createComponent(DharamshalaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
