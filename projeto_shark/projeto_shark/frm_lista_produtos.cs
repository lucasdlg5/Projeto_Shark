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
    public partial class frm_lista_produtos : Form
    {
        public frm_lista_produtos()
        {
            InitializeComponent();
        }

        private void frm_lista_produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_sharkDataSet1.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bd_sharkDataSet1.Table);

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
         



        }

        private void grid_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
