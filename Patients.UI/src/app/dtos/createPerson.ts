import { Person } from '../models/person';

export interface CreatePerson extends Omit<Person, 'id'> {}
