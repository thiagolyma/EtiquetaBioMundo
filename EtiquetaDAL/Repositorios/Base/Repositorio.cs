using EtiquetaDAL.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.DAL.Repositorios.Base
{
    /// <summary>
    /// Repositório abstrato para operações de CRUD
    /// </summary>
    /// <typeparam name="TEntity">Objeto</typeparam>
    public abstract class Repositorio<TEntity> : IDisposable, IRepositorio<TEntity> where TEntity : class
    {
        //Instancia do contexto do banco de dados
        private readonly EtiquetaContexto ctx;

        public Repositorio() {
            ctx = ContextoProvider.Get().GetContexto();
        }

        /// <summary>
        /// Adiciona um objeto na base de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Add(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        /// <summary>
        /// Busca um registro na base de dados a partir da chave 
        /// </summary>
        /// <param name="key">Chave do registro</param>
        /// <returns>um registro</returns>
        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        /// <summary>
        /// Retorna um ou mais objetos que atendam o requisito passado por parametro
        /// </summary>
        /// <param name="predicate">Requisito da pesquisa</param>
        /// <returns>retona um ou mais registros</returns>
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return ctx.Set<TEntity>().Where(predicate).AsQueryable();
        }

        /// <summary>
        /// Lista todos os registros da base de dados
        /// </summary>
        /// <returns>Lista de resgistros</returns>
        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }

        /// <summary>
        /// Remove um ou mais registros que atendam o requisito passado por parametro
        /// </summary>
        /// <param name="predicate">Requisito para a exclusão de registros</param>
        public void Remove(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>().Where(predicate).ToList().ForEach(x => ctx.Set<TEntity>().Remove(x));
        }

        /// <summary>
        /// Comita as alteraçõe ou exclusões feitas na base de dados
        /// </summary>
        public void Save()
        {
            ctx.SaveChanges();
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="obj">Objeto</param>
        public void Update(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        /// <summary>
        /// Liberação de recursos
        /// </summary>
        public void Dispose()
        {
            ctx.Dispose();
        }

    }
}
