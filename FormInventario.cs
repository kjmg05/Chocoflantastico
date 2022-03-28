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
            if (dgvInventario.SelectedRows.Count == 0)
            {
                btnInhabilitar.Enabled = false;
                btnModificar.Enabled = false;
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

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Demo App - Message!");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                e.Cancel = true;
                txtNombre.Focus();
                errorProviderApp.SetError(txtNombre, "No deje este espacio en blanco!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtNombre, "");
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                e.Cancel = true;
                txtDesc.Focus();
                errorProviderApp.SetError(txtDesc, "No deje este espacio en blanco!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtDesc, "");
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                e.Cancel = true;
                txtPrecio.Focus();
                errorProviderApp.SetError(txtPrecio, "No deje este escacio en blanco!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPrecio, "");
            }
        }

        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategoria.SelectedText))
            {
                e.Cancel = true;
                cmbCategoria.Focus();
                errorProviderApp.SetError(cmbCategoria, "Seleccione una opción!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(cmbCategoria, "");
            }
        }

        private void nudExistecia_Validating(object sender, CancelEventArgs e)
        {
            if (nudExistecia.Value == 0)
            {
                e.Cancel = true;
                nudExistecia.Focus();
                errorProviderApp.SetError(nudExistecia, "No deje este espacio en 0 al ingresar un nuevo producto!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(nudExistecia, "");
            }
        }

        private void dtpFechaCaducidad_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaCaducidad.Value <= DateTime.Now)
            {
                e.Cancel = true;
                dtpFechaCaducidad.Focus();
                errorProviderApp.SetError(dtpFechaCaducidad, "Seleccione una fecha mayor a la actual! O revise si el producto debe desecharse");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(dtpFechaCaducidad, "");
            }
        }
    }
}
