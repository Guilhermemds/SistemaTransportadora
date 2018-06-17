using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
