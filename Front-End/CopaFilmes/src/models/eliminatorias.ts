import { Partida } from './partida';

export interface Eliminatorias {
    primeiraFase: Partida[];
    semiFinal: Partida[];
    final: Partida;
}