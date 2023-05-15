import { Component, OnInit } from '@angular/core';
import { MastersService } from 'src/app/services/masters.service';
import { PersonsService } from 'src/app/services/persons.service';
import { Master } from '../../models/master';
import { DataMaster } from '../../models/dataMaster';
import { Person } from '../../models/person';
import { ResponseMode } from '../../models/responseModel';
import { Consts } from '../../utils/consts';
import { setError } from '../../utils/errorManage';
import { UpdatePersonDTO } from '../../models/person';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.scss'],
})
export class PersonsComponent implements OnInit {
  constructor(
    private mastersService: MastersService,
    private personsService: PersonsService
  ) {}

  ngOnInit(): void {
    this.getPersons();
    this.getMasters();
  }

  personToUpdate: UpdatePersonDTO = {};
  persons: Person[] = [];
  masters: Master[] = [];
  gendersData?: DataMaster[] = [];
  userTypesData?: DataMaster[] = [];
  arePersons: boolean = false;
  isManagerPersonVisible: boolean = false;
  isEditing: boolean = false;
  popupTitle: string = 'Creación de Usuario';

  getPersons() {
    this.personsService.getAll().subscribe(
      (data) => {
        this.persons = data.data;
        this.arePersons = this.persons.length > 0;
      },
      (error) => {
        setError(error);
      }
    );
  }

  getMasters() {
    this.mastersService.getMasters().subscribe(
      (data) => {
        this.masters = data.data;
        this.setDataMasters();
      },
      (error) => {
        setError(error);
      }
    );
  }

  setDataMasters() {
    if (this.masters != null && this.masters.length > 0) {
      this.masters.map((data) => {
        if (data.description === Consts.MASTERS.gender) {
          this.gendersData = data.dataMasters;
        } else if (data.description === Consts.MASTERS.userType) {
          this.userTypesData = data.dataMasters;
        }
      });
    }
  }

  savePerson() {
    this.isManagerPersonVisible = false;

    if (this.isEditing) {
      this.personsService
        .update(
          this.personToUpdate,
          this.personToUpdate.id === undefined ? 0 : this.personToUpdate.id
        )
        .subscribe(
          (data) => {
            this.getPersons();
          },
          (error) => {
            setError(error);
          }
        );
    } else {
      this.personsService.create(this.personToUpdate).subscribe(
        (data) => {
          this.getPersons();
        },
        (error) => {
          setError(error);
        }
      );
    }
  }

  closePopup() {
    this.isManagerPersonVisible = false;
  }

  openCreatePopup() {
    this.personToUpdate = {};
    this.popupTitle = 'Creación de Usuario';
    this.isEditing = false;
    this.isManagerPersonVisible = true;
  }

  openUpdatePopup(person: Person) {
    this.personToUpdate = person;
    this.popupTitle = 'Edición de Usuario';
    this.isEditing = true;
    this.isManagerPersonVisible = true;
  }
}
