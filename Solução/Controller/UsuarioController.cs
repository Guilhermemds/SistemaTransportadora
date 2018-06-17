using Controller.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController<Usuario> : IBaseController<Usuario>
    {
        public void Adicionar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
