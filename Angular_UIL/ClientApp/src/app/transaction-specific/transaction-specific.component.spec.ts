import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TransactionSpecificComponent } from './transaction-specific.component';

describe('TransactionSpecificComponent', () => {
  let component: TransactionSpecificComponent;
  let fixture: ComponentFixture<TransactionSpecificComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TransactionSpecificComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TransactionSpecificComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
