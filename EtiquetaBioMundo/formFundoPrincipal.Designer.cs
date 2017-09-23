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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.btImprimir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(679, 507);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(147, 69);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "&Cadastrar Produto";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.CheckBoxes = true;
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.colCodigo,
            this.colDescricao,
            this.colPreco});
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.GridLines = true;
            this.lstProdutos.Location = new System.Drawing.Point(17, 58);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(809, 433);
            this.lstProdutos.TabIndex = 1;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(526, 507);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(147, 69);
            this.btImprimir.TabIndex = 2;
            this.btImprimir.Text = "&Imprimir Etiqueta";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(17, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(760, 22);
            this.txtPesquisa.TabIndex = 3;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(783, 29);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(42, 23);
            this.btPesquisar.TabIndex = 4;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(21, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(298, 17);
            this.lblPesquisa.TabIndex = 5;
            this.lblPesquisa.Text = "Digite o código ou a descrição para pesquisar";
            // 
            // colCodigo
            // 
            this.colCodigo.DisplayIndex = 0;
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 200;
            // 
            // colDescricao
            // 
            this.colDescricao.DisplayIndex = 1;
            this.colDescricao.Text = "Descrição";
            this.colDescricao.Width = 500;
            // 
            // colPreco
            // 
            this.colPreco.DisplayIndex = 2;
            this.colPreco.Text = "Preço Venda";
            this.colPreco.Width = 100;
            // 
            // Id
            // 
            this.Id.DisplayIndex = 3;
            this.Id.Width = 0;
            // 
            // formFundoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 588);
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
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colDescricao;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader Id;
    }
}