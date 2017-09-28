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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFundoPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEtiqueta = new System.Windows.Forms.DataGridView();
            this.colSelecionada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdEtiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPesquisa);
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 73);
            this.panel1.TabIndex = 7;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(11, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(293, 17);
            this.lblPesquisa.TabIndex = 8;
            this.lblPesquisa.Text = "Digite a descrição do produto para pesquisar";
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(461, 23);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(105, 34);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(14, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(441, 22);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btImprimir);
            this.panel2.Controls.Add(this.btCadastrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 96);
            this.panel2.TabIndex = 8;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(931, 15);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(147, 69);
            this.btImprimir.TabIndex = 4;
            this.btImprimir.Text = "&Imprimir Etiqueta";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(1084, 15);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(147, 69);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "&Cadastrar Produto";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEtiqueta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 419);
            this.panel3.TabIndex = 9;
            // 
            // dgvEtiqueta
            // 
            this.dgvEtiqueta.AllowUserToAddRows = false;
            this.dgvEtiqueta.AllowUserToDeleteRows = false;
            this.dgvEtiqueta.AllowUserToOrderColumns = true;
            this.dgvEtiqueta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtiqueta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelecionada,
            this.colId,
            this.colCod,
            this.colDesc,
            this.colPrecoVenda,
            this.colQtdEtiqueta,
            this.colValidade});
            this.dgvEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEtiqueta.Location = new System.Drawing.Point(0, 0);
            this.dgvEtiqueta.Name = "dgvEtiqueta";
            this.dgvEtiqueta.RowTemplate.Height = 24;
            this.dgvEtiqueta.Size = new System.Drawing.Size(1243, 419);
            this.dgvEtiqueta.TabIndex = 8;
            this.dgvEtiqueta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtiqueta_CellContentClick);
            this.dgvEtiqueta.DoubleClick += new System.EventHandler(this.dgvEtiqueta_DoubleClick);
            // 
            // colSelecionada
            // 
            this.colSelecionada.Frozen = true;
            this.colSelecionada.HeaderText = "";
            this.colSelecionada.Name = "colSelecionada";
            this.colSelecionada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelecionada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelecionada.Width = 50;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.Visible = false;
            // 
            // colCod
            // 
            this.colCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCod.Frozen = true;
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 81;
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDesc.Frozen = true;
            this.colDesc.HeaderText = "Descricao";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0,00";
            this.colPrecoVenda.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPrecoVenda.HeaderText = "Preço Venda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.ReadOnly = true;
            this.colPrecoVenda.Width = 119;
            // 
            // colQtdEtiqueta
            // 
            this.colQtdEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.colQtdEtiqueta.DefaultCellStyle = dataGridViewCellStyle8;
            this.colQtdEtiqueta.HeaderText = "Qtd. Etiquetas";
            this.colQtdEtiqueta.Name = "colQtdEtiqueta";
            this.colQtdEtiqueta.ToolTipText = "Digite a quantidade de etiquetas a serem impressas";
            this.colQtdEtiqueta.Width = 127;
            // 
            // colValidade
            // 
            this.colValidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "1";
            this.colValidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.colValidade.HeaderText = "Dias Validade";
            this.colValidade.Name = "colValidade";
            this.colValidade.ToolTipText = "Digite os dias de validade do produto";
            this.colValidade.Width = 124;
            // 
            // formFundoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formFundoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta BioMundo";
            this.Load += new System.EventHandler(this.formFundoPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiqueta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvEtiqueta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelecionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdEtiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValidade;
    }
}