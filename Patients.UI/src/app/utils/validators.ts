import { AbstractControl } from '@angular/forms';

export class MyValidators {
  static validatePrice(control: AbstractControl) {
    const value = control.value;
    if (value > 1000) {
      return { invalid_price: true };
    }
    return null;
  }

  static validatePassword(control: AbstractControl) {
    const value = control.value;
    if (!containsNumber(value)) {
      return { invalid_password: true };
    }
    return null;
  }

  static maxLength(text: string | undefined, count: number): [boolean, string] {
    if (text != undefined && text.length > count) {
      return [true, `El texto no puede tener más de ${count} caracteres`];
    }
    return [false, ''];
  }

  static requierd(text: string | undefined): [boolean, string] {
    if (text === undefined || text === '') {
      return [true, `El campo es obligatorio`];
    }
    return [false, ''];
  }

  static email(text: string | undefined): [boolean, string] {
    const patern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

    if (text != undefined && !patern.test(text)) {
      return [true, `El campo no tiene el formato correcto`];
    }
    return [false, ''];
  }
}

function containsNumber(value: string): boolean {
  return value.split('').find((v) => isNumber(v)) != undefined;
}

function isNumber(value: string): boolean {
  return !isNaN(parseInt(value, 10));
}
