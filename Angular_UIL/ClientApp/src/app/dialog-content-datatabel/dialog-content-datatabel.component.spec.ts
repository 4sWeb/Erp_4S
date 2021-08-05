import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogContentDatatabelComponent } from './dialog-content-datatabel.component';

describe('DialogContentDatatabelComponent', () => {
  let component: DialogContentDatatabelComponent;
  let fixture: ComponentFixture<DialogContentDatatabelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DialogContentDatatabelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogContentDatatabelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
