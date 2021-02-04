using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Application.DTO
{
    public class CampeonatoDTO
    {
        public FilmeDTO[] Filmes { get; set; }
        public EliminatoriasDTO Eliminatorias { get; set; }
        public FilmeDTO Campeao { get; set; }
        public FilmeDTO ViceCampeao { get; set; }
    }
}
