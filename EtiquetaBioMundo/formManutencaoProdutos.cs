using EtiquetaBLL;
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
using Microsoft.VisualBasic;

namespace EtiquetaBioMundo
{
    public partial class formManutencaoProdutos : Form
    {
        private ProdutoController produtoController = new ProdutoController();
        private InformacaoNutricionalController infContoller = new InformacaoNutricionalController();
        private ProdutoModel produtoModel = null;

        public formManutencaoProdutos()
        {
            InitializeComponent();
            PreencherCamposTela(null);
        }
        /// <summary>
        /// Sobrecarga do método construtor da classe. Utilizado para edição de produto
        /// </summary>
        /// <param name="produto"></param>
        public formManutencaoProdutos(ProdutoModel produto)
        {
            InitializeComponent();
            PreencherCamposTela(produto);
            CarregaListaInformacoesNutricionais();
        }
        /// <summary>
        /// Carrega ListView lateral com as informações nutricionais vinculadas ao produto
        /// </summary>
        private void CarregaListaInformacoesNutricionais()
        {
            try
            {
                dgvInformacoesNutricionais.Rows.Clear();
                List<InformacaoNutricionalModel> infNutricionais = null;
                infNutricionais = infContoller.BuscarPorProduto(produtoModel);
                if (infNutricionais != null && infNutricionais.Count > 0)
                {
                    infNutricionais.ForEach(x =>
                    {
                        dgvInformacoesNutricionais.Rows.Add(x.Id.ToString(), x.Descricao.Trim(), x.UnidadeMedia.Trim(), x.Quantidade.ToString(), x.ValorDiario.ToString());
                    });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        /// <summary>
        /// Preenche todos os campos da tela para edição de produto
        /// </summary>
        /// <param name="produto"></param>
        private void PreencherCamposTela(ProdutoModel produto)
        {
            try
            {
                if (produto != null)
                {
                    produtoModel = produto;
                    txtCodigo.Text = produto.Codigo;
                    txtDescricao.Text = produto.Descricao;
                    txtIngredientes.Text = produto.Ingrediente;
                    txtPrecoVenda.Text = produto.PrecoVenda.ToString();
                    txtUnidadeEmbalagem.Text = produto.UnidadeMedida;
                    txtQtdPorcao.Text = produto.QuantidadePorcao.ToString();
                    txtDiasValidade.Text = produto.QuantidadeDiasValidade.ToString();
                    AtualizarAmbienteCadastro(true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Captura dados do formulário de cadastro e carrega em um objeto ProdutoModel
        /// </summary>
        /// <returns></returns>
        private void MontarObjetoProduto()
        {
            try
            {
                if (produtoModel == null)
                    produtoModel = new ProdutoModel();

                produtoModel.Codigo = txtCodigo.Text.Trim();
                produtoModel.Descricao = txtDescricao.Text.Trim();
                produtoModel.PrecoVenda = Decimal.Parse(txtPrecoVenda.Text.Trim());
                produtoModel.Ingrediente = txtIngredientes.Text.Trim();
                produtoModel.UnidadeMedida = txtUnidadeEmbalagem.Text.Trim();
                produtoModel.QuantidadeDiasValidade = Int32.Parse(txtDiasValidade.Text.Trim());
                produtoModel.QuantidadePorcao = decimal.Parse(txtQtdPorcao.Text.Trim());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Valida todos os dados da tela antes de realizar gravação ou alteração no produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        private bool ValidaGravacao(ProdutoModel produto)
        {
            bool response = false;
            try
            {
                if (produto.Descricao.Trim().Length > 0
                    && produto.Codigo.Trim().Length > 0
                    && produto.Ingrediente.Trim().Length > 0
                    && produto.PrecoVenda > 0)
                {
                    response = true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return response;
        }
        /// <summary>
        /// Muda aparência e acessibilidade de campos da tela de acordo com o botão de ação ou contexto de cadastro
        /// </summary>
        /// <param name="statusHabilitado"></param>
        private void AtualizarAmbienteCadastro(bool statusHabilitado)
        {
            try
            {
                btDuplicar.Enabled = statusHabilitado;
                btExcluir.Enabled = statusHabilitado;
                btGravar.Enabled = statusHabilitado;
                grpProduto.Enabled = statusHabilitado;
                btDuplicar.Enabled = statusHabilitado;
                btImprimirEtiqueta.Enabled = statusHabilitado;
                dgvInformacoesNutricionais.Enabled = statusHabilitado;
                btGravar.Text = produtoModel != null && produtoModel.Id > 0 ? "Alterar" : "Cadastrar";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        ///  Prepara campos da tela para inicialização
        /// </summary>
        private void InicializaCamposForm()
        {
            try
            {
                grpProduto.Enabled = true;
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtPrecoVenda.Text = "0,00";
                txtIngredientes.Text = "";
                txtDiasValidade.Text = "01";
                txtQtdPorcao.Text = "0,00";
                txtUnidadeEmbalagem.Text = "g";
                txtCodigo.Focus();
                dgvInformacoesNutricionais.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Popula a tabela de etiquetas com o produtoModel atual e aciona o formulário de impressão
        /// </summary>
        private void GerarEtiquetaImpressao()
        {
            try
            {
                if (produtoModel != null && produtoModel.Id > 0)
                {
                    String QtdSolicitada = Interaction.InputBox("Informe a quantidade de etiquetas que deseja imprimir:", "Quantidade Númerica", "1", -1, -1);
                    QtdSolicitada = QtdSolicitada.Trim().Length == 0 ? "1" : QtdSolicitada;

                    EtiquetaController etiquetaController = new EtiquetaController();
                    etiquetaController.RemoverTodos();
                    for (int i = 0; i < Int32.Parse(QtdSolicitada); i++)
                    {
                        EtiquetaImpressaModel etiqueta = new EtiquetaImpressaModel()
                        {
                            DataCadastro = DateTime.Now,
                            DataFabricao = DateTime.Now,
                            DataValidade = DateTime.Now.AddDays(Int32.Parse(txtDiasValidade.Text.Trim())),
                            Produto = produtoModel
                        };
                        etiquetaController.Cadastrar(etiqueta);
                    }
                    formRelatorioEtiqueta frmEtiqueta = new formRelatorioEtiqueta();
                    frmEtiqueta.ShowDialog();
                }
                else
                    MessageBox.Show("Produto inválido!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        /// <summary>
        /// Percorre a lista de informações nutricionais cadastrando-as
        /// </summary>
        private void GravarInformacoesNutricionais()
        {
            try
            {
                if (produtoModel != null && produtoModel.Id > 0)
                {
                    foreach (DataGridViewRow linha in dgvInformacoesNutricionais.Rows)
                    {
                        if (linha.Cells["colDescricao"].Value != null)
                        {
                            InformacaoNutricionalModel informacaoNutricionalModel = new InformacaoNutricionalModel();
                            if (linha.Cells["colID"].Value != null)
                            {
                                informacaoNutricionalModel.Id = Int32.Parse(linha.Cells["colID"].Value.ToString().Trim());
                                informacaoNutricionalModel = infContoller.Buscar(informacaoNutricionalModel);
                            }
                            informacaoNutricionalModel.DataCadastro = DateTime.Now;
                            informacaoNutricionalModel.Descricao = linha.Cells["colDescricao"].Value.ToString().Trim();
                            informacaoNutricionalModel.UnidadeMedia = linha.Cells["colUndEmb"].Value.ToString().Trim();
                            informacaoNutricionalModel.Quantidade = Decimal.Parse(linha.Cells["colQtd"].Value.ToString().Trim());
                            informacaoNutricionalModel.ValorDiario = Decimal.Parse(linha.Cells["colVD"].Value.ToString().Trim());
                            informacaoNutricionalModel.Produto = produtoModel;
                            if (informacaoNutricionalModel.Id > 0)
                                infContoller.Atualizar(informacaoNutricionalModel);
                            else
                                infContoller.Cadastrar(informacaoNutricionalModel);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Remover a informação nutricional selecionada
        /// </summary>
        private void RemoverInformacaoNutricional()
        {
            try
            {
                if (dgvInformacoesNutricionais.CurrentRow.Cells["colID"].Value != null)
                {
                    DialogResult result = MessageBox.Show("Deseja excluir a informação nutricional selecionada?", "Excluir", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        InformacaoNutricionalModel informacaoNutricional = new InformacaoNutricionalModel();
                        informacaoNutricional.Id = Int32.Parse(dgvInformacoesNutricionais.CurrentRow.Cells["colID"].Value.ToString().Trim());
                        informacaoNutricional = infContoller.Buscar(informacaoNutricional);
                        infContoller.Remover(informacaoNutricional);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {

            MontarObjetoProduto();
            if (ValidaGravacao(produtoModel))
            {
                if (produtoModel != null && produtoModel.Id > 0)
                {
                    produtoController.Atualizar(produtoModel);
                    GravarInformacoesNutricionais();
                    CarregaListaInformacoesNutricionais();
                    MessageBox.Show("Produto [" + produtoModel.Descricao + "] atualizado com sucesso.");
                }
                else
                {
                    produtoController.Cadastrar(produtoModel);
                    GravarInformacoesNutricionais();
                    CarregaListaInformacoesNutricionais();
                    MessageBox.Show("Produto [" + produtoModel.Descricao + "] cadastrado com sucesso.");
                }
                AtualizarAmbienteCadastro(produtoModel != null && produtoModel.Id > 0 ? true : false);
            }
            else
                MessageBox.Show("Os campos obrigatórios não foram preenchidos corretamente.", "Erro na validação!");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            produtoModel = null;
            InicializaCamposForm();
            AtualizarAmbienteCadastro(true);
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            FormatHelper.FormataMoeda(ref txt);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (produtoModel != null && produtoModel.Id > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir o produto?", "Excluir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    produtoController.Remover(produtoModel);
                    InicializaCamposForm();
                    AtualizarAmbienteCadastro(false);
                }
            }
        }

        private void btDuplicar_Click(object sender, EventArgs e)
        {
            if (produtoModel != null && produtoModel.Id > 0)
            {
                DialogResult result = MessageBox.Show("Deseja duplicar o produto?", "Duplicar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    produtoModel = null;
                    foreach (DataGridViewRow linha in dgvInformacoesNutricionais.Rows)
                    {
                        linha.Cells["colID"].Value = null;
                    }
                    AtualizarAmbienteCadastro(true);
                    MontarObjetoProduto();
                }
            }
        }

        private void btImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            GerarEtiquetaImpressao();
        }

        private void qtdPorcao_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            FormatHelper.FormataMoeda(ref txt);
        }

        private void formManutencaoProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Escape)
                this.Dispose();
        }

        private void dgvInformacoesNutricionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoverInformacaoNutricional();
                CarregaListaInformacoesNutricionais();
            }
        }
    }
}
