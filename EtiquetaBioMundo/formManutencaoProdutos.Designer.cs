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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.txtDiasValidade = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btImprimirEtiqueta = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btDuplicar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInformacoesNutricionais = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUndEmb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpProduto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacoesNutricionais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 587);
            this.panel1.TabIndex = 11;
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
            this.grpProduto.Location = new System.Drawing.Point(12, 3);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(507, 484);
            this.grpProduto.TabIndex = 1;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "  Dados do Produto";
            // 
            // txtDiasValidade
            // 
            this.txtDiasValidade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasValidade.Location = new System.Drawing.Point(350, 58);
            this.txtDiasValidade.Mask = "00";
            this.txtDiasValidade.Name = "txtDiasValidade";
            this.txtDiasValidade.Size = new System.Drawing.Size(138, 31);
            this.txtDiasValidade.TabIndex = 2;
            this.txtDiasValidade.Text = "01";
            this.txtDiasValidade.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dias validade:*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Qtd. Porção:*";
            // 
            // txtQtdPorcao
            // 
            this.txtQtdPorcao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdPorcao.Location = new System.Drawing.Point(20, 254);
            this.txtQtdPorcao.MaxLength = 8;
            this.txtQtdPorcao.Multiline = true;
            this.txtQtdPorcao.Name = "txtQtdPorcao";
            this.txtQtdPorcao.Size = new System.Drawing.Size(137, 31);
            this.txtQtdPorcao.TabIndex = 4;
            this.txtQtdPorcao.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unidade de medida:*";
            // 
            // txtUnidadeEmbalagem
            // 
            this.txtUnidadeEmbalagem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeEmbalagem.Location = new System.Drawing.Point(185, 254);
            this.txtUnidadeEmbalagem.MaxLength = 5;
            this.txtUnidadeEmbalagem.Multiline = true;
            this.txtUnidadeEmbalagem.Name = "txtUnidadeEmbalagem";
            this.txtUnidadeEmbalagem.Size = new System.Drawing.Size(137, 31);
            this.txtUnidadeEmbalagem.TabIndex = 5;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(20, 349);
            this.txtIngredientes.MaxLength = 500;
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(468, 115);
            this.txtIngredientes.TabIndex = 7;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(351, 254);
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
            this.txtCodigo.Location = new System.Drawing.Point(20, 58);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(297, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(20, 137);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(468, 67);
            this.txtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingredientes:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço de Venda:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btImprimirEtiqueta);
            this.panel2.Controls.Add(this.btNovo);
            this.panel2.Controls.Add(this.btDuplicar);
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Controls.Add(this.btGravar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 100);
            this.panel2.TabIndex = 12;
            // 
            // btImprimirEtiqueta
            // 
            this.btImprimirEtiqueta.Enabled = false;
            this.btImprimirEtiqueta.Location = new System.Drawing.Point(411, 22);
            this.btImprimirEtiqueta.Name = "btImprimirEtiqueta";
            this.btImprimirEtiqueta.Size = new System.Drawing.Size(119, 66);
            this.btImprimirEtiqueta.TabIndex = 13;
            this.btImprimirEtiqueta.Text = "&Etiqueta";
            this.btImprimirEtiqueta.UseVisualStyleBackColor = true;
            this.btImprimirEtiqueta.Click += new System.EventHandler(this.btImprimirEtiqueta_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(536, 22);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(120, 66);
            this.btNovo.TabIndex = 9;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btDuplicar
            // 
            this.btDuplicar.Enabled = false;
            this.btDuplicar.Location = new System.Drawing.Point(781, 22);
            this.btDuplicar.Name = "btDuplicar";
            this.btDuplicar.Size = new System.Drawing.Size(119, 66);
            this.btDuplicar.TabIndex = 11;
            this.btDuplicar.Text = "&Duplicar";
            this.btDuplicar.UseVisualStyleBackColor = true;
            this.btDuplicar.Click += new System.EventHandler(this.btDuplicar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(906, 22);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 66);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(662, 22);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(114, 66);
            this.btGravar.TabIndex = 10;
            this.btGravar.Text = "&Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvInformacoesNutricionais);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(525, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 487);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 33);
            this.panel4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "INFORMAÇÕES NUTRICIONAIS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInformacoesNutricionais
            // 
            this.dgvInformacoesNutricionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colUndEmb,
            this.colQtd,
            this.colVD});
            this.dgvInformacoesNutricionais.Enabled = false;
            this.dgvInformacoesNutricionais.Location = new System.Drawing.Point(3, 35);
            this.dgvInformacoesNutricionais.Name = "dgvInformacoesNutricionais";
            this.dgvInformacoesNutricionais.Size = new System.Drawing.Size(498, 452);
            this.dgvInformacoesNutricionais.TabIndex = 17;
            this.dgvInformacoesNutricionais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInformacoesNutricionais_KeyDown);
            // 
            // colID
            // 
            this.colID.HeaderText = "Id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            // 
            // colUndEmb
            // 
            this.colUndEmb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUndEmb.HeaderText = "UND";
            this.colUndEmb.Name = "colUndEmb";
            this.colUndEmb.Width = 67;
            // 
            // colQtd
            // 
            this.colQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQtd.HeaderText = "Qtd.";
            this.colQtd.Name = "colQtd";
            this.colQtd.Width = 64;
            // 
            // colVD
            // 
            this.colVD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVD.HeaderText = "%VD";
            this.colVD.Name = "colVD";
            this.colVD.Width = 68;
            // 
            // formManutencaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 587);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formManutencaoProdutos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição de Produtos e Informações Nutricionais";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formManutencaoProdutos_KeyPress);
            this.panel1.ResumeLayout(false);
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacoesNutricionais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.MaskedTextBox txtDiasValidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtdPorcao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidadeEmbalagem;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btDuplicar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btImprimirEtiqueta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInformacoesNutricionais;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUndEmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVD;
    }
}