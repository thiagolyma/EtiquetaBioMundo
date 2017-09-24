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
    public partial class formRelatorioEtiqueta : Form
    {
        public formRelatorioEtiqueta()
        {
            InitializeComponent();
        }

        private void formRelatorioEtiqueta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void formRelatorioEtiqueta_Resize(object sender, EventArgs e)
        {
            reportViewer1.Width = this.Width;
            reportViewer1.Height = this.Height;
        }
    }
}
