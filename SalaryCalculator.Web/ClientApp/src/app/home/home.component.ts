import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../common/Models/employee.model';
import { EmployeeService } from '../common/services/employee.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { AddSatisfactoryScoreComponent } from '../add-satisfactory-score/add-satisfactory-score.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit
{

  public employees: Employee[] = [];
  public selectedEmployee: Employee;
  bsModalRef: BsModalRef;
  
  constructor(private _employeeService: EmployeeService, 
              private _modalService: BsModalService) {}

  ngOnInit(): void {
    this._employeeService.getEmployees().subscribe(x =>  {
      this.employees = x;
    })
  }

  selectEmployee (employee: Employee) {
    this.selectedEmployee = employee;
  }

 
  addSatisfactoryScoretoSelectedEmployee() {
    const initialState = {
      employee: this.selectedEmployee
    };

    this.bsModalRef = this._modalService.show(AddSatisfactoryScoreComponent, {initialState});
    this.bsModalRef.content.closeBtnName = 'Close';
  }
} 