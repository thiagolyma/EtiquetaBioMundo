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
        [MaxLength(20)]
        public string Codigo { get; set; }
        [MaxLength(200)]
        [Required]
        public string Descricao { get; set; }
        public virtual ICollection<InformacaoNutricionalModel> InformacoesNutricionais { get; set; }
        public decimal PrecoVenda { get; set; }
        [MaxLength(500)]
        public string Ingrediente { get; set; }
        [MaxLength(10)]
        public string UnidadeMedida { get; set; }
        public decimal QuantidadePorcao { get; set; }
        public int QuantidadeDiasValidade { get; set; }
    }
}
