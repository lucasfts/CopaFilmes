using CopaFilmes.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.UnitTests.Domain
{
    [TestClass]
    public class EliminatoriasTests
    {
        [TestMethod]
        [DataRow(7)]
        [DataRow(9)]
        public void ExcecaoAoInstanciarComNumeroDeFilmesInvalidos(int quantidadeFilmes)
        {
            var filmes = GerarListaDeFilmes(quantidadeFilmes);

            try
            {
                var eliminatorias = new Eliminatorias(filmes);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("As eliminatorias devem ter 8 filmes", ex.Message);
            }
        }

        [TestMethod]
        public void SucessoAoInstanciarComNumeroDeFilmesValido()
        {
            var quantidadeValida = 8;
            var filmes = GerarListaDeFilmes(quantidadeValida);


            var eliminatorias = new Eliminatorias(filmes);
            Assert.AreEqual(quantidadeValida, eliminatorias.Filmes.Count());
        }

        [TestMethod]
        public void SucessoAoInstanciarComNumeroDeFilmesValidoEAvancarAteAFinal()
        {
            var quantidadeValida = 8;
            var filmes = GerarListaDeFilmes(quantidadeValida);


            var eliminatorias = new Eliminatorias(filmes);

            eliminatorias.OrdenarFilmes()
                .PreencherPrimeiraFase()
                .PreencherSemiFinal()
                .PreencherFinal();

            Assert.AreEqual(quantidadeValida, eliminatorias.Filmes.Count());
        }

        private List<Filme> GerarListaDeFilmes(int quantidadeFilmes)
        {
            var filmes = new List<Filme>();

            var random = new Random();
            for (int i = 0; i < quantidadeFilmes; i++)
            {
                filmes.Add(new Filme($"Id{i}", $"titulo{i}", 2020, random.Next(0, 10)));
            }

            return filmes;
        }
    }
}
