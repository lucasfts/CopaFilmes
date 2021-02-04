import { Filme } from './../../models/filme';
import { CopaService } from './../../services/copa/copa.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-fase-selecao',
  templateUrl: './fase-selecao.component.html',
  styleUrls: ['./fase-selecao.component.css']
})
export class FaseSelecaoComponent implements OnInit {
  filmes: Filme[];

  constructor(private service: CopaService) { }

  ngOnInit(): void {
    this.service.obterFilmes().subscribe(filmes => {
      console.log(filmes);
      this.filmes = filmes;
    });
  }

}
