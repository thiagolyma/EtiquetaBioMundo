using EtiquetaDAL.Repositorio;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaBLL
{
    public class EtiquetaController : IController<EtiquetaImpressaModel>
    {
        private EtiquetaRepository etiquetaRep;

        public EtiquetaController()
        {
            etiquetaRep = new EtiquetaRepository();
        }

        public EtiquetaImpressaModel Atualizar(EtiquetaImpressaModel obj)
        {
            obj.DataAlteracao = DateTime.Now;
            etiquetaRep.Update(obj);
            etiquetaRep.Save();
            return obj;
        }

        public EtiquetaImpressaModel Buscar(EtiquetaImpressaModel obj)
        {
            EtiquetaImpressaModel response = null;
            response = etiquetaRep.Find(obj.Id);
            return response;
        }

        public List<EtiquetaImpressaModel> BuscarTodos()
        {
            List<EtiquetaImpressaModel> response = null;
            response = etiquetaRep.GetAll().ToList();
            return response;
        }

        public EtiquetaImpressaModel Cadastrar(EtiquetaImpressaModel obj)
        {
            obj.DataCadastro = DateTime.Now;
            etiquetaRep.Add(obj);
            etiquetaRep.Save();
            return obj;
        }

        public bool Remover(EtiquetaImpressaModel obj)
        {
            bool response = true;
            etiquetaRep.Remove(x => x == obj);
            etiquetaRep.Save();
            return response;
        }

        public void RemoverTodos()
        {
            etiquetaRep.Remove(x=>x.Id > 0);
            etiquetaRep.Save();
        }
    }
}
