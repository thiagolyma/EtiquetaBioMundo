using EtiquetaDAL;
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
    public partial class formManutencaoProduto : Form
    {
       private ProdutoRepository produtoRepository;
       private ProdutoModel produtoModel;
        public formManutencaoProduto()
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository();
            produtoModel = new ProdutoModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produtoModel = new ProdutoModel()
            {
                DataCadastro = DateTime.Now,
                Descricao = "Produto teste 1",
                PrecoVenda = 10,
                Ingrediente = "Teste de ingrediente 1"
                
            };

            produtoRepository.Add(produtoModel);
            produtoRepository.Save();
            MessageBox.Show(produtoModel.Id.ToString());
        }
    }
}
