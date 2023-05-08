import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ResponseMode } from '../models/responseModel';
import { API_URL } from '../consts/consts';

@Injectable({
  providedIn: 'root'
})
export class PersonsService {

  constructor(private http : HttpClient) { }

  patientsEnables(){
    return this.http.get<ResponseMode<boolean>>(`${API_URL}Persons/PatientsEnables`)
  }
}
