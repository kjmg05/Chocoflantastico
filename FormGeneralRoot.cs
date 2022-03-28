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
        public FormGeneralRoot(string nombre, int rol)
        {
            InitializeComponent();
            lblUser.Text = nombre;
            if (rol == 2)
            {
                gbUsuarios.Visible = false;
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormInventario().Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pbCerrarSesion_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormUsers().Show();
        }
    }
}
