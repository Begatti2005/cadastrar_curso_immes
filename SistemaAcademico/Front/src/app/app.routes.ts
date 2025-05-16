import { Routes } from '@angular/router';
import { CursoAdicionarComponent } from './curso/curso-adicionar/curso-adicionar.component';
import { CursoListarComponent } from './curso/curso-listar/curso-listar.component';
import { HomeComponent } from './home/home/home.component';

export const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'curso/listar', component: CursoListarComponent },
    { path: 'curso/adicionar', component: CursoAdicionarComponent}
];
