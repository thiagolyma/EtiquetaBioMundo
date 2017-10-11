using System.Collections.Generic;

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
