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
    public partial class Egresos : Form
    {
        public Egresos()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Egresos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarApp);
        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Menu();

            menu.Show();
            this.Hide();
        }

        conexionbd con = new conexionbd();
        private void btnconfirmar_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO egresos (descrip_egreso, date_egreso, value_egreso, id_usuario) VALUES (@descrip_ingreso,@date_ingreso,@value_ingreso,@id_usuario)";
            con.abrir();
            SqlCommand comando = new SqlCommand(query, con.conectarbd);
            comando.Parameters.AddWithValue("@descrip_ingreso", txtDescripcion.Text);
            comando.Parameters.AddWithValue("@date_ingreso", dtpfecha.Value);
            comando.Parameters.AddWithValue("@value_ingreso", txtmonto.Text);
            comando.Parameters.AddWithValue("@id_usuario", "1");
            comando.ExecuteNonQuery();
            MessageBox.Show("Egreso Registrado");
            con.cerrar();
            txtDescripcion.Clear();
            txtmonto.Clear();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
