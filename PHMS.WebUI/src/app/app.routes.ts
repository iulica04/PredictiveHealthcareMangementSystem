import { Routes } from '@angular/router';
import { PatientListComponent } from './components/patient-list/patient-list.component';
import { PatientCreateComponent } from './components/patient-create/patient-create.component';
import { PatientUpdateComponent } from './components/patient-update/patient-update.component';
import { PatientDetailComponent } from './components/patient-detail/patient-detail.component';
import { MedicListComponent } from './components/medic-list/medic-list.component';
import { MedicCreateComponent } from './components/medic-create/medic-create.component';
import { MedicDetailComponent } from './components/medic-detail/medic-detail.component';
import { MedicUpdateComponent } from './components/medic-update/medic-update.component';
import { MedicGetAllComponent } from './components/medic-get-all/medic-get-all.component';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'patients', component: PatientListComponent },
    { path: 'patients/register', component: PatientCreateComponent },
    { path: 'medics/register', component: MedicCreateComponent },
    { path: 'patients/update/:id', component: PatientUpdateComponent },
    { path: 'patients/:id', component: PatientDetailComponent },
    { path: 'medics', component: MedicListComponent },
    { path: 'medics/create', component: MedicCreateComponent },
    { path: 'medics/paginated', component: MedicGetAllComponent },
    { path: 'medics/:id', component: MedicDetailComponent },
    { path: 'medics/update/:id', component: MedicUpdateComponent },
    // Login route with query parameter to distinguish between medic and patient
    { path: 'login', component: LoginComponent },
    { path: 'medics/login', component: LoginComponent },

    
];
