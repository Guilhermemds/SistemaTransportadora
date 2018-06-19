using Controller.Base;
using Controller.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
            
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Editar(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Usuario usu = BuscarPorID(id);

            if(usu != null)
            {
                contexto.Usuarios.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public List<Usuario> ListarPorNome(string nome)
        {
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList();
        }

        public List<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}
