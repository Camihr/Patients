import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagementPatientComponent } from './management-patient.component';

describe('ManagementPatientComponent', () => {
  let component: ManagementPatientComponent;
  let fixture: ComponentFixture<ManagementPatientComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ManagementPatientComponent]
    });
    fixture = TestBed.createComponent(ManagementPatientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
