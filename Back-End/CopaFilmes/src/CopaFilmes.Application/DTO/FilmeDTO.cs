using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Application.DTO
{
    public class FilmeDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Nota { get; set; }
    }
}
