import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ResponseMode } from '../models/responseModel';
import { API_URL } from '../consts/consts';
import { Person } from '../models/person';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PersonsService {
  constructor(private http: HttpClient) {}

  patientsEnables() {
    return this.http
      .get<ResponseMode<boolean>>(`${API_URL}Persons/PatientsEnables`)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          if (error.status === 5000) {
            return throwError('Error inesparado');
          }
          return throwError('Error inesparado');
        })
      );
  }

  create(data: Person) {
    return this.http.post<ResponseMode<Person>>(`${API_URL}Persons`, data);
  }
}
