namespace EtiquetaBioMundo
{
    partial class formFundoPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtdEtiquetas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiasValidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btImprimir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 100;
            // 
            // colDescricao
            // 
            this.colDescricao.Text = "Descrição";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(840, 507);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(147, 69);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "&Cadastrar Produto";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.AutoArrange = false;
            this.lstProdutos.CheckBoxes = true;
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.colCodigo,
            this.colDescricao,
            this.colPreco,
            this.colQtdEtiquetas,
            this.colDiasValidade});
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.GridLines = true;
            this.lstProdutos.LabelEdit = true;
            this.lstProdutos.LabelWrap = false;
            this.lstProdutos.Location = new System.Drawing.Point(17, 58);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(970, 433);
            this.lstProdutos.TabIndex = 1;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            this.lstProdutos.DoubleClick += new System.EventHandler(this.lstProdutos_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 20;
            // 
            // colPreco
            // 
            this.colPreco.Text = "Preço Venda";
            this.colPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPreco.Width = 100;
            // 
            // colQtdEtiquetas
            // 
            this.colQtdEtiquetas.Text = "Qtd. Etiquetas";
            this.colQtdEtiquetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQtdEtiquetas.Width = 100;
            // 
            // colDiasValidade
            // 
            this.colDiasValidade.Text = "Dias Valid.";
            this.colDiasValidade.Width = 106;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(687, 507);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(147, 69);
            this.btImprimir.TabIndex = 2;
            this.btImprimir.Text = "&Imprimir Etiqueta";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(17, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(922, 22);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(945, 29);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(42, 23);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(21, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(293, 17);
            this.lblPesquisa.TabIndex = 5;
            this.lblPesquisa.Text = "Digite a descrição do produto para pesquisar";
            // 
            // formFundoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 588);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.btCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formFundoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta BioMundo";
            this.Load += new System.EventHandler(this.formFundoPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colDescricao;
        public System.Windows.Forms.ColumnHeader colQtdEtiquetas;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ColumnHeader colDiasValidade;
    }
}