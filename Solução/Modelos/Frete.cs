using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Frete
    {
        public int FreteID { get; set; }

        public string CidadeOrigem { get; set; }

        public string CidadeDestino { get; set; }

        public string TipodeFrete { get; set; }

       // public virtual Motorista _Usuario { get; set; }

    }
}
