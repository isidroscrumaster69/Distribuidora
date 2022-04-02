using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Distribuidora
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();

            menu.Show();
            this.Hide();
        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        conexionbd con = new conexionbd();
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text == "" || txtmonto.Text == "")
            {
                MessageBox.Show("No deje vacios los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO ingresos (descrip_ingreso, date_ingreso, value_ingreso, id_usuario) VALUES (@descrip_ingreso,@date_ingreso,@value_ingreso,@id_usuario)";
                con.abrir();
                SqlCommand comando = new SqlCommand(query, con.conectarbd);
                comando.Parameters.AddWithValue("@descrip_ingreso", txtdescripcion.Text);
                comando.Parameters.AddWithValue("@date_ingreso", dtpfecha.Value);
                comando.Parameters.AddWithValue("@value_ingreso", txtmonto.Text);
                comando.Parameters.AddWithValue("@id_usuario", "1");
                comando.ExecuteNonQuery();
                MessageBox.Show("Ingreso Registro");
                con.cerrar();
                txtdescripcion.Clear();
                txtmonto.Clear();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarApp);
        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            
        }
    }
}
