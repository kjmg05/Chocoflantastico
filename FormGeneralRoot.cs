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
    public partial class FormGeneralRoot : Form
    {
        public FormGeneralRoot()
        {
            InitializeComponent();
        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormInventario().Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormUsers().Show();
        }
    }
}
