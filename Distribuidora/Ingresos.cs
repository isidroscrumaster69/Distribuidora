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
            string query = "INSERT INTO ingresos (descrip_ingreso, date_ingreso, value_ingreso, id_usuario) VALUES (@descrip_ingreso,@date_ingreso,@value_ingreso,@id_usuario)";
            con.abrir();
            SqlCommand comando = new SqlCommand(query, con.conectarbd);
            comando.Parameters.AddWithValue("@descrip_ingreso", txtdescripcion.Text);
            comando.Parameters.AddWithValue("@date_ingreso", dtpfecha.Value);
            comando.Parameters.AddWithValue("@value_ingreso", txtmonto.Text);
            comando.Parameters.AddWithValue("@id_usuario", txtcodigo.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Ingreso Registro");
            con.cerrar();
            txtdescripcion.Clear();
            txtmonto.Clear();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
