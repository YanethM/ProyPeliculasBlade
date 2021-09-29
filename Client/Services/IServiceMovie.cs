using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;

namespace ProyBaseMuestra.Client.Services
{
    /* Las interfaces son abstractas, no implementan los métodos */
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
    }
}