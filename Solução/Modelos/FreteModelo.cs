using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class FreteModelo
    {
        [Key]
        public int FreteID { get; set; }

        public double DistanciaPercorrida { get; set; }

        public string data { get; set; }

        public string Carteira { get; set; }

        public double totalFrete { get; set; }

        public bool Ativo { get; set; }

        

    }
}
