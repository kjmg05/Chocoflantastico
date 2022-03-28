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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            if (dgvUsers.SelectedRows.Count == 0)
            {
                btnInhabilitar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                errorProviderApp.SetError(txtUsuario, "No deje este espacio en blanco!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsuario, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "No deje este espacio en blanco!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPassword, "");
            }
        }

        private void cmbRol_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbRol.SelectedText))
            {
                e.Cancel = true;
                cmbRol.Focus();
                errorProviderApp.SetError(cmbRol, "Seleccione una opción!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(cmbRol, "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Demo App - Message!");
            }
        }
    }
}
