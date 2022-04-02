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
      
        public Login()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        conexionbd con = new conexionbd();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            var menu = new Menu();
            
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from users inner join role on users.rol=role.roleid where name_user = @name_user and password_user = @password_user", con.conectarbd);
            cmd.Parameters.AddWithValue("@name_user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password_user", txtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string usertype = dt.Rows[0][8].ToString();
                if (usertype == "admin")
                {
                    
                    conexionbd.type = "A";
                }
                else if (usertype == "user")
                {
                   
                    conexionbd.type= "U";
                }

                MessageBox.Show("Login exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrasena incorrecto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            con.cerrar(); 



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
            conexionbd conexion = new conexionbd();
            conexion.abrir();

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

        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
