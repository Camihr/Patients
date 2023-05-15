import { Consts } from '../utils/consts';

export function setError(error: any): string {
  if (error.error.message != undefined) {
    console.error(error.error.message);
    console.error(error.error.exception);
    return error.error.message;
  } else {
    console.error(Consts.UNKNOWN_ERROR);
    return Consts.UNKNOWN_ERROR;
  }
}
