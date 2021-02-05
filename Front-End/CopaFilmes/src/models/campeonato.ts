import { Filme } from './filme';
import { Eliminatorias } from './eliminatorias';

export interface Campeonato {
    filmes: Filme[];
    eliminatorias: Eliminatorias;
    campeao: Filme;
    viceCampeao: Filme;
}