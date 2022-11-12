using AssBelaVistaIFSC.Model;
using AssBelaVistaIFSC.Repository.Interfaces;
using AssBelaVistaIFSC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Services
{
    public class EventosPublicosService : IEventosPublicosService
    {
        private readonly IEventosPublicosRepository eventosPublicRep;
        public EventosPublicosService(IEventosPublicosRepository eventosPublicRep)
        {
            this.eventosPublicRep = eventosPublicRep;
        }

        public List<EventoSimples> BuscarTodosEventos()
        {
            return this.eventosPublicRep.BuscarTodosEventos();
        }

    }
}
