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
    public class FreteController : IBaseController<FreteModelo>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(FreteModelo entity)
        {
            entity.Ativo = true;            
            contexto.Frete.Add(entity);
            contexto.SaveChanges();
        }

        public FreteModelo BuscarPorHabilitacao(string id)
        {
            throw new NotImplementedException();
        }

        public FreteModelo BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(FreteModelo entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<FreteModelo> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<FreteModelo> ListarTodos()
        {
            return contexto.Frete.ToList();
        }
    }
}
