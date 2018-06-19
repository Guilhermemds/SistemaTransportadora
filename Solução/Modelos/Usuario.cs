using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        public int  MatriculaID { get; set; }

        public double distancia { get; set; }

        public double valorCombustivel { get; set; }

        public string Nome { get; set; }

        public string cidadeOrigem { get; set; }

        public string cidadeDestino { get; set; }

        public bool Ativo { get; set; }
    }
}
