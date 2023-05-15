import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ResponseMode } from '../models/responseModel';
import { Consts } from '../utils/consts';
import { Person } from '../models/person';
import { UpdatePersonDTO } from '../models/person';

@Injectable({
  providedIn: 'root',
})
export class PersonsService {
  constructor(private http: HttpClient) {}

  patientsEnables() {
    return this.http.get<ResponseMode<boolean>>(
      `${Consts.API_URL}Persons/PatientsEnables`
    );
  }

  getAll() {
    return this.http.get<ResponseMode<Person[]>>(`${Consts.API_URL}Persons`);
  }

  create(data: UpdatePersonDTO) {
    return this.http.post(`${Consts.API_URL}Persons`, data);
  }

  update(data: UpdatePersonDTO, id: number) {
    return this.http.put(`${Consts.API_URL}Persons/${id}`, data);
  }
}
