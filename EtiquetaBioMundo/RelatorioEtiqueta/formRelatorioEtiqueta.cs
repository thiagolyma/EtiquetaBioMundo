using EtiquetaBioMundo.RelatorioEtiqueta;
using EtiquetaBLL;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaBioMundo
{
    public partial class formRelatorioEtiqueta : Form
    {
        private static EtiquetaController etiquetaController = null;
        public formRelatorioEtiqueta()
        {
            InitializeComponent();
        }

        public formRelatorioEtiqueta(EtiquetaController controller)
        {
            etiquetaController = controller;
        }

        private void formRelatorioEtiqueta_Load(object sender, EventArgs e)
        {
            PopularDadosRelatorioEtiqueta();
        }

        private void formRelatorioEtiqueta_Resize(object sender, EventArgs e)
        {
            reportViewer1.Width = this.Width;
            reportViewer1.Height = this.Height;
        }

        private void PopularDadosRelatorioEtiqueta()
        {
            if(etiquetaController==null)
                etiquetaController = new EtiquetaController();

            List<EtiquetaImpressaModel> etiquetas = etiquetaController.BuscarTodos();
            //LINQ query
            var dadosEtiqueta = (from item in etiquetas
                                 select new DadosEtiqueta
                                 {
                                     Id = item.Id,
                                     CodigoProduto = item.Produto.Codigo,
                                     DescricaoProduto = item.Produto.Descricao,
                                     PrecoVenda = item.Produto.PrecoVenda,
                                     Ingrediente = item.Produto.Ingrediente,
                                     DataValidade = (DateTime) item.DataValidade,
                                     DataFabricacao = (DateTime) item.DataFabricao,
                                     Quantidade = item.Produto.QuantidadePorcao,
                                     UnidadeMedida = item.Produto.UnidadeMedida
                                     //InformacoesNutricionais = (List<InformacaoNutricionalModel>) item.Produto.InformacoesNutricionais
                                 }).ToArray();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosRelatorioEtiqueta", dadosEtiqueta));
            this.reportViewer1.RefreshReport();
        }
    }
}
