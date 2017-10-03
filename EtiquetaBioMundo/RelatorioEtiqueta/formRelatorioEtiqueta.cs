﻿using EtiquetaBioMundo.RelatorioEtiqueta;
using EtiquetaBLL;
using EtiquetaModel;
using Microsoft.Reporting.WinForms;
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
        private object dadosInfNutricional;
        private static int indexSub;
        public formRelatorioEtiqueta()
        {
            InitializeComponent();
            if (etiquetaController == null) etiquetaController = new EtiquetaController();
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
            indexSub = 0;
            List<EtiquetaImpressaModel> etiquetas = etiquetaController.BuscarTodos();
            //LINQ query
            var dadosEtiqueta = (from item in etiquetas
                                 select new DadosEtiqueta
                                 {
                                     Id = item.Id,
                                     CodigoProduto = "*" + item.Produto.Codigo + "*",
                                     ProdutoId = item.Produto.Id,
                                     DescricaoProduto = item.Produto.Descricao,
                                     PrecoVenda = item.Produto.PrecoVenda,
                                     Ingrediente = item.Produto.Ingrediente,
                                     DataValidade = (DateTime)item.DataValidade,
                                     DataFabricacao = (DateTime)item.DataFabricao,
                                     Quantidade = item.Produto.QuantidadePorcao,
                                     UnidadeMedida = item.Produto.UnidadeMedida
                                 }).ToArray();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosRelatorioEtiqueta", dadosEtiqueta));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            this.reportViewer1.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            var mainSource = ((LocalReport)sender).DataSources["DadosRelatorioEtiqueta"];
            ProdutoModel produto = new ProdutoModel();
            produto.Id = ((EtiquetaBioMundo.RelatorioEtiqueta.DadosEtiqueta[])mainSource.Value)[indexSub].ProdutoId;
            e.DataSources.Clear();
            List<InformacaoNutricionalModel> infNutricionais = etiquetaController.BuscarTodasInformacoesNutricionais(produto);
            dadosInfNutricional = (from inf in infNutricionais
                                   select new DadosInfNutricional
                                   {
                                       Descricao = inf.Descricao,
                                       Qtd = inf.Quantidade,
                                       Und = inf.UnidadeMedia,
                                       VD = inf.ValorDiario
                                   }).ToArray();

            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosInfNutricional", dadosInfNutricional));
            indexSub += 1;
        }
    }
}
