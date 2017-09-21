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
        [StringLength(50)]
        public string Descricao { get; set; }
        [StringLength(10)]
        public string UnidadeMedia { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorDiario { get; set; }
    }
}
