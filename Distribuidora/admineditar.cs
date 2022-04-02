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
    public partial class admineditar : Form
    {
        public admineditar()
        {
            InitializeComponent();
        }
        conexionbd con = new conexionbd();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            conexionbd con = new conexionbd();
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text == "" || txtTelefono.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Campo Vacio. Por favor ingrese los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.abrir();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.ToString());
                }

                SqlCommand cmd = new SqlCommand("Update users set name_user=@name_user,telefono=@telefono,password_user=@password_user where id_usuario=@id_usuario ", con.conectarbd);
                cmd.Parameters.AddWithValue("@id_usuario", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@name_user", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@password_user", txtPassword.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Editado correctamente");
                    emp.Show();
                    this.Hide();


                }
                catch (SqlException ex) { MessageBox.Show("No se pudo ejecutar " + ex.ToString()); }
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void admineditar_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();

            this.FormClosed += new FormClosedEventHandler(CerrarApp);

        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionbd con = new conexionbd();

            con.abrir();
            SqlCommand cmd = new SqlCommand("Select name_user,telefono from users where id_usuario= '" + txtID.Text + "'", con.conectarbd);
            SqlDataReader srd = cmd.ExecuteReader();
            while (srd.Read())
            {
                txtUsuario.Text = srd.GetValue(0).ToString();
                txtTelefono.Text = srd.GetValue(1).ToString();
            }
            con.cerrar();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            emp.Show();
            this.Hide();
        }
    }
}
