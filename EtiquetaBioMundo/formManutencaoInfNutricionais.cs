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
        public formManutencaoInfNutricionais()
        {
            InitializeComponent();
            InicializarCamposTela(null);
        }

        public formManutencaoInfNutricionais(InformacaoNutricionalModel informacaoNutricional)
        {
            InitializeComponent();
            InicializarCamposTela(informacaoNutricional);
        }

        private void InicializarCamposTela(InformacaoNutricionalModel informacaoNutricional)
        {
            if (informacaoNutricional != null)
            {
                this.informacaoNutricionalModel = informacaoNutricional;
                txtDescricao.Text = informacaoNutricional.Descricao;
                txtQuantidade.Text = informacaoNutricional.Quantidade.ToString();
                txtUnidadeMedida.Text = informacaoNutricional.UnidadeMedia;
                txtValorDiario.Text = informacaoNutricional.ValorDiario.ToString();
            }
            btGravar.Text = informacaoNutricional != null && informacaoNutricional.Id > 0 ? "Alterar" : "Cadastrar";
            btExcluir.Enabled = informacaoNutricional != null && informacaoNutricional.Id > 0 ? true : false;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            MontarObjetoInformacaoNutricional();
            if (informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0)
            {
                infController.Atualizar(informacaoNutricionalModel);
                MessageBox.Show("Informação Nutricional [" + informacaoNutricionalModel.Id + "] atualizado com sucesso.");
            }
            else
            {
                infController.Cadastrar(informacaoNutricionalModel);
                MessageBox.Show("Informação Nutricional [" + informacaoNutricionalModel.Id + "] cadastrado com sucesso.");
            }
        }

        private void MontarObjetoInformacaoNutricional()
        {
            informacaoNutricionalModel = new InformacaoNutricionalModel()
            {
                DataCadastro = DateTime.Now,
                Descricao = txtDescricao.Text.Trim(),
                UnidadeMedia = txtUnidadeMedida.Text.Trim(),
                Quantidade = Decimal.Parse(txtQuantidade.Text.Trim()),
                ValorDiario = Decimal.Parse(txtValorDiario.Text.Trim())
            };
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (informacaoNutricionalModel != null && informacaoNutricionalModel.Id > 0)
            {
                MontarObjetoInformacaoNutricional();
                infController.Remover(informacaoNutricionalModel);
            }
        }
    }
}
