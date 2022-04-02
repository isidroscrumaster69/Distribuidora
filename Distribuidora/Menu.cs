using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (conexionbd.type == "A")
            {
                btnIngreso.Visible = true;
                btnEgreso.Visible = true;
                btnReportes.Visible = true;
                btnEmpleados.Visible = true;
                
                
            }
            else if (conexionbd.type == "U")
            {
                btnIngreso.Visible = true;
                btnEgreso.Visible = true;
                btnReportes.Visible = true;
                btnEmpleados.Visible = false;
                
            }
            this.FormClosed += new FormClosedEventHandler(CerrarApp);
        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            var ingreso= new Ingresos();

            ingreso.Show();
            this.Hide();
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            var egreso = new Egresos();

            egreso.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var reportes = new Reportes();

            reportes.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var login= new Login();
            this.Close();
            login.Show();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            emp.Show();
            this.Hide();
        }
    }
}
