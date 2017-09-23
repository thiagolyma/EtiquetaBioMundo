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
    public partial class formFundoPrincipal : Form
    {
        ProdutoController produtoController = new ProdutoController();

        public formFundoPrincipal()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            ListViewItem lstItem = null;
            lstProdutos.Items.Clear();
            List<ProdutoModel> produtos = produtoController.BuscarTodos();
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
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
          
        }

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItems.Count > 0)
            {
                ProdutoModel produto = new ProdutoModel();
                produto.Id =  Int32.Parse(lstProdutos.SelectedItems[0].SubItems[0].Text);
                produto = produtoController.Buscar(produto);
                formManutencaoProdutos formCad = new formManutencaoProdutos(produto);
                formCad.ShowDialog();
                CarregarLista();
            }
        }
    }
}
