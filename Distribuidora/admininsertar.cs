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
    public partial class admininsertar : Form
    {
        public admininsertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var emp=new Empleados();

            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNombre.Text == "" || txtApellido.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "")
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

                string query = "insert into users(nombre,apellido,name_user,telefono,password_user,rol) values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUsuario.Text + "','" + txtTelefono.Text + "','" + txtPassword.Text + "','" + 2 + "')";

                SqlCommand cmd = new SqlCommand(query, con.conectarbd);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registrado correctamente");
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
            if (checkBox1.Checked == true)
            {
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void admininsertar_Load(object sender, EventArgs e)
        {

            conexionbd conexion = new conexionbd();
            conexion.abrir();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            emp.Show();
            this.Hide();
        }
    }
}
