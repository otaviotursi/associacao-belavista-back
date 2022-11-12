using AssBelaVistaIFSC.Model;
using AssBelaVistaIFSC.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosPublicosController : ControllerBase
    {
        private readonly IEventosPublicosService eventosPublicosService;
        public EventosPublicosController(IEventosPublicosService eventosPublicosService)
        {
            this.eventosPublicosService = eventosPublicosService;
        }

        [HttpGet("BuscarTodosEventos")]
        public List<EventoSimples> BuscarTodosEventos()
        {
            return this.eventosPublicosService.BuscarTodosEventos();
        }
    }

}
