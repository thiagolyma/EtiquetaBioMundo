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
            lstProdutos.Clear();
            List<ProdutoModel> listaProdutos = produtoController.BuscarTodos();
            listaProdutos.ForEach(x =>
            {
               ListViewItem lstItem = new ListViewItem(x.Id.ToString());
               lstItem.SubItems.Add(x.Codigo);
               lstItem.SubItems.Add(x.Descricao);
               lstItem.SubItems.Add(x.PrecoVenda.ToString());
               lstProdutos.Items.Add(lstItem);
            });
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = new ProdutoModel();
            produto.Id = 5;
            produto = new ProdutoController().Buscar(produto);
            formManutencaoProdutos formCad = new formManutencaoProdutos(produto);
            formCad.ShowDialog();
        }

    }
}
