using AssBelaVistaIFSC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Services.Interfaces
{
    public interface IEventosPublicosService
    {
        List<EventoSimples> BuscarTodosEventos();
    }
}
