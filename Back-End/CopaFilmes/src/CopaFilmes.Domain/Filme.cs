using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain
{
    public class Filme
    {
        public string Id { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public float Nota { get; private set; }

        public Filme(string id, string titulo, int ano, float nota)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Nota = nota;
        }
    }
}
