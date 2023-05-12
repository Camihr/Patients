import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { CreatePerson } from '../../dtos/createPerson';

@Component({
  selector: 'app-management-person',
  templateUrl: './management-person.component.html',
  styleUrls: ['./management-person.component.scss'],
})
export class ManagementPersonComponent {
  nameField = new FormControl();

  person: CreatePerson = {
    document: '',
    names: '',
    lastNames: '',
    born: new Date(),
    userType: '',
    gender: '',
    user: '',
    address: '',
    photo: '',
    phone: '',
    cellPhone: '',
    email: '',
    created: new Date(),
  };
}
