﻿using EtiquetaBLL;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaBioMundo
{
    public partial class formFundoPrincipal : Form
    {
        ProdutoController produtoController = new ProdutoController();

        public formFundoPrincipal()
        {
            InitializeComponent();
            CarregarLista(null);
            InicializaCamposTela();
        }
        /// <summary>
        /// Pesquisa produto por descrição
        /// </summary>
        private void PesquisarProduto()
        {
            List<ProdutoModel> listPrdod = null;
            ProdutoModel produto = new ProdutoModel();
            produto.Descricao = txtPesquisa.Text.Trim();
            listPrdod = produtoController.BuscarPorDescricao(produto);
            CarregarLista(listPrdod);
        }
        /// <summary>
        /// Prepara campos da tela para inicialização
        /// </summary>
        private void InicializaCamposTela()
        {
            lstProdutos.Columns[1].Width = 100;
            lstProdutos.Columns[2].Width = 400;
        }
        /// <summary>
        /// Carregar lista de produtos
        /// </summary>
        /// <param name="listProdutos">Lisa de produtos previamente passada por quem deseja popular a ListView</param>
        private void CarregarLista(List<ProdutoModel> listProdutos)
        {
            ListViewItem lstItem = null;
            List<ProdutoModel> produtos = null;
            lstProdutos.Items.Clear();
            if (listProdutos != null && listProdutos.Count > 0)
               produtos = listProdutos;
            else
                produtos = produtoController.BuscarTodos();

            produtos.ForEach(x =>
            {
                lstItem = new ListViewItem(x.Id.ToString());
                lstItem.SubItems.Add(x.Codigo.Trim());
                lstItem.SubItems.Add(x.Descricao.Trim());
                lstItem.SubItems.Add(x.PrecoVenda.ToString().Trim());
                lstProdutos.Items.Add(lstItem);
            });
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            formManutencaoProdutos formCad = new formManutencaoProdutos();
            formCad.ShowDialog();
            CarregarLista(null);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            formRelatorioEtiqueta formRelatorio = new formRelatorioEtiqueta();
            formRelatorio.ShowDialog();
        }

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItems.Count > 0)
            {
                ProdutoModel produto = new ProdutoModel();
                produto.Id = Int32.Parse(lstProdutos.SelectedItems[0].SubItems[0].Text);
                produto = produtoController.Buscar(produto);
                formManutencaoProdutos formCad = new formManutencaoProdutos(produto);
                formCad.ShowDialog();
                CarregarLista(null);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32) Keys.Enter)
                PesquisarProduto();
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.SelectionStart = 0;
            txtPesquisa.SelectionLength = txtPesquisa.Text.Length ;
        }

        private void formFundoPrincipal_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay= 5000;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(txtPesquisa,"Digite a descrição desejada e pressione a tecla ENTER para pesquisar.");
            toolTip.SetToolTip(btCadastrar, "Clique aqui para abrir a tela de cadastro de produtos e informações nutricionais.");
        }
    }
}
