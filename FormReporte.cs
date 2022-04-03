using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
namespace chocoflantastico
{
    public partial class FormReporte : Form
    {
        Usuario bd = new Usuario();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {
        
            bd.CualquierTabla(dgv, "SELECT a.idProducto[id Producto],b.nombrePro[Nombre del producto],a.cantidadIngresada[Cantidad],a.fechaIngreso[Fecha de ingreso],a.caducidadPro[Fecha caducidad] FROM [dbo].[ProductoDetalle] a inner join [dbo].[Productos] b on a.idProducto = b.idProducto");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar la aplicación", "CHOCOFLANTASTICO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
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

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 25;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, left, top);
                    left += col.Width+80;

                    if (col.Index < dgv.ColumnCount)
                        ep.Graphics.DrawLine(Pens.Gray, left - 10, top, left - 10, top + 43 + (dgv.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 80;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Index == dgv.RowCount) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 10), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width+80;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }
    }
}
