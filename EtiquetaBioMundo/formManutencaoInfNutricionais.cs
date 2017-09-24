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

namespace EtiquetaBioMundo
{
    public partial class formManutencaoInfNutricionais : Form
    {
        private InformacaoNutricionalController infController = new InformacaoNutricionalController();
        private InformacaoNutricionalModel informacaoNutricionalModel = null;
        private ProdutoModel produtoModel;

        public formManutencaoInfNutricionais(ProdutoModel produto)
        {
            InitializeComponent();
            produtoModel = produto;
        }

        /// <summary>
        /// Sobregarga do método construtor. Utilizado para edição de Informações Nutricionais
        /// </summary>
        /// <param name="produto"></param>
        public formManutencaoInfNutricionais(InformacaoNutricionalModel informacaoNutricional)
        {
            InitializeComponent();
            PreencherCamposTela(informacaoNutricional);
            AtualizarAmbienteCadastro();
            produtoModel = informacaoNutricional.Produto;
        }
        /// <summary>
        /// Preenche todos os campos da tela para edição de informação Nutricionail
        /// </summary>
        /// <param name="informacao">Objeto do tipo InformacaoNutricionalModel utilizado para preencher os campos da tela</param>
        private void PreencherCamposTela(InformacaoNutricionalModel informacao)
        {
            if (informacao != null)
            {
                this.informacaoNutricionalModel = informacao;
                txtDescricao.Text = informacao.Descricao;
                txtQuantidade.Text = informacao.Quantidade.ToString();
                txtUnidadeMedida.Text = informacao.UnidadeMedia;
                txtValorDiario.Text = informacao.ValorDiario.ToString();
            }
        }
        /// <summary>
        /// Captura dados do formulário de cadastro e carrega em um objeto InformacaoNutricionalModel
        /// </summary>
        private void MontarObjetoInformacaoNutricional()
        {
            if (informacaoNutricionalModel == null)
                informacaoNutricionalModel = new InformacaoNutricionalModel();

            informacaoNutricionalModel.DataCadastro = DateTime.Now;
            informacaoNutricionalModel.Descricao = txtDescricao.Text.Trim();
            informacaoNutricionalModel.UnidadeMedia = txtUnidadeMedida.Text.Trim();
            informacaoNutricionalModel.Quantidade = Decimal.Parse(txtQuantidade.Text.Trim());
            informacaoNutricionalModel.ValorDiario = Decimal.Parse(txtValorDiario.Text.Trim());
            informacaoNutricionalModel.Produto = produtoModel;
        }
        /// <summary>
        /// Validar valores dos campos do formulário antes da gravação e edição
        /// </summary>
        /// <returns></returns>
        private bool ValidaGravacao()
        {
            bool response = false;
            if (txtDescricao.Text.Trim().Length > 0
                && txtQuantidade.Text.Trim().Length > 0
                && txtUnidadeMedida.Text.Trim().Length > 0
                && txtValorDiario.Text.Trim().Length > 0)
                response = true;
            return response;
        }
        /// <summary>
        /// Muda aparência e acessibilidade de campos da tela de acordo com o botão de ação ou contexto de cadastro
        /// </summary>
        private void AtualizarAmbienteCadastro()
        {
            btGravar.Text = informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0 ? "Alterar" : "Cadastrar";
            btExcluir.Enabled = informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0 ? true : false;
        }
        private void btGravar_Click(object sender, EventArgs e)
        {
            MontarObjetoInformacaoNutricional();
            if (ValidaGravacao())
            {
                if (informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0)
                {
                    infController.Atualizar(informacaoNutricionalModel);
                    MessageBox.Show("Informação Nutricional [" + informacaoNutricionalModel.Id + "] atualizada com sucesso.");
                }
                else
                {
                    infController.Cadastrar(informacaoNutricionalModel);
                    MessageBox.Show("Informação Nutricional [" + informacaoNutricionalModel.Id + "] cadastrada com sucesso.");
                }
            }
            else
                MessageBox.Show("Os campos obrigatórios não foram preenchidos corretamente.", "Erro na validação!");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0)
            {
                DialogResult resposta = MessageBox.Show("Deseja excluir a informação nutricional do produto?", "Excluir", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    infController.Remover(informacaoNutricionalModel);
                    this.Dispose();
                }
            }
        }
    }
}
