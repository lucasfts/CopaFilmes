using CopaFilmes.Application;
using CopaFilmes.UnitTests.Application.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CopaFilmes.UnitTests.Application
{
    [TestClass]
    public class CopaServiceTests
    {
        private CopaService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new CopaService(new MockFilmeRepository(), MockMapperFactory.Create());
        }

        [TestMethod]
        public void ObterFilmesAsync_Sucesso()
        {
            var filmes = _service.ObterFilmesAsync().Result;

            Assert.IsTrue(filmes.Count() > 0);
        }
    }
}
