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
            lstInformacoesNutricionais.Items.Clear();
            List<InformacaoNutricionalModel> infNutricionais = null;
            infNutricionais = infContoller.BuscarPorProduto(produtoModel);
            if (infNutricionais != null && infNutricionais.Count > 0)
            {
                infNutricionais.ForEach(x =>
                {
                    ListViewItem lstItem = new ListViewItem(x.Id.ToString());
                    lstItem.SubItems.Add(x.Descricao.Trim());
                    lstItem.SubItems.Add(x.UnidadeMedia.Trim());
                    lstItem.SubItems.Add(x.Quantidade.ToString());
                    lstItem.SubItems.Add(x.ValorDiario.ToString());
                    lstInformacoesNutricionais.Items.Add(lstItem);
                });
            }


        }
        /// <summary>
        /// Preenche todos os campos da tela para edição de produto
        /// </summary>
        /// <param name="produto"></param>
        private void PreencherCamposTela(ProdutoModel produto)
        {
            if (produto != null)
            {
                produtoModel = produto;
                txtCodigo.Text = produto.Codigo;
                txtDescricao.Text = produto.Descricao;
                txtIngredientes.Text = produto.Ingrediente;
                txtPrecoVenda.Text = produto.PrecoVenda.ToString();
                txtUnidadeEmbalagem.Text = produto.UnidadeMedida;

                AtualizarAmbienteCadastro(true);
            }
            lstInformacoesNutricionais.Columns[1].Width = 180;
        }

        /// <summary>
        /// Captura dados do formulário de cadastro e carrega em um objeto ProdutoModel
        /// </summary>
        /// <returns></returns>
        private void MontarObjetoProduto()
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
            if (produtoModel.Id == 0)
            { //Percorrer lista de informações e montar lista para o produto (Clonagem)
              //ToDo
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
            if (produto.Descricao.Trim().Length > 0
                && produto.Codigo.Trim().Length > 0
                && produto.Ingrediente.Trim().Length > 0
                && produto.PrecoVenda > 0)
            {
                response = true;
            }

            return response;
        }
        /// <summary>
        /// Muda aparência e acessibilidade de campos da tela de acordo com o botão de ação ou contexto de cadastro
        /// </summary>
        /// <param name="statusAbilitado"></param>
        private void AtualizarAmbienteCadastro(bool statusAbilitado)
        {
            btDuplicar.Enabled = statusAbilitado;
            btExcluir.Enabled = statusAbilitado;
            btGravar.Enabled = statusAbilitado;
            grpProduto.Enabled = statusAbilitado;
            btCadastrarInfNutricional.Enabled = statusAbilitado;
            btDuplicar.Enabled = statusAbilitado;
            btImprimirEtiqueta.Enabled = statusAbilitado;
            btGravar.Text = produtoModel != null && produtoModel.Id > 0 ? "Alterar" : "Cadastrar";
        }
        /// <summary>
        ///  Prepara campos da tela para inicialização
        /// </summary>
        private void InicializaCamposForm()
        {
            grpProduto.Enabled = true;
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtPrecoVenda.Text = "0,00";
            txtIngredientes.Text = "";
            txtDiasValidade.Text = "1";
            txtQtdPorcao.Text = "0,00";
            txtUnidadeEmbalagem.Text = "g";
        }
        /// <summary>
        /// Popula a tabela de etiquetas com o produtoModel atual e aciona o formulário de impressão
        /// </summary>
        private void GerarEtiquetaImpressao()
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
        /// <summary>
        /// Captura todos as informações nutricionais da lista e monta coleção de informações de um produto
        /// </summary>
        /// <returns></returns>
        private List<InformacaoNutricionalModel> MotarInformacoesNutricionaisProduto()
        {
            List<InformacaoNutricionalModel> response;
            response = infContoller.BuscarPorProduto(produtoModel);
            return response;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            MontarObjetoProduto();
            if (ValidaGravacao(produtoModel))
            {
                if (produtoModel != null && produtoModel.Id > 0)
                {
                    produtoController.Atualizar(produtoModel);
                    MessageBox.Show("Produto [" + produtoModel.Id + "] atualizado com sucesso.");
                }
                else
                {
                    produtoController.Cadastrar(produtoModel);
                    MessageBox.Show("Produto [" + produtoModel.Id + "] cadastrado com sucesso.");
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
            produtoModel = null;
            AtualizarAmbienteCadastro(true);
            MontarObjetoProduto();
        }

        private void btCadastrarInfNutricional_Click(object sender, EventArgs e)
        {
            formManutencaoInfNutricionais frmInf = new formManutencaoInfNutricionais(produtoModel);
            frmInf.ShowDialog();
            CarregaListaInformacoesNutricionais();
        }

        private void lstInformacoesNutricionais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstInformacoesNutricionais_DoubleClick(object sender, EventArgs e)
        {
            if (lstInformacoesNutricionais.SelectedItems.Count > 0)
            {
                InformacaoNutricionalModel infModel = new InformacaoNutricionalModel();
                infModel.Id = Int32.Parse(lstInformacoesNutricionais.SelectedItems[0].SubItems[0].Text);
                infModel = infContoller.Buscar(infModel);
                formManutencaoInfNutricionais frmInf = new formManutencaoInfNutricionais(infModel);
                frmInf.ShowDialog();
                CarregaListaInformacoesNutricionais();
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
    }
}
