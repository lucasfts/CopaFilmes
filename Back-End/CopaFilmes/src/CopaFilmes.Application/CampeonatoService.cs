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
    public class CampeonatoService
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IMapper _mapper;

        public CampeonatoService(IFilmeRepository filmeRepository, IMapper mapper)
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

        public CampeonatoDTO GerarCampeonato(List<FilmeDTO> filmes)
        {
            var filmesSelecionados = filmes.Select(_mapper.Map<Filme>).ToList();

            var eliminatorias = new Eliminatorias(filmesSelecionados);

            var campeonato = new CampeonatoDTO
            {
                Filmes = eliminatorias.Filmes.Select(_mapper.Map<FilmeDTO>).ToArray(),
                Eliminatorias = _mapper.Map<EliminatoriasDTO>(eliminatorias),
                Campeao = _mapper.Map<FilmeDTO>(eliminatorias.Final.ObterVencedor()),
                ViceCampeao = _mapper.Map<FilmeDTO>(eliminatorias.Final.ObterPerdedor())
            };

            return campeonato;
        }
    }
}
