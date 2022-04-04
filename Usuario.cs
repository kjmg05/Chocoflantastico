using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace chocoflantastico
{
    class Usuario
    {
        private string user;
        private string pass;
        public SqlConnection sc = new SqlConnection();
        SqlDataAdapter da;
        DataTable dt;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        string  connection = "Data Source=DESKTOP-PE4OUB7;Initial Catalog=chocoflantastico;Integrated Security=True";
        public Usuario()
        {
            sc.ConnectionString = connection;
        }


    

        public void CerrarConexion()
        {
            sc.Close();
        }

        public bool Autenticacion(string comando)
        {
            SqlCommand command = new SqlCommand(comando, sc);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString() == "1")
                {
                    user = table.Rows[0][1].ToString();
                    new FormGeneralRoot(table.Rows[0][1].ToString(), 1).Show();
                }
                else
                {
                    user = table.Rows[0][1].ToString();
                    new FormGeneralRoot(table.Rows[0][1].ToString(), 2).Show();
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public void GuardarUsuario(string comando, string username, string password, int idRol, int estado)
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, sc);
                command.Parameters.AddWithValue("@nombre", username);
                command.Parameters.AddWithValue("@pass", password);
                command.Parameters.AddWithValue("@idRol", idRol);
                command.Parameters.AddWithValue("@estado", estado);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void GuardarInventario(string comando, int id,  string nombre, string desc, double precio, int existecia, 
            int estado, int categoria, string fechaCaducidad)
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, sc);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@desc", desc);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@existencia", existecia);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@fechaCaducidad", fechaCaducidad);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void Inventario(string comando, DataGridView dataGrid)
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, sc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;
                dataGrid.Columns[0].Width = 30;
                dataGrid.Columns[3].Width = 55;
                dataGrid.Columns[4].Width = 65;
                dataGrid.Columns[5].Width = 55;
                dataGrid.Columns[6].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        public void ComboBoxData(ComboBox cmb, string comando)
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, sc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmb.DisplayMember = "nombre";
                cmb.ValueMember = "id";
                cmb.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CualquierTabla(DataGridView dgv, string Query)
        {
            try
            {
                da = new SqlDataAdapter(Query, sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha sido posible establecer conexion" + ex.ToString()); ;
            }
        }

    }
}
