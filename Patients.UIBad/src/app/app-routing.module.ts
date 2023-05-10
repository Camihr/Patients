import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PersonsComponent } from './pages/persons/persons.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { PatientsComponent } from './pages/patients/patients.component';
import { HomeComponent } from './pages/home/home.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: 'patients',
    component: PatientsComponent,
  },
  {
    path: 'persons',
    component: PersonsComponent,
  },
  {
    path: 'not-found',
    component: NotFoundComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
