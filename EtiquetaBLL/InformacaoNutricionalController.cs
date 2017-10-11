using EtiquetaDAL.Repositorio;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EtiquetaBLL
{
    public class InformacaoNutricionalController : IController<InformacaoNutricionalModel>
    {
        private InformacaoNutricionalRepository infRep;

        public InformacaoNutricionalController()
        {
            infRep = new InformacaoNutricionalRepository();
        }

        public InformacaoNutricionalModel Atualizar(InformacaoNutricionalModel obj)
        {
            obj.DataAlteracao = DateTime.Now;
            infRep.Update(obj);
            infRep.Save();
            return obj;
        }

        public InformacaoNutricionalModel Buscar(InformacaoNutricionalModel obj)
        {
            InformacaoNutricionalModel response = null;
            response = infRep.Find(obj.Id);
            return response;
        }

        public List<InformacaoNutricionalModel> BuscarPorProduto(ProdutoModel produto)
        {

            List<InformacaoNutricionalModel> response = null;
            if (produto != null)
                response = infRep.Get(x => x.Produto.Id == produto.Id).ToList();
            return response;
        }

        public List<InformacaoNutricionalModel> BuscarTodos()
        {
            List<InformacaoNutricionalModel> response = null;
            response = infRep.GetAll().ToList();
            return response;
        }

        public InformacaoNutricionalModel Cadastrar(InformacaoNutricionalModel obj)
        {
            obj.DataCadastro = DateTime.Now;
            infRep.Add(obj);
            infRep.Save();
            return obj;
        }

        public bool Remover(InformacaoNutricionalModel obj)
        {
            bool response = true;
            infRep.Remove(x => x == obj);
            infRep.Save();
            return response;
        }
    }
}

