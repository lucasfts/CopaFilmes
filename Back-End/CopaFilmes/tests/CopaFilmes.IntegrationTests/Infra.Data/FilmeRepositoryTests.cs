using CopaFilmes.Infra.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.IntegrationTests.Infra.Data
{
    [TestClass]
    public class FilmeRepositoryTests
    {
        private FilmeRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            _repository = new FilmeRepository(ConfigurationFactory.Create());
        }

        [TestMethod]
        public void ObterFilmesAsync_Sucesso()
        {
            var filmes = _repository.ObterFilmesAsync().Result;

            Assert.IsTrue(filmes.Count() > 0);
        }
    }
}
