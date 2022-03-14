using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chocoflantastico
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
