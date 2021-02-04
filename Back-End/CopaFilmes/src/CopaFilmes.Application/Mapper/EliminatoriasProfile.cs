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
            CreateMap<Eliminatorias, EliminatoriasDTO>().ReverseMap();
        }
    }
}
