using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Model
{
    public class ApiResponse
    {
        public int status { get; set; }
        public object objeto { get; set; }
        public string mensagem { get; set; }
    }
}
