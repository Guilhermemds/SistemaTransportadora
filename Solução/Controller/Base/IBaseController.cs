using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Base
{
    interface IBaseController<Usuario> : class
    {
        void Adicionar(T entity);

        List<T> ListarTodos();

        List<T> ListarPorNome(String nome);

        T BuscarPorID(int id);

        void Editar(T entity);

        void Excluir(int id);


}
}
