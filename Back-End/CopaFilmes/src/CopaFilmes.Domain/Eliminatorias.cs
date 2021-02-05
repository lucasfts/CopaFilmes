using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Domain
{
    public class Eliminatorias
    {
        public Filme[] Filmes { get; private set; }
        public Partida[] PrimeiraFase { get; private set; }
        public Partida[] SemiFinal { get; private set; }
        public Partida Final { get; private set; }

        public Eliminatorias(IEnumerable<Filme> filmes)
        {
            if (filmes.Count() != 8)
                throw new Exception("As eliminatorias devem ter 8 filmes");

            Filmes = filmes.ToArray();
        }

        public Eliminatorias OrdenarFilmes()
        {
            Filmes = Filmes.OrderBy(x => x.Titulo).ToArray();

            return this;
        }

        public Eliminatorias PreencherPrimeiraFase()
        {
            var totalPartidas = 4;

            PrimeiraFase = new Partida[totalPartidas];
            for (int i = 0; i < totalPartidas; i++)
            {
                var primeiroFilme = Filmes[i];
                var segundoFilme = Filmes[Filmes.Length - i - 1];
                PrimeiraFase[i] = new Partida(primeiroFilme, segundoFilme);
            }

            return this;
        }

        public Eliminatorias PreencherSemiFinal()
        {
            if (PrimeiraFase == null || PrimeiraFase.Count() < 4)
                throw new Exception("Não é possível avançar para a semifinal antes da primeira fase");

            SemiFinal = new Partida[2];

            for (int i = 0; i < SemiFinal.Length; i++)
            {
                var primeiroFilme = PrimeiraFase[i].ObterVencedor();
                var segundoFilme = PrimeiraFase[PrimeiraFase.Length - i - 1].ObterVencedor();
                SemiFinal[i] = new Partida(primeiroFilme, segundoFilme);
            }

            return this;
        }

        public Eliminatorias PreencherFinal()
        {
            if (SemiFinal == null || SemiFinal.Count() < 2)
                throw new Exception("Não é possível avançar para a final antes da semifinal");

            var primeiroFilme = SemiFinal[0].ObterVencedor();
            var segundoFilme = SemiFinal[1].ObterVencedor();
            Final = new Partida(primeiroFilme, segundoFilme);

            return this;
        }
    }
}
