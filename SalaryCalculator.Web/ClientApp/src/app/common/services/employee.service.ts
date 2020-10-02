import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Employee } from "../Models/employee.model";
import { SaveEmployeeSatisfactoryScore } from "../Models/saveEmployeeSatisfacoryScore.model";


@Injectable()
export class EmployeeService 
{
    private _employeeEndPoint;

    constructor(
        private _http: HttpClient,
        @Inject('BASE_URL') baseUrl: string
    ) {
        this._employeeEndPoint = `${baseUrl}api/employees`;

    }

    getEmployees(): Observable<Employee[]> {
        return this._http.get<Employee[]>(this._employeeEndPoint);
    }

    saveEmployeeSatisfactoryScore(model: SaveEmployeeSatisfactoryScore) {
        return this._http.post(`${this._employeeEndPoint}/satisfactory-score`, model);
    }
}