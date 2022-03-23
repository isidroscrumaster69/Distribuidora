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
    }
}
