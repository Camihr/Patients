import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Master } from '../models/master';
import { ResponseMode } from '../models/responseModel';
import { API_URL } from '../consts/consts';

@Injectable({
  providedIn: 'root'
})
export class MastersService {
  constructor(private http : HttpClient) { }

  getMasters(){
    return this.http.get<ResponseMode<Master[]>>(`${API_URL}Masters`)
  }
}
