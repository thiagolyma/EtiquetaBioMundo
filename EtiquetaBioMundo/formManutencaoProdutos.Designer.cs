namespace EtiquetaBioMundo
{
    partial class formManutencaoProdutos
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
            this.btGravar = new System.Windows.Forms.Button();
            this.lstInformacoesNutricionais = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtdPorcao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidadeEmbalagem = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btDuplicar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btCadastrarInfNutricional = new System.Windows.Forms.Button();
            this.btImprimirEtiqueta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasValidade = new System.Windows.Forms.MaskedTextBox();
            this.grpProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(657, 507);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(114, 66);
            this.btGravar.TabIndex = 6;
            this.btGravar.Text = "&Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // lstInformacoesNutricionais
            // 
            this.lstInformacoesNutricionais.AutoArrange = false;
            this.lstInformacoesNutricionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInformacoesNutricionais.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colDescricao,
            this.colUnidade,
            this.colQuantidade,
            this.colVD});
            this.lstInformacoesNutricionais.FullRowSelect = true;
            this.lstInformacoesNutricionais.GridLines = true;
            this.lstInformacoesNutricionais.LabelEdit = true;
            this.lstInformacoesNutricionais.Location = new System.Drawing.Point(531, 76);
            this.lstInformacoesNutricionais.MultiSelect = false;
            this.lstInformacoesNutricionais.Name = "lstInformacoesNutricionais";
            this.lstInformacoesNutricionais.ShowItemToolTips = true;
            this.lstInformacoesNutricionais.Size = new System.Drawing.Size(490, 410);
            this.lstInformacoesNutricionais.TabIndex = 1;
            this.lstInformacoesNutricionais.UseCompatibleStateImageBehavior = false;
            this.lstInformacoesNutricionais.View = System.Windows.Forms.View.Details;
            this.lstInformacoesNutricionais.SelectedIndexChanged += new System.EventHandler(this.lstInformacoesNutricionais_SelectedIndexChanged);
            this.lstInformacoesNutricionais.DoubleClick += new System.EventHandler(this.lstInformacoesNutricionais_DoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 0;
            // 
            // colDescricao
            // 
            this.colDescricao.Text = "Descrição";
            this.colDescricao.Width = 306;
            // 
            // colUnidade
            // 
            this.colUnidade.Text = "UND";
            this.colUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Text = "QTD";
            this.colQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colVD
            // 
            this.colVD.Text = "% VD";
            this.colVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.txtDiasValidade);
            this.grpProduto.Controls.Add(this.label8);
            this.grpProduto.Controls.Add(this.label7);
            this.grpProduto.Controls.Add(this.txtQtdPorcao);
            this.grpProduto.Controls.Add(this.label6);
            this.grpProduto.Controls.Add(this.txtUnidadeEmbalagem);
            this.grpProduto.Controls.Add(this.txtIngredientes);
            this.grpProduto.Controls.Add(this.txtPrecoVenda);
            this.grpProduto.Controls.Add(this.txtCodigo);
            this.grpProduto.Controls.Add(this.txtDescricao);
            this.grpProduto.Controls.Add(this.label4);
            this.grpProduto.Controls.Add(this.label3);
            this.grpProduto.Controls.Add(this.label2);
            this.grpProduto.Controls.Add(this.label1);
            this.grpProduto.Enabled = false;
            this.grpProduto.Location = new System.Drawing.Point(14, 26);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(501, 460);
            this.grpProduto.TabIndex = 0;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "  Dados do Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Qtd. Porção:*";
            // 
            // txtQtdPorcao
            // 
            this.txtQtdPorcao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdPorcao.Location = new System.Drawing.Point(20, 204);
            this.txtQtdPorcao.MaxLength = 8;
            this.txtQtdPorcao.Multiline = true;
            this.txtQtdPorcao.Name = "txtQtdPorcao";
            this.txtQtdPorcao.Size = new System.Drawing.Size(137, 31);
            this.txtQtdPorcao.TabIndex = 4;
            this.txtQtdPorcao.Text = "0,00";
            this.txtQtdPorcao.TextChanged += new System.EventHandler(this.qtdPorcao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unidade de medida:*";
            // 
            // txtUnidadeEmbalagem
            // 
            this.txtUnidadeEmbalagem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeEmbalagem.Location = new System.Drawing.Point(180, 204);
            this.txtUnidadeEmbalagem.MaxLength = 5;
            this.txtUnidadeEmbalagem.Multiline = true;
            this.txtUnidadeEmbalagem.Name = "txtUnidadeEmbalagem";
            this.txtUnidadeEmbalagem.Size = new System.Drawing.Size(137, 31);
            this.txtUnidadeEmbalagem.TabIndex = 5;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(20, 262);
            this.txtIngredientes.MaxLength = 500;
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(468, 172);
            this.txtIngredientes.TabIndex = 7;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(351, 204);
            this.txtPrecoVenda.MaxLength = 8;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(137, 31);
            this.txtPrecoVenda.TabIndex = 6;
            this.txtPrecoVenda.Text = "0,00";
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(20, 50);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(297, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(20, 105);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(468, 67);
            this.txtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingredientes:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço de Venda:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:*";
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(901, 507);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 66);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btDuplicar
            // 
            this.btDuplicar.Enabled = false;
            this.btDuplicar.Location = new System.Drawing.Point(776, 507);
            this.btDuplicar.Name = "btDuplicar";
            this.btDuplicar.Size = new System.Drawing.Size(119, 66);
            this.btDuplicar.TabIndex = 7;
            this.btDuplicar.Text = "&Duplicar";
            this.btDuplicar.UseVisualStyleBackColor = true;
            this.btDuplicar.Click += new System.EventHandler(this.btDuplicar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(531, 507);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(120, 66);
            this.btNovo.TabIndex = 5;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "INFORMAÇÕES NUTRICIONAIS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastrarInfNutricional
            // 
            this.btCadastrarInfNutricional.Location = new System.Drawing.Point(752, 29);
            this.btCadastrarInfNutricional.Name = "btCadastrarInfNutricional";
            this.btCadastrarInfNutricional.Size = new System.Drawing.Size(34, 24);
            this.btCadastrarInfNutricional.TabIndex = 10;
            this.btCadastrarInfNutricional.Text = "+";
            this.btCadastrarInfNutricional.UseVisualStyleBackColor = true;
            this.btCadastrarInfNutricional.Click += new System.EventHandler(this.btCadastrarInfNutricional_Click);
            // 
            // btImprimirEtiqueta
            // 
            this.btImprimirEtiqueta.Enabled = false;
            this.btImprimirEtiqueta.Location = new System.Drawing.Point(34, 507);
            this.btImprimirEtiqueta.Name = "btImprimirEtiqueta";
            this.btImprimirEtiqueta.Size = new System.Drawing.Size(119, 66);
            this.btImprimirEtiqueta.TabIndex = 9;
            this.btImprimirEtiqueta.Text = "&Etiqueta";
            this.btImprimirEtiqueta.UseVisualStyleBackColor = true;
            this.btImprimirEtiqueta.Click += new System.EventHandler(this.btImprimirEtiqueta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dias validade:*";
            // 
            // txtDiasValidade
            // 
            this.txtDiasValidade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasValidade.Location = new System.Drawing.Point(350, 50);
            this.txtDiasValidade.Mask = "00";
            this.txtDiasValidade.Name = "txtDiasValidade";
            this.txtDiasValidade.Size = new System.Drawing.Size(138, 31);
            this.txtDiasValidade.TabIndex = 2;
            this.txtDiasValidade.Text = "01";
            this.txtDiasValidade.ValidatingType = typeof(int);
            // 
            // formManutencaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 587);
            this.Controls.Add(this.btImprimirEtiqueta);
            this.Controls.Add(this.btCadastrarInfNutricional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btDuplicar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.lstInformacoesNutricionais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formManutencaoProdutos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição de Produtos e Informações Nutricionais";
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btDuplicar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListView lstInformacoesNutricionais;
        private System.Windows.Forms.Button btCadastrarInfNutricional;
        public System.Windows.Forms.ColumnHeader colDescricao;
        public System.Windows.Forms.ColumnHeader colUnidade;
        public System.Windows.Forms.ColumnHeader colQuantidade;
        public System.Windows.Forms.ColumnHeader colVD;
        private System.Windows.Forms.Button btImprimirEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidadeEmbalagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtdPorcao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDiasValidade;
    }
}