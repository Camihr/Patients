import {
  Component,
  ViewChild,
  ElementRef,
  Input,
  Output,
  EventEmitter,
  OnInit,
} from '@angular/core';
import { DataMaster } from '../../models/dataMaster';
import { FormControl, Validators, Form } from '@angular/forms';
import { UpdatePersonDTO } from '../../models/person';
import { MyValidators } from '../../utils/validators';

@Component({
  selector: 'app-management-person',
  templateUrl: './management-person.component.html',
  styleUrls: ['./management-person.component.scss'],
})
export class ManagementPersonComponent implements OnInit {
  @Input() personToUpdate: UpdatePersonDTO = {};
  @Input() gendersData?: DataMaster[] = [];
  @Input() userTypesData?: DataMaster[] = [];
  @Output() save = new EventEmitter();
  @Output() close = new EventEmitter();

  ngOnInit(): void {
    this.person.id = this.personToUpdate.id;
    this.person.document = this.personToUpdate.document;
    this.person.names = this.personToUpdate.names;
    this.person.lastNames = this.personToUpdate.lastNames;
    this.person.gender = this.personToUpdate.gender;
    this.person.userType = this.personToUpdate.userType;
    this.person.address = this.personToUpdate.address;
    this.person.phone = this.personToUpdate.phone;
    this.person.cellPhone = this.personToUpdate.cellPhone;
    this.person.photo = this.personToUpdate.photo;
    this.person.email = this.personToUpdate.email;
    this.person.user = this.personToUpdate.user;
    this.person.born = this.personToUpdate.born;
  }

  isFormValid: boolean = false;
  person: UpdatePersonDTO = {};

  closePopup() {
    this.close.emit();
  }

  @ViewChild('document') document: any;
  @ViewChild('names') names: any;
  @ViewChild('lastNames') lastNames: any;
  @ViewChild('born') born: any;
  @ViewChild('userType') userType: any;
  @ViewChild('gender') gender: any;
  @ViewChild('address') address: any;
  @ViewChild('photo') photo: any;
  @ViewChild('phone') phone: any;
  @ViewChild('cellPhone') cellPhone: any;
  @ViewChild('email') email: any;

  trySave() {
    if (!this.isFormValud()) {
      this.document.control.markAsTouched();
      this.names.control.markAsTouched();
      this.lastNames.control.markAsTouched();
      this.born.control.markAsTouched();
      this.userType.control.markAsTouched();
      this.gender.control.markAsTouched();
      this.address.control.markAsTouched();
      this.photo.control.markAsTouched();
      this.phone.control.markAsTouched();
      this.cellPhone.control.markAsTouched();
      this.email.control.markAsTouched();

      return;
    }

    this.personToUpdate.id = this.person.id;
    this.personToUpdate.document = this.person.document;
    this.personToUpdate.names = this.person.names;
    this.personToUpdate.lastNames = this.person.lastNames;
    this.personToUpdate.gender = this.person.gender;
    this.personToUpdate.userType = this.person.userType;
    this.personToUpdate.address = this.person.address;
    this.personToUpdate.phone = this.person.phone;
    this.personToUpdate.cellPhone = this.person.cellPhone;
    this.personToUpdate.photo = this.person.photo;
    this.personToUpdate.email = this.person.email;
    this.personToUpdate.user = this.person.user;
    this.personToUpdate.born = this.person.born;

    this.save.emit();
  }

  get documentValid(): string {
    if (MyValidators.requierd(this.person.document)[0]) {
      return MyValidators.requierd(this.person.document)[1];
    }
    if (MyValidators.maxLength(this.person.document, 20)[0]) {
      return MyValidators.maxLength(this.person.document, 20)[1];
    }
    return '';
  }
  get namesValid(): string {
    if (MyValidators.requierd(this.person.names)[0]) {
      return MyValidators.requierd(this.person.names)[1];
    }
    if (MyValidators.maxLength(this.person.names, 60)[0]) {
      return MyValidators.maxLength(this.person.names, 60)[1];
    }
    return '';
  }
  get lastNamesValid(): string {
    if (MyValidators.requierd(this.person.lastNames)[0]) {
      return MyValidators.requierd(this.person.lastNames)[1];
    }
    if (MyValidators.maxLength(this.person.lastNames, 60)[0]) {
      return MyValidators.maxLength(this.person.lastNames, 60)[1];
    }
    return '';
  }
  get bornValid(): string {
    if (this.person.born === undefined || this.person.born === null) {
      return 'El campo es obligatorio';
    }
    return '';
  }
  get userTypeValid(): string {
    if (MyValidators.requierd(this.person.userType)[0]) {
      return MyValidators.requierd(this.person.userType)[1];
    }
    if (MyValidators.maxLength(this.person.userType, 10)[0]) {
      return MyValidators.maxLength(this.person.userType, 10)[1];
    }
    return '';
  }
  get genderValid(): string {
    if (MyValidators.requierd(this.person.gender)[0]) {
      return MyValidators.requierd(this.person.gender)[1];
    }
    if (MyValidators.maxLength(this.person.gender, 10)[0]) {
      return MyValidators.maxLength(this.person.gender, 10)[1];
    }
    return '';
  }
  get addressValid(): string {
    if (MyValidators.requierd(this.person.address)[0]) {
      return MyValidators.requierd(this.person.address)[1];
    }
    if (MyValidators.maxLength(this.person.address, 200)[0]) {
      return MyValidators.maxLength(this.person.address, 200)[1];
    }
    return '';
  }
  get photoValid(): string {
    if (MyValidators.requierd(this.person.photo)[0]) {
      return MyValidators.requierd(this.person.photo)[1];
    }
    if (MyValidators.maxLength(this.person.photo, 500)[0]) {
      return MyValidators.maxLength(this.person.photo, 500)[1];
    }
    return '';
  }
  get phoneValid(): string {
    if (MyValidators.requierd(this.person.phone)[0]) {
      return MyValidators.requierd(this.person.phone)[1];
    }
    if (MyValidators.maxLength(this.person.phone, 20)[0]) {
      return MyValidators.maxLength(this.person.phone, 20)[1];
    }
    return '';
  }
  get cellPhoneValid(): string {
    if (MyValidators.requierd(this.person.cellPhone)[0]) {
      return MyValidators.requierd(this.person.cellPhone)[1];
    }
    if (MyValidators.maxLength(this.person.cellPhone, 20)[0]) {
      return MyValidators.maxLength(this.person.cellPhone, 20)[1];
    }
    return '';
  }
  get emailValid(): string {
    if (MyValidators.requierd(this.person.email)[0]) {
      return MyValidators.requierd(this.person.email)[1];
    }
    if (MyValidators.maxLength(this.person.email, 200)[0]) {
      return MyValidators.maxLength(this.person.email, 200)[1];
    }
    if (MyValidators.email(this.person.email)[0]) {
      return MyValidators.email(this.person.email)[1];
    }
    return '';
  }

  get userValid(): string {
    if (MyValidators.requierd(this.person.user)[0]) {
      return MyValidators.requierd(this.person.user)[1];
    }
    if (MyValidators.maxLength(this.person.user, 150)[0]) {
      return MyValidators.maxLength(this.person.user, 150)[1];
    }
    return '';
  }

  isFormValud(): boolean {
    let isValid = true;

    if (this.documentValid != '') {
      isValid = false;
    }
    if (this.namesValid != '') {
      isValid = false;
    }
    if (this.lastNamesValid != '') {
      isValid = false;
    }
    if (this.bornValid != '') {
      isValid = false;
    }
    if (this.userTypeValid != '') {
      isValid = false;
    }
    if (this.genderValid != '') {
      isValid = false;
    }
    if (this.addressValid != '') {
      isValid = false;
    }
    if (this.photoValid != '') {
      isValid = false;
    }
    if (this.phoneValid != '') {
      isValid = false;
    }
    if (this.cellPhoneValid != '') {
      isValid = false;
    }
    if (this.emailValid != '') {
      isValid = false;
    }
    if (this.userValid != '') {
      isValid = false;
    }

    return isValid;
  }
}
