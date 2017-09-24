using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaModel
{
    [Table("TB_InformacaoNutricional")]
    public class InformacaoNutricionalModel : AbstractModel
    {
        [MaxLength(50)]
        [Required]
        public string Descricao { get; set; }
        [MaxLength(10)]
        public string UnidadeMedia { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorDiario { get; set; }
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public virtual ProdutoModel Produto { get; set; }
    }
}
