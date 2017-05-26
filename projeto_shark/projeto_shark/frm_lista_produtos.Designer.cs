namespace projeto_shark
{
    partial class frm_lista_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lista_produtos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lst_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst_data_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst_model_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lst_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_produtos = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 19);
            this.toolStripStatusLabel1.Text = "Total de items: 0";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lst_observacao
            // 
            this.lst_observacao.HeaderText = "Observacoes";
            this.lst_observacao.Name = "lst_observacao";
            // 
            // lst_data_compra
            // 
            this.lst_data_compra.HeaderText = "Data da Compra";
            this.lst_data_compra.Name = "lst_data_compra";
            // 
            // lst_fornecedor
            // 
            this.lst_fornecedor.HeaderText = "Fornecedor";
            this.lst_fornecedor.Name = "lst_fornecedor";
            // 
            // lst_quantidade
            // 
            this.lst_quantidade.HeaderText = "Quantidade";
            this.lst_quantidade.Name = "lst_quantidade";
            // 
            // lst_model_produto
            // 
            this.lst_model_produto.HeaderText = "Modelo";
            this.lst_model_produto.Name = "lst_model_produto";
            // 
            // lst_produto
            // 
            this.lst_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lst_produto.HeaderText = "Produto";
            this.lst_produto.Name = "lst_produto";
            this.lst_produto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lst_produto.Width = 69;
            // 
            // grid_produtos
            // 
            this.grid_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lst_produto,
            this.lst_model_produto,
            this.lst_quantidade,
            this.lst_fornecedor,
            this.lst_data_compra,
            this.lst_observacao});
            this.grid_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_produtos.Location = new System.Drawing.Point(0, 0);
            this.grid_produtos.Name = "grid_produtos";
            this.grid_produtos.Size = new System.Drawing.Size(676, 426);
            this.grid_produtos.TabIndex = 0;
            this.grid_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_produtos_CellContentClick);
            // 
            // frm_lista_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 426);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grid_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_lista_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shark - Lista de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_lista_produtos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_data_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_model_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lst_produto;
        private System.Windows.Forms.DataGridView grid_produtos;
    }
}