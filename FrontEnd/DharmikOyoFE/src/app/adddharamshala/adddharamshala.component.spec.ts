import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdddharamshalaComponent } from './adddharamshala.component';

describe('AdddharamshalaComponent', () => {
  let component: AdddharamshalaComponent;
  let fixture: ComponentFixture<AdddharamshalaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdddharamshalaComponent]
    });
    fixture = TestBed.createComponent(AdddharamshalaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
