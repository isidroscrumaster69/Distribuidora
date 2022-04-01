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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new Menu();

            menu.Show();
            this.Hide();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();
            this.FormClosed += new FormClosedEventHandler(CerrarApp);

        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        conexionbd con = new conexionbd();

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select date_ingreso, descrip_ingreso,value_ingreso from[dbo].[ingresos] where date_ingreso = @date";
            con.abrir();
            SqlCommand comando = new SqlCommand(query, con.conectarbd);
            comando.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select date_egreso,descrip_egreso,value_egreso from [dbo].[egresos] where date_egreso =  @date";
            con.abrir();
            SqlCommand comando = new SqlCommand(query, con.conectarbd);
            comando.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridView2.DataSource = tabla;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT (SELECT SUM(value_ingreso) FROM ingresos where date_ingreso = @date) - (SELECT SUM(value_egreso) FROM egresos where date_egreso = @date) AS ganancia";
            con.abrir();
            SqlCommand comando = new SqlCommand(query, con.conectarbd);
            comando.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            SqlDataReader ganancia = comando.ExecuteReader();
            if (ganancia.Read())
            {
                textBox1.Text = ganancia["ganancia"].ToString();
            }
            else
            {
                con.cerrar();
            }
        }
    }
}
