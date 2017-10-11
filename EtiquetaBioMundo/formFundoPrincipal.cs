using EtiquetaBLL;
using EtiquetaModel;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            try
            {
                List<ProdutoModel> listPrdod = null;
                ProdutoModel produto = new ProdutoModel();
                produto.Descricao = txtPesquisa.Text.Trim();
                listPrdod = produtoController.BuscarPorDescricao(produto);
                CarregarLista(listPrdod);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Prepara campos da tela para inicialização
        /// </summary>
        private void InicializaCamposTela()
        {

        }
        /// <summary>
        /// Carregar lista de produtos
        /// </summary>
        /// <param name="listProdutos">Lisa de produtos previamente passada por quem deseja popular a ListView</param>
        private void CarregarLista(List<ProdutoModel> listProdutos)
        {
            try
            {
                chkSelecaoItem.Checked = false;
                List<ProdutoModel> produtos = null;
                produtos = listProdutos;
                if (produtos == null) produtos = produtoController.BuscarTodos();
                dgvEtiqueta.Rows.Clear();
                produtos.ForEach(x =>
                {
                    dgvEtiqueta.Rows.Add(false, x.Id, x.Codigo, x.Descricao, x.PrecoVenda.ToString());
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        /// <summary>
        /// Percorrer a lista de produtos selecionados e imprimir etiqueta
        /// </summary>
        private void ImprimirEtiqueta()
        {
            try
            {
                EtiquetaController etiquetaController = new EtiquetaController();
                etiquetaController.RemoverTodos();
                bool imprimir = false;
                foreach (DataGridViewRow linha in dgvEtiqueta.Rows)
                {
                    if ((bool)linha.Cells["colSelecionada"].Value)
                    {
                        ProdutoModel produto = new ProdutoModel();
                        produto.Id = Int32.Parse(linha.Cells["colId"].Value.ToString());
                        produto = produtoController.Buscar(produto);
                        if (ValidaImpressaoEtiqueta(linha))
                        {
                            string QtdEtiqueta = linha.Cells["colQtdEtiqueta"].Value.ToString();
                            string DiasValidadeEtiqueta = linha.Cells["colValidade"].Value.ToString();
                            for (int i = 0; i < Int32.Parse(QtdEtiqueta); i++)
                            {
                                EtiquetaImpressaModel etiqueta = new EtiquetaImpressaModel()
                                {
                                    DataCadastro = DateTime.Now,
                                    DataFabricao = DateTime.Now,
                                    DataValidade = DateTime.Now.AddDays(Int32.Parse(DiasValidadeEtiqueta)),
                                    Produto = produto
                                };
                                etiquetaController.Cadastrar(etiqueta);
                                imprimir = true;
                            }
                        }
                    }


                }
                if (imprimir)
                {
                    formRelatorioEtiqueta formRelatorio = new formRelatorioEtiqueta();
                    formRelatorio.ShowDialog();
                }
                else
                    MessageBox.Show("Nenhum produto foi selecionado para imprimir etiqueta.");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Valida se os prerequisitos impressão de etiqueta estão corretos (Quantidade de impressão >0 e Validade > 0)
        /// </summary>
        /// <param name="linha"></param>
        /// <returns></returns>
        private bool ValidaImpressaoEtiqueta(DataGridViewRow linha)
        {
            bool response = true;
            if (linha.Cells["colQtdEtiqueta"].Value == null)
            {
                linha.Cells["colQtdEtiqueta"].Style.BackColor = Color.Red;
                response = false;
            }
            if (linha.Cells["colValidade"].Value == null)
            {
                linha.Cells["colValidade"].Style.BackColor = Color.Red;
                response = false;
            }
            if (response == false)
                MessageBox.Show("Valores inválidos para o item: " + linha.Cells["colDesc"].Value.ToString()
                    + ". Verifique as colunas pintadas em vermelho.");
            return response;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            formManutencaoProdutos formCad = new formManutencaoProdutos();
            formCad.ShowDialog();
            CarregarLista(null);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            ImprimirEtiqueta();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
                PesquisarProduto();
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.SelectionStart = 0;
            txtPesquisa.SelectionLength = txtPesquisa.Text.Length;
        }

        private void formFundoPrincipal_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(txtPesquisa, "Digite a descrição desejada e pressione a tecla ENTER para pesquisar.");
            toolTip.SetToolTip(btCadastrar, "Clique aqui para abrir a tela de cadastro de produtos e informações nutricionais.");
            toolTip.SetToolTip(btImprimir, "Clique aqui para imprimir a etiqueta do produto selecionado.");
            toolTip.SetToolTip(dgvEtiqueta, "Duplo clique na lateral da linha para editar o item selecionado.");
        }

        private void dgvEtiqueta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEtiqueta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEtiqueta.SelectedRows.Count > 0)
            {
                ProdutoModel produto = new ProdutoModel();
                produto.Id = Int32.Parse(dgvEtiqueta.CurrentRow.Cells["colId"].Value.ToString());
                produto = produtoController.Buscar(produto);
                formManutencaoProdutos formCad = new formManutencaoProdutos(produto);
                formCad.ShowDialog();
                CarregarLista(null);
            }
        }

        private void chkSelecaoItem_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgvEtiqueta.Rows)
            {
                linha.Cells["colSelecionada"].Value = chkSelecaoItem.Checked;
            }
        }
    }
}
