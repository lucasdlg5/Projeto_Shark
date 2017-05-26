namespace projeto_shark
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarVendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Produtos = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.Produtos,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Gerenciar Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVendaToolStripMenuItem1,
            this.adicionarProdutoToolStripMenuItem,
            this.produtosCadastradosToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(115, 20);
            this.toolStripSplitButton2.Text = "Mais Utilizados";
            // 
            // adicionarVendaToolStripMenuItem1
            // 
            this.adicionarVendaToolStripMenuItem1.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.adicionarVendaToolStripMenuItem1.Name = "adicionarVendaToolStripMenuItem1";
            this.adicionarVendaToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.adicionarVendaToolStripMenuItem1.Text = "Adicionar Venda";
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            this.adicionarProdutoToolStripMenuItem.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            this.adicionarProdutoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            // 
            // produtosCadastradosToolStripMenuItem
            // 
            this.produtosCadastradosToolStripMenuItem.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.produtosCadastradosToolStripMenuItem.Name = "produtosCadastradosToolStripMenuItem";
            this.produtosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.produtosCadastradosToolStripMenuItem.Text = "Produtos Cadastrados";
            this.produtosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.produtosCadastradosToolStripMenuItem_Click);
            // 
            // Produtos
            // 
            this.Produtos.AccessibleName = "tsb_produtos";
            this.Produtos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listaDeProdutosToolStripMenuItem});
            this.Produtos.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.Produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(137, 20);
            this.Produtos.Text = "Gerenciar Produtos";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar/Remover";
            // 
            // listaDeProdutosToolStripMenuItem
            // 
            this.listaDeProdutosToolStripMenuItem.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.listaDeProdutosToolStripMenuItem.Name = "listaDeProdutosToolStripMenuItem";
            this.listaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listaDeProdutosToolStripMenuItem.Text = "Produtos Cadastrados";
            this.listaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.listaDeProdutosToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVendaToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(126, 20);
            this.toolStripSplitButton1.Text = "Gerenciar Vendas";
            this.toolStripSplitButton1.ToolTipText = "tsb_vendas";
            // 
            // adicionarVendaToolStripMenuItem
            // 
            this.adicionarVendaToolStripMenuItem.Image = global::projeto_shark.Properties.Resources.Tubarao;
            this.adicionarVendaToolStripMenuItem.Name = "adicionarVendaToolStripMenuItem";
            this.adicionarVendaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.adicionarVendaToolStripMenuItem.Text = "Adicionar Venda";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHARK SOFTWARE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem adicionarVendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adicionarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Produtos;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem adicionarVendaToolStripMenuItem;
    }
}