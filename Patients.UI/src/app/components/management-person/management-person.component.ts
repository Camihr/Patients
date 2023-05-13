import { Component, ViewChild, ElementRef } from '@angular/core';
import { FormControl, Validators, Form } from '@angular/forms';
import { CreatePersonDTO } from '../../models/person';
import { MyValidators } from '../../utils/validators';

@Component({
  selector: 'app-management-person',
  templateUrl: './management-person.component.html',
  styleUrls: ['./management-person.component.scss'],
})
export class ManagementPersonComponent {
  person: CreatePersonDTO = {
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
  };

  @ViewChild('document') document: any;
  //@ViewChild('myForm') form: any;

  isFormValid: boolean = false;

  save() {
    if (!this.isFormValid) {
      this.document.control.markAsTouched();

      // Object.keys(this.form.controls).forEach((key) => {
      //   const control = this.form.controls[key];
      //   control.markAsTouched();
      // });
    }
  }

  get documentValid(): string {
    return MyValidators.maxLength(this.person.document, 7);
    // if (this.person.document === '') {
    //   this.isFormValid = false;
    //   return 'Obligatorio';
    // }
    // return '';
  }
  get namesValid(): string {
    if (this.person.names === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get lastNamesValid(): string {
    if (this.person.lastNames === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get bornValid(): string {
    if (this.person.born === null) {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get userTypeValid(): string {
    if (this.person.userType === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get genderValid(): string {
    if (this.person.gender === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get addressValid(): string {
    if (this.person.address === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get photoValid(): string {
    if (this.person.photo === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get phoneValid(): string {
    if (this.person.phone === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get cellPhoneValid(): string {
    if (this.person.cellPhone === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
  get emailValid(): string {
    if (this.person.email === '') {
      this.isFormValid = false;
      return 'Obligatorio';
    }
    return '';
  }
}
