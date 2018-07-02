using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Frete
    {
        [Key]
        public int FreteID { get; set; }

        public string DistanciaPercorrida { get; set; }

        public string data { get; set; }

        public string Carteira { get; set; }

        public bool Ativo { get; set; }

        

    }
}
