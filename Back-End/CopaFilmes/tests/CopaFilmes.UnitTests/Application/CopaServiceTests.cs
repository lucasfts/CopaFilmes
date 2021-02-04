using CopaFilmes.Application;
using CopaFilmes.UnitTests.Application.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
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

        [TestMethod]
        public void GerarCampeonato_ResultadoValido()
        {
            var filmes = _service.ObterFilmesAsync().Result;
            var titulosSelecionados = ObterTitulosSelecionados();
            var filemsSelecionados = filmes.Where(x => titulosSelecionados.Contains(x.Titulo)).ToList();

            var titulosOrdenados = ObterTitulosOrdenados();

            var resultado = _service.GerarCampeonato(filemsSelecionados);
            var titulosResultado = resultado.Filmes.Select(x => x.Titulo).ToArray();

            Assert.AreEqual(SerializarTitulos(titulosOrdenados), SerializarTitulos(titulosResultado));

            Assert.AreEqual("Vingadores: Guerra Infinita", resultado.Eliminatorias.SemiFinal[0].PrimeiroFilme.Titulo);
            Assert.AreEqual("Thor: Ragnarok", resultado.Eliminatorias.SemiFinal[1].PrimeiroFilme.Titulo);
            Assert.AreEqual("Os Incríveis 2", resultado.Eliminatorias.SemiFinal[1].SegundoFilme.Titulo);
            Assert.AreEqual("Jurassic World: Reino Ameaçado", resultado.Eliminatorias.SemiFinal[0].SegundoFilme.Titulo);

            Assert.AreEqual("Vingadores: Guerra Infinita", resultado.Eliminatorias.Final.PrimeiroFilme.Titulo);
            Assert.AreEqual("Os Incríveis 2", resultado.Eliminatorias.Final.SegundoFilme.Titulo);

            Assert.AreEqual("Vingadores: Guerra Infinita", resultado.Campeao.Titulo);
            Assert.AreEqual("Os Incríveis 2", resultado.ViceCampeao.Titulo);
        }

        private string[] ObterTitulosSelecionados()
        {
            return new string[] {
                "Os Incríveis 2",
                "Jurassic World: Reino Ameaçado",
                "Oito Mulheres e um Segredo",
                "Hereditário",
                "Vingadores: Guerra Infinita",
                "Deadpool 2",
                "Han Solo: Uma História Star Wars",
                "Thor: Ragnarok",
            };
        }

        private string[] ObterTitulosOrdenados()
        {
            return new string[] {
                "Deadpool 2",
                 "Han Solo: Uma História Star Wars",
                 "Hereditário",
                 "Jurassic World: Reino Ameaçado",
                 "Oito Mulheres e um Segredo",
                 "Os Incríveis 2",
                 "Thor: Ragnarok",
                 "Vingadores: Guerra Infinita",
            };
        }

        private string SerializarTitulos(string[] titulos)
        {
            return JsonConvert.SerializeObject(titulos);
        }
    }
}
