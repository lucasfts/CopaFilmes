using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain
{
    public class Partida
    {
        public Filme PrimeiroFilme { get; private set; }
        public Filme SegundoFilme { get; private set; }

        public Partida(Filme primeiroFilme, Filme segundoFilme)
        {
            if (primeiroFilme.Id == segundoFilme.Id)
                throw new Exception("Não é possível realizar a partida entre 2 filmes iguais");

            PrimeiroFilme = primeiroFilme;
            SegundoFilme = segundoFilme;
        }

        public Filme ObterVencedor()
        {
            var filmes = new List<Filme> { PrimeiroFilme, SegundoFilme };
            return filmes.OrderByDescending(x => x.Nota).ThenBy(x => x.Titulo).First();
        }

        public Filme ObterPerdedor()
        {
            var vencedor = ObterVencedor();
            return PrimeiroFilme.Id != vencedor.Id ? PrimeiroFilme : SegundoFilme;
        }
    }
}
