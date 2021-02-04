using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Contracts
{
    public interface IFilmeRepository
    {
        IEnumerable<Filme> ObterFilmesParticipantes();
    }
}
