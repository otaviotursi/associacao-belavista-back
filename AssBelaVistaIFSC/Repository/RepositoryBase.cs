using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssBelaVistaIFSC.Repository
{
    public class RepositoryBase
    {
        private readonly IConfiguration _configuration;
        
        protected readonly string banco = "";

        public RepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
            banco = _configuration.GetConnectionString("Default");
            //banco = _configuration.GetSection("ConnectionString:Default").Value; //caso acima não funcione
        }

    }
}
