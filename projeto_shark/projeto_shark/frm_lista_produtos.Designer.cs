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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lista_produtos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grid_produtos = new System.Windows.Forms.DataGridView();
            this.bd_sharkDataSet1 = new projeto_shark.bd_sharkDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new projeto_shark.bd_sharkDataSet1TableAdapters.TableTableAdapter();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_sharkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
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
            // grid_produtos
            // 
            this.grid_produtos.AutoGenerateColumns = false;
            this.grid_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.modeloprodutoDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn,
            this.fornecedorprodutoDataGridViewTextBoxColumn,
            this.datacompraprodutoDataGridViewTextBoxColumn,
            this.observacoesprodutoDataGridViewTextBoxColumn});
            this.grid_produtos.DataSource = this.tableBindingSource;
            this.grid_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_produtos.Location = new System.Drawing.Point(0, 0);
            this.grid_produtos.Name = "grid_produtos";
            this.grid_produtos.Size = new System.Drawing.Size(676, 426);
            this.grid_produtos.TabIndex = 0;
            this.grid_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_produtos_CellContentClick);
            // 
            // bd_sharkDataSet1
            // 
            this.bd_sharkDataSet1.DataSetName = "bd_sharkDataSet1";
            this.bd_sharkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.bd_sharkDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            // 
            // modeloprodutoDataGridViewTextBoxColumn
            // 
            this.modeloprodutoDataGridViewTextBoxColumn.DataPropertyName = "modelo_produto";
            this.modeloprodutoDataGridViewTextBoxColumn.HeaderText = "modelo_produto";
            this.modeloprodutoDataGridViewTextBoxColumn.Name = "modeloprodutoDataGridViewTextBoxColumn";
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            // 
            // fornecedorprodutoDataGridViewTextBoxColumn
            // 
            this.fornecedorprodutoDataGridViewTextBoxColumn.DataPropertyName = "fornecedor_produto";
            this.fornecedorprodutoDataGridViewTextBoxColumn.HeaderText = "fornecedor_produto";
            this.fornecedorprodutoDataGridViewTextBoxColumn.Name = "fornecedorprodutoDataGridViewTextBoxColumn";
            // 
            // datacompraprodutoDataGridViewTextBoxColumn
            // 
            this.datacompraprodutoDataGridViewTextBoxColumn.DataPropertyName = "data_compra_produto";
            this.datacompraprodutoDataGridViewTextBoxColumn.HeaderText = "data_compra_produto";
            this.datacompraprodutoDataGridViewTextBoxColumn.Name = "datacompraprodutoDataGridViewTextBoxColumn";
            // 
            // observacoesprodutoDataGridViewTextBoxColumn
            // 
            this.observacoesprodutoDataGridViewTextBoxColumn.DataPropertyName = "observacoes_produto";
            this.observacoesprodutoDataGridViewTextBoxColumn.HeaderText = "observacoes_produto";
            this.observacoesprodutoDataGridViewTextBoxColumn.Name = "observacoesprodutoDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.bd_sharkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView grid_produtos;
        private bd_sharkDataSet1 bd_sharkDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private bd_sharkDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesprodutoDataGridViewTextBoxColumn;
    }
}