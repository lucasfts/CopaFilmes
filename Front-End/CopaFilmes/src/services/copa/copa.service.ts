import { Filme } from './../../models/filme';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class CopaService {

  constructor(private http: HttpClient) { }

  obterFilmes() {
    return this.http.get<Filme[]>(`${environment.API_URL}/filmes`);
  }
}
