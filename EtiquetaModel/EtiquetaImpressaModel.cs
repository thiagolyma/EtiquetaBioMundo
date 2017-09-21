using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaModel
{
    [Table("TB_Etiqueta")]
    public class EtiquetaImpressaModel : AbstractModel
    {
        public DateTime? DataFabricao { get; set; }
        public DateTime? DataValidade { get; set; }
        public decimal QuantidadePorcao { get; set; }
        [StringLength(10)]
        public string UnidadeMedida { get; set; }
        public virtual ProdutoModel Produto { get; set; }
    }
}
