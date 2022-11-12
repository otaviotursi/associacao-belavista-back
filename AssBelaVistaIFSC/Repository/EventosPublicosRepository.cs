using AssBelaVistaIFSC.Model;
using AssBelaVistaIFSC.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace AssBelaVistaIFSC.Repository
{
    public class EventosPublicosRepository : RepositoryBase, IEventosPublicosRepository
    {
        public EventosPublicosRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public List<EventoSimples> BuscarTodosEventos()
        {
            var query = @"SELECT 
                                pk_id, 
                                fk_id_tipo_de_evento, 
                                dias_semana, 
                                fk_id_periodicidade,
                                fk_id_status_evento 
                         FROM EventoPublico";

            using (var connection = new MySqlConnection(banco))
            {
                try
                {
                    var retorno = connection.Query<EventoSimples>(query).AsList();
                    return retorno;
                }
                catch (Exception ex)
                {
                    string msgErro = $"Erro ao BuscarTodosEventos: {ex}";
                    //_logger.LogError(msgErro);
                    throw new Exception(msgErro);
                }

            }
        }
    }
}
