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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void chkPW2_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPw.Checked == true)
            {
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void lblcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
        conexionbd con = new conexionbd();
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtNombre.Text=="" || txtApellido.Text=="" || txtPassword.Text=="" || txtPassword2.Text=="" || txtTelefono.Text==""|| txtUsername.Text=="")
            {
                MessageBox.Show("Campo Vacio. Por favor ingrese los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexionbd con = new conexionbd();
                try
                {
                    con.abrir();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.ToString());
                }

                string query = "insert into users(nombre,apellido,name_user,telefono,password_user,rol) values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUsername.Text + "','" + txtTelefono.Text + "','" + txtPassword.Text + "','" + 2 + "')";

                SqlCommand cmd = new SqlCommand(query, con.conectarbd);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registrado correctamente");
                    login.Show();
                    this.Hide();

                }
                catch (SqlException ex) { MessageBox.Show("No se pudo ejecutar " + ex.ToString()); }
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarApp);
        }
        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
