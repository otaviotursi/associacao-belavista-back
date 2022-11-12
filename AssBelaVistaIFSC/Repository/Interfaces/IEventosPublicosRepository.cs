using AssBelaVistaIFSC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Repository.Interfaces
{
    public interface IEventosPublicosRepository
    {
        List<EventoSimples> BuscarTodosEventos();
    }
}
