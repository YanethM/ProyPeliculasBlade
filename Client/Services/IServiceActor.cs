using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;

namespace ProyBaseMuestra.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}