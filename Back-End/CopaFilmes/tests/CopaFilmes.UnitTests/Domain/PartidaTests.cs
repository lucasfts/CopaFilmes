using CopaFilmes.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.UnitTests.Domain
{
    [TestClass]
    public class PartidaTests
    {
        [TestMethod]
        public void PrimeiroFilmeVencedorComNotaMaior()
        {
            var primeiroFilme = new Filme("teste1", "abc", 2010, 7);
            var segundoFilme = new Filme("teste2", "def", 2010, 6);

            var partida = new Partida(primeiroFilme, segundoFilme);
            var vencedor = partida.ObterVencedor();
            var perdedor = partida.ObterPerdedor();

            Assert.AreEqual(primeiroFilme.Id, vencedor.Id);
            Assert.AreEqual(segundoFilme.Id, perdedor.Id);
        }

        [TestMethod]
        public void SegundoFilmeVencedorComNotaMaior()
        {
            var primeiroFilme = new Filme("teste1", "abc", 2010, 7);
            var segundoFilme = new Filme("teste2", "def", 2010, 8);

            var partida = new Partida(primeiroFilme, segundoFilme);
            var vencedor = partida.ObterVencedor();
            var perdedor = partida.ObterPerdedor();

            Assert.AreEqual(segundoFilme.Id, vencedor.Id);
            Assert.AreEqual(primeiroFilme.Id, perdedor.Id);
        }

        [TestMethod]
        public void PrimeiroFilmeVencedorPorOrdemAlfabetica()
        {
            var primeiroFilme = new Filme("teste1", "Titulo a", 2010, 9);
            var segundoFilme = new Filme("teste2", "Titulo b", 2010, 9);

            var partida = new Partida(primeiroFilme, segundoFilme);
            var vencedor = partida.ObterVencedor();
            var perdedor = partida.ObterPerdedor();

            Assert.AreEqual(primeiroFilme.Id, vencedor.Id);
            Assert.AreEqual(segundoFilme.Id, perdedor.Id);
        }

        [TestMethod]
        public void SegundoFilmeVencedorPorOrdemAlfabetica()
        {
            var primeiroFilme = new Filme("teste1", "Titulo b", 2010, 9);
            var segundoFilme = new Filme("teste2", "Titulo a", 2010, 9);

            var partida = new Partida(primeiroFilme, segundoFilme);
            var vencedor = partida.ObterVencedor();
            var perdedor = partida.ObterPerdedor();

            Assert.AreEqual(segundoFilme.Id, vencedor.Id);
            Assert.AreEqual(primeiroFilme.Id, perdedor.Id);
        }

    }
}
