using AutoMapper;
using CopaFilmes.Application.DTO;
using CopaFilmes.Domain;
using CopaFilmes.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Application
{
    public class CopaService
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IMapper _mapper;

        public CopaService(IFilmeRepository filmeRepository, IMapper mapper)
        {
            _filmeRepository = filmeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FilmeDTO>> ObterFilmesAsync()
        {
            var filmes = await _filmeRepository.ObterFilmesAsync();

            var filmesDto = filmes.Select(_mapper.Map<FilmeDTO>)
                 .ToList();

            return filmesDto;
        }

        public CampeonatoDTO GerarCampeonato(IEnumerable<FilmeDTO> filmes)
        {
            var filmesSelecionados = filmes.Select(x => new Filme(x.Id, x.Titulo, x.Ano,x.Nota)).ToList();

            var eliminatorias = new Eliminatorias(filmesSelecionados);

            eliminatorias.OrdenarFilmes()
                .PreencherPrimeiraFase()
                .PreencherSemiFinal()
                .PreencherFinal();

            var campeonato = _mapper.Map<CampeonatoDTO>(eliminatorias);

            return campeonato;
        }
    }
}
