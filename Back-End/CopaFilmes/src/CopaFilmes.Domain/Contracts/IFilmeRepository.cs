using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Contracts
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> ObterFilmesAsync();
    }
}
