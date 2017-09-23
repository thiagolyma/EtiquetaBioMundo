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
    public partial class formManutencaoProdutos : Form
    {
        private ProdutoController produtoController = new ProdutoController();
        private InformacaoNutricionalController infContoller = new InformacaoNutricionalController();
        private ProdutoModel produtoModel = null;

        public formManutencaoProdutos()
        {
            InitializeComponent();
            InicializarCamposTela(null);
        }

        public formManutencaoProdutos(ProdutoModel produto)
        {
            InitializeComponent();
            InicializarCamposTela(produto);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            MontarObjetoProduto();
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
            btGravar.Text = produtoModel != null && produtoModel.Id > 0 ? "Alterar" : "Cadastrar";
            btGravar.Enabled = produtoModel != null && produtoModel.Id > 0 ? true : false;
            btExcluir.Enabled = produtoModel != null && produtoModel.Id > 0 ? true : false;
            btDuplicar.Enabled = produtoModel != null && produtoModel.Id > 0 ? true : false;
        }

        private void InicializarCamposTela(ProdutoModel produto)
        {
            if (produto != null)
            {
                produtoModel = produto;
                txtCodigo.Text = produto.Codigo;
                txtDescricao.Text = produto.Descricao;
                txtIngredientes.Text = produto.Ingrediente;
                txtPrecoVenda.Text = produto.PrecoVenda.ToString();
                AtualizarAmbienteCadastro(true);
            }
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
            //Percorrer lista de informações e montar lista para o produto
            produtoModel.InformacoesNutricionais = MotarInformacoesNutricionaisProduto();
        }

        /// <summary>
        /// Captura todos as informações nutricionais da lista e monta coleção de informações de um produto
        /// </summary>
        /// <returns></returns>
        private List<InformacaoNutricionalModel> MotarInformacoesNutricionaisProduto()
        {
            List<InformacaoNutricionalModel> response;
            response = infContoller.BuscarTodos();
            return response;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            InicializaCamposForm();
            AtualizarAmbienteCadastro(true);
        }

        private void AtualizarAmbienteCadastro(bool statusAbilitado)
        {
            btDuplicar.Enabled = statusAbilitado;
            btExcluir.Enabled = statusAbilitado;
            btGravar.Enabled = statusAbilitado;
            grpProduto.Enabled = statusAbilitado;
        }

        private void InicializaCamposForm()
        {
            grpProduto.Enabled = false;
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtPrecoVenda.Text = "0,00";
            txtIngredientes.Text = "";
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
                    AtualizarAmbienteCadastro(false);
                }
            }
        }

        private void btDuplicar_Click(object sender, EventArgs e)
        {
            produtoModel = null;
            MontarObjetoProduto();
        }
    }
}
