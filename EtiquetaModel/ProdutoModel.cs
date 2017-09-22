using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaModel
{
    [Table("TB_Produto")]
    public class ProdutoModel : AbstractModel
    {
        [StringLength(20)]
        public string Codigo { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public virtual ICollection<InformacaoNutricionalModel> InformacoesNutricionais { get; set; }
        public decimal PrecoVenda { get; set; }
        [StringLength(500)]
        public string Ingrediente { get; set; }

    }
}
