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
    public partial class admineliminar : Form
    {
        public admineliminar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            conexionbd con = new conexionbd();
            try
            {
                con.abrir();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
            if (MessageBox.Show("¿Desea eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete users where id_usuario=@id_usuario ", con.conectarbd);
                cmd.Parameters.AddWithValue("@id_usuario", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@name_user", txtUsuario.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado exitoso");
                    emp.Show();
                    this.Hide();


                }
                catch (SqlException ex) { MessageBox.Show("No se pudo ejecutar " + ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Usuario NO eliminado", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        conexionbd con = new conexionbd();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionbd con = new conexionbd();

            con.abrir();
            SqlCommand cmd = new SqlCommand("Select name_user,nombre from users where id_usuario= '" + txtID.Text + "'", con.conectarbd);
            SqlDataReader srd = cmd.ExecuteReader();
            while(srd.Read())
            {
                txtNombre.Text=srd.GetValue(0).ToString();
                txtUsuario.Text=srd.GetValue(1).ToString();
            }
            con.cerrar();
        }

        private void admineliminar_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();

            this.FormClosed += new FormClosedEventHandler(CerrarApp);

        }

        private void CerrarApp(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var emp = new Empleados();
            emp.Show();
            this.Hide();
        }
    }
}
