import { Campeonato } from './../../models/campeonato';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-resultado-final',
  templateUrl: './resultado-final.component.html',
  styleUrls: ['./resultado-final.component.css']
})
export class ResultadoFinalComponent implements OnInit {
  resultado: Campeonato;

  constructor(private router: Router) {
    console.log(this.router.getCurrentNavigation().extras.state);
    this.resultado = this.router.getCurrentNavigation().extras.state as Campeonato;
  }

  ngOnInit(): void {

  }

}
