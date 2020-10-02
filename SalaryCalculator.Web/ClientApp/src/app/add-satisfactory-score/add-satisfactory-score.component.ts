import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { Employee } from '../common/Models/employee.model';
import { EmployeeService } from '../common/services/employee.service';

@Component({
  selector: 'app-add-satisfactory-score',
  templateUrl: './add-satisfactory-score.component.html',
  styleUrls: ['./add-satisfactory-score.component.css']
})
export class AddSatisfactoryScoreComponent implements OnInit {

  employee: Employee
  score: 0;
  error: string
  constructor(public bsModalRef: BsModalRef, private _employeeService: EmployeeService) { }

  ngOnInit(): void {
  }

  onSubmit() {
    this.error = null;
    this._employeeService.saveEmployeeSatisfactoryScore(
      { employeeId: this.employee.id, score: this.score })
      .subscribe(x => {
        this.bsModalRef.hide();
      }, err => {
        this.error = err;
      })
  }

}
