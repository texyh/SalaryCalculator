import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ModalModule } from 'ngx-bootstrap/modal';
import { EmployeeService } from '../common/services/employee.service';

import { AddSatisfactoryScoreComponent } from './add-satisfactory-score.component';

describe('AddSatisfactoryScoreComponent', () => {
  let component: AddSatisfactoryScoreComponent;
  let fixture: ComponentFixture<AddSatisfactoryScoreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddSatisfactoryScoreComponent ],
      imports: [ModalModule.forRoot()],
      providers: [{provide: EmployeeService, useValue: {}}]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddSatisfactoryScoreComponent);
    component = fixture.componentInstance;
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
