using CopaFilmes.Application;
using CopaFilmes.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CopaController : ControllerBase
    {
        private readonly CopaService _copaService;

        public CopaController(CopaService copaService)
        {
            _copaService = copaService;
        }

        [HttpGet("filmes")]
        public async Task<IEnumerable<FilmeDTO>> GetFilmes()
        {
            var filmes = await _copaService.ObterFilmesAsync();
            return filmes;
        }

        [HttpPost("campeonato/gerar")]
        public CampeonatoDTO GerarCampeonato(IEnumerable<FilmeDTO> filmesSelecionados)
        {
            var campeonato = _copaService.GerarCampeonato(filmesSelecionados);

            return campeonato;
        }
    }
}
