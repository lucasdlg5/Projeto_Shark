using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_shark
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            Form splash = new frm_splash();
            splash.ShowDialog();

        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void Produtos_ButtonClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void produtosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista_produtos = new frm_lista_produtos();
            lista_produtos.Show();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista_produtos = new frm_lista_produtos();
            lista_produtos.Show();
        }
    }
}
