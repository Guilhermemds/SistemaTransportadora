using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Base
{
    interface IBaseController<Usuario> 
    {
        void Adicionar(Usuario entity);

        List<Usuario> ListarTodos();

        List<Usuario> ListarPorNome(String nome);

        Usuario BuscarPorID(int id);

        Usuario BuscarPorHabilitacao(string id);

        void Editar(Usuario entity);

        void Excluir(int id);


}
}
