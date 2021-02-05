import { Filme } from './../../models/filme';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';
import { Campeonato } from 'src/models/campeonato';


@Injectable({
  providedIn: 'root'
})
export class CopaService {

  constructor(private http: HttpClient) { }

  obterFilmes() {
    return this.http.get<Filme[]>(`${environment.API_URL}/filmes`);
  }

  gerarCampeonato(filmesSelecionados: Filme[]) {
    return this.http.post<Campeonato>(`${environment.API_URL}/campeonato/gerar`, filmesSelecionados);
  }

}
