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
            this.grpProduto = new System.Windows.Forms.GroupBox();
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
            this.grpProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(440, 510);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(127, 66);
            this.btGravar.TabIndex = 6;
            this.btGravar.Text = "&Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // lstInformacoesNutricionais
            // 
            this.lstInformacoesNutricionais.Location = new System.Drawing.Point(531, 32);
            this.lstInformacoesNutricionais.Name = "lstInformacoesNutricionais";
            this.lstInformacoesNutricionais.Size = new System.Drawing.Size(302, 454);
            this.lstInformacoesNutricionais.TabIndex = 1;
            this.lstInformacoesNutricionais.UseCompatibleStateImageBehavior = false;
            // 
            // grpProduto
            // 
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
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(20, 262);
            this.txtIngredientes.MaxLength = 500;
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(468, 172);
            this.txtIngredientes.TabIndex = 4;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(20, 194);
            this.txtPrecoVenda.MaxLength = 8;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(162, 31);
            this.txtPrecoVenda.TabIndex = 3;
            this.txtPrecoVenda.Text = "0,00";
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(20, 50);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(468, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(20, 128);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(468, 30);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingredientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço de Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(706, 510);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(127, 66);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btDuplicar
            // 
            this.btDuplicar.Enabled = false;
            this.btDuplicar.Location = new System.Drawing.Point(573, 510);
            this.btDuplicar.Name = "btDuplicar";
            this.btDuplicar.Size = new System.Drawing.Size(127, 66);
            this.btDuplicar.TabIndex = 7;
            this.btDuplicar.Text = "&Duplicar";
            this.btDuplicar.UseVisualStyleBackColor = true;
            this.btDuplicar.Click += new System.EventHandler(this.btDuplicar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(307, 510);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(127, 66);
            this.btNovo.TabIndex = 5;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // formManutencaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 600);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btDuplicar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.lstInformacoesNutricionais);
            this.Controls.Add(this.btGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formManutencaoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Edição de Produtos e Informações Nutricionais";
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.ListView lstInformacoesNutricionais;
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
    }
}