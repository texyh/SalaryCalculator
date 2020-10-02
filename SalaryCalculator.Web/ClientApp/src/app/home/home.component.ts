import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from './common/Models/employee.model';
import { EmployeeService } from './common/services/employee.service';
import {map} from 'rxjs/operators'
import { Console } from 'console';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit
{

  public employees: Employee[] = [];
  public selectedEmployee: Employee;

  constructor(private _employeeService: EmployeeService) {}

  ngOnInit(): void {
    this._employeeService.getEmployees().subscribe(x =>  {
      this.employees = x;
    })
  }

  selectEmployee (employee: Employee) {
    this.selectedEmployee = employee;
  }
  
}
