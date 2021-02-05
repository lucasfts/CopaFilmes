import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CopaHeaderComponent } from './copa-header.component';

describe('CopaHeaderComponent', () => {
  let component: CopaHeaderComponent;
  let fixture: ComponentFixture<CopaHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CopaHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CopaHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
