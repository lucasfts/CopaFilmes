using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Application.DTO
{
    public class EliminatoriasDTO
    {
        public PartidaDTO[] PrimeiraFase { get; set; }
        public PartidaDTO[] SemiFinal { get; set; }
        public PartidaDTO Final { get; set; }
    }
}
