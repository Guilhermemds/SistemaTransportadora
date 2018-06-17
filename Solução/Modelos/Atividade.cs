using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Atividade
    {
        public int AtividadeID { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }

    }
}
