using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Distribuidora
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var add = new admininsertar();
            add.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var edi= new admineditar();
            edi.Show();
            this.Hide();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();

            this.FormClosed += new FormClosedEventHandler(CerrarApp);

        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var eli= new admineliminar();
            eli.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
    }

