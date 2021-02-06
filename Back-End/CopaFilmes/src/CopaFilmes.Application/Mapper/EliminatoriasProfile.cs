using AutoMapper;
using CopaFilmes.Application.DTO;
using CopaFilmes.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Application.Mapper
{
    public class EliminatoriasProfile : Profile
    {
        public EliminatoriasProfile()
        {
            CreateMap<Eliminatorias, EliminatoriasDTO>();

            CreateMap<Eliminatorias, CampeonatoDTO>()
               .ForMember(x => x.Filmes, m => m.MapFrom(eliminatorias => eliminatorias.Filmes))
               .ForMember(x => x.Eliminatorias, m => m.MapFrom(eliminatorias => eliminatorias))
               .ForMember(x => x.Campeao, m => m.MapFrom(eliminatorias => eliminatorias.Final.ObterVencedor()))
               .ForMember(x => x.ViceCampeao, m => m.MapFrom(eliminatorias => eliminatorias.Final.ObterPerdedor()));
        }
    }
}
