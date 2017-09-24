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
        public EtiquetaContexto() : base("BancoDadosEtiqueta") {
            Database.SetInitializer<EtiquetaContexto>(new CreateDatabaseIfNotExists<EtiquetaContexto>());
            Database.Initialize(false);
        }

        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<EtiquetaImpressaModel> Etiqueta { get; set; }
        public DbSet<InformacaoNutricionalModel> InformacaoNutricional { get; set; }
    }
}
