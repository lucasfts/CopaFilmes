using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain
{
    public class Filme
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public int Nota { get; private set; }

        public Filme(int id, string titulo, int ano, int nota)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Nota = nota;
        }
    }
}
