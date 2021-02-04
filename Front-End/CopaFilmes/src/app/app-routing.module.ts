import { ResultadoFinalComponent } from './resultado-final/resultado-final.component';
import { FaseSelecaoComponent } from './fase-selecao/fase-selecao.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: '', component: FaseSelecaoComponent },
  { path: 'resultado', component: ResultadoFinalComponent }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
