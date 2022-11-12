using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Model
{
    public class EventoSimples
    {
        public long pk_id { get; set; }
        public long fk_id_tipo_de_evento { get; set; }
        public string dias_semana { get; set; }
        public long fk_id_periodicidade { get; set; }
        public long fk_id_status_evento { get; set; }
        
        
        
        
        
    }
}
