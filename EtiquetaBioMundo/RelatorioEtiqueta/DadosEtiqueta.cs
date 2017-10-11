using System;

namespace EtiquetaBioMundo.RelatorioEtiqueta
{
    public class DadosEtiqueta
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal PrecoVenda { get; set; }
        public string Ingrediente { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
