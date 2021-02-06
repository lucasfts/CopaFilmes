using AutoMapper;
using CopaFilmes.Application.DTO;
using CopaFilmes.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Application.Mapper
{
    public class PartidaProfile : Profile
    {
        public PartidaProfile()
        {
            CreateMap<Partida, PartidaDTO>();
        }
    }
}
