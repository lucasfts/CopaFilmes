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
            MontarChaveamento();
        }

        private void MontarChaveamento()
        {
            OrdenarFilmes();
            PreencherPrimeiraFase();
            PreencherSemiFinal();
            PreencherFinal();
        }

        private void OrdenarFilmes()
        {
            Filmes = Filmes.OrderBy(x => x.Titulo).ToArray();
        }

        private void PreencherPrimeiraFase()
        {
            var totalPartidas = 4;

            PrimeiraFase = new Partida[totalPartidas];
            for (int i = 0; i < totalPartidas; i++)
            {
                var primeiroFilme = Filmes[i];
                var segundoFilme = Filmes[Filmes.Length - i - 1];
                PrimeiraFase[i] = new Partida(primeiroFilme, segundoFilme);
            }
        }

        private void PreencherSemiFinal()
        {
            SemiFinal = new Partida[2];

            for (int i = 0; i < SemiFinal.Length; i++)
            {
                var primeiroFilme = PrimeiraFase[i].ObterVencedor();
                var segundoFilme = PrimeiraFase[PrimeiraFase.Length - i - 1].ObterVencedor();
                SemiFinal[i] = new Partida(primeiroFilme, segundoFilme);
            }
        }

        private void PreencherFinal()
        {
            var primeiroFilme = SemiFinal[0].ObterVencedor();
            var segundoFilme = SemiFinal[1].ObterVencedor();
            Final = new Partida(primeiroFilme, segundoFilme);
        }
    }
}
