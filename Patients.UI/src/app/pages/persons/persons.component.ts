import { Component, OnInit } from '@angular/core';
import { MastersService } from 'src/app/services/masters.service';
import { Master } from '../../models/master';
import { ResponseMode } from '../../models/responseModel';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.scss']
})

export class PersonsComponent implements OnInit {

constructor(private mastersService:MastersService){}

 ngOnInit(): void {
  this.mastersService.getMasters().subscribe(
    (data) => {
      if (data != null) {
       /// this.arePatientsEnables = data.data;
      }
    },
    (errorMessage) => {
      console.error(errorMessage);
    }
  );
 }
}
