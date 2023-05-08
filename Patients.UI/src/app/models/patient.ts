import { Person } from "./person";

export interface Patient{
    id : number,
    user  : string,
    condition : string ,
    person : Person,
    doctor : Person,
    created: Date
}