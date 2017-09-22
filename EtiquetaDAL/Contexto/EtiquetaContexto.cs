using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaDAL.Contexto
{
    public class EtiquetaContexto : DbContext
    {
        public EtiquetaContexto() : base("BancoDadosEtiqueta") { }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<EtiquetaContexto>(null);
        //}

        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<EtiquetaImpressaModel> Etiqueta { get; set; }
        public DbSet<InformacaoNutricionalModel> InformacaoNutricional { get; set; }
    }
}
