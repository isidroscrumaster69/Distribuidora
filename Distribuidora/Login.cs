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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MANDO-NOTEBOOK;Initial Catalog=distribuidora;Integrated Security=True";
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MANDO-NOTEBOOK;Initial Catalog=distribuidora;Integrated Security=True";
            con.Open();
            string user = txtUsername.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select name_user,password_user from users where name_user='" + txtUsername.Text + "'and password_user='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrasena incorrecto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void chkPw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPw.Checked == true)
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

            SqlConnection con = new SqlConnection("Data Source=MANDO-NOTEBOOK;Initial Catalog=distribuidora;Integrated Security=True");
            con.Open();

            {
            }

            this.FormClosed += new FormClosedEventHandler(CerrarApp);

        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contactese con el gerente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
