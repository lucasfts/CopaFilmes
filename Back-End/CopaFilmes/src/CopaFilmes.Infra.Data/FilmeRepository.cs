using CopaFilmes.Domain;
using CopaFilmes.Domain.Contracts;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Infra.Data
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly string _apiUrl;

        public FilmeRepository(IConfiguration configuration)
        {
            _apiUrl = configuration.GetSection("CopaFilmesApi:Url").Value;
        }

        public async Task<IEnumerable<Filme>> ObterFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync($"{_apiUrl}/filmes");
                var filmes = JsonConvert.DeserializeObject<IEnumerable<Filme>>(response);
                return filmes;
            }
        }
    }
}
