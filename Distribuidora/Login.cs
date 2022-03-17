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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var reportes=new Reportes();

            if(txtUsername.Text=="admin" && txtPassword.Text=="admin")
            {
                reportes.Show();
            
            }
            else
            {
                MessageBox.Show("Usuario/Contrasena incorrecta","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void chkPw_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPw.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
