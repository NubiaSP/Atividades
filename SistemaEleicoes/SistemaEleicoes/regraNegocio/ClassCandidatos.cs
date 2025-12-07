using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEleicoes.regraNegocio
{
    internal class ClassCandidatos
    {
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string NumeroCandidato { get; set; }
        public string Partido { get; set; }
    }
}
