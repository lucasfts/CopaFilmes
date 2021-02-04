using CopaFilmes.Domain;
using CopaFilmes.Domain.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.UnitTests.Application.Mock
{
    public class MockFilmeRepository : IFilmeRepository
    {
        private List<Filme> filmes;

        public MockFilmeRepository()
        {
            var jsonFilmes = File.ReadAllText("Application/Mock/filmes.json");
            filmes = JsonConvert.DeserializeObject<List<Filme>>(jsonFilmes);
        }

        public Task<IEnumerable<Filme>> ObterFilmesAsync()
        {
            return Task.FromResult(filmes.AsEnumerable());
        }
    }
}