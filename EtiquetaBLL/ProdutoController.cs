using EtiquetaDAL;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaBLL
{
    public class ProdutoController : IController<ProdutoModel>
    {
        private ProdutoRepository produtoRep;

        public ProdutoController()
        {
            produtoRep = new ProdutoRepository();
        }

        public ProdutoModel Atualizar(ProdutoModel obj)
        {
            obj.DataAlteracao = DateTime.Now;
            produtoRep.Update(obj);
            produtoRep.Save();
            return obj;
        }

        public List<ProdutoModel> BuscarPorDescricao(ProdutoModel obj)
        {

            string[] valores = obj.Descricao.Trim().Split(' ');
            List<ProdutoModel> response = produtoRep.Get(x => {
                bool resp = true;
                foreach (string s in valores)
                {
                    string target = x.Descricao.ToUpper();
                    if (!StringHelper.Contains(target, s))
                        resp = false; break;
                }
                return resp;
            }).ToList();
            return response;
        }

        public ProdutoModel Buscar(ProdutoModel obj)
        {
            ProdutoModel response = null;
            response = produtoRep.Find(obj.Id);
            return response;
        }

        public List<ProdutoModel> BuscarTodos()
        {
            List<ProdutoModel> response=null;
            response = produtoRep.GetAll().ToList();
            return response;
        }

        public ProdutoModel Cadastrar(ProdutoModel obj)
        {
            obj.DataCadastro = DateTime.Now;
            produtoRep.Add(obj);
            produtoRep.Save();
            return obj;
        }

        public bool Remover(ProdutoModel obj)
        {
            bool response = true;
            produtoRep.Remove(x => x == obj);
            produtoRep.Save();
            return response;
        }
    }
}
