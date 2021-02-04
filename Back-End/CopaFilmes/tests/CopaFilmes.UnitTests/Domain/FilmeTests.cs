using CopaFilmes.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.UnitTests.Domain
{
    [TestClass]
    public class FilmeTests
    {
        [TestMethod]
        [DataRow("Id1", "Titulo1", 2010, 7)]
        [DataRow("Id2", "Titulo2", 2010, 5)]
        [DataRow("Id3", "Titulo3", 2010, 9)]
        public void FilmeInstanciadoCorretamente(string id, string titulo, int ano, float nota)
        {
            var filme = new Filme(id, titulo, ano, nota);

            Assert.AreEqual(id, filme.Id);
            Assert.AreEqual(titulo, filme.Titulo);
            Assert.AreEqual(ano, filme.Ano);
            Assert.AreEqual(nota, filme.Nota);
        }
    }
}
