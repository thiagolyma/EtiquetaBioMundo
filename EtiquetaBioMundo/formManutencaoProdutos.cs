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
        private ProdutoController produtoController;
        private InformacaoNutricionalController infContoller;

        public formManutencaoProdutos()
        {
            InitializeComponent();
            produtoController = new ProdutoController();
            infContoller = new InformacaoNutricionalController();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = MontarObjetoProduto();
            produtoController.Cadastrar(produto);
            MessageBox.Show("Produto [" + produto.Id + "] cadastrado com sucesso.");
        }
        /// <summary>
        /// Captura dados do formulário de cadastro e carrega em um objeto ProdutoModel
        /// </summary>
        /// <returns></returns>
        private ProdutoModel MontarObjetoProduto()
        {
           
            ProdutoModel produto = new ProdutoModel()
            {
                Codigo = txtCodigo.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),
                PrecoVenda = Decimal.Parse(txtPrecoVenda.Text.Trim()),
                Ingrediente = txtIngredientes.Text.Trim()
            };
            produto.InformacoesNutricionais = MotarInformacoesNutricionaisProduto();
            
            return produto;
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

        private void formManutencaoProduto_Load(object sender, EventArgs e)
        {

        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception erro)
            {

            }
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            InicializaForm();
            MudarAmbienteCadastroNovo();
        }

        private void MudarAmbienteCadastroNovo()
        {
            btDuplicar.Enabled = true;
            btExcluir.Enabled = true;
            btGravar.Enabled = true;
            grpProduto.Enabled = true;
        }

        private void InicializaForm()
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
            Moeda(ref txt);
        }
    }
}
