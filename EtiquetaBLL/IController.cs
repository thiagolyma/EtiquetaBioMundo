using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaBLL
{
    public interface IController<TEntidade> where TEntidade : class
    {
        TEntidade Cadastrar(TEntidade obj);
        TEntidade Atualizar(TEntidade obj);
        bool Remover(TEntidade obj);
        List<TEntidade> BuscarTodos();
        TEntidade Buscar(TEntidade obj);
    }
}
