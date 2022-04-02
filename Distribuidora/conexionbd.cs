using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Distribuidora
{
    internal class conexionbd
    {
        string cadena = "Data Source=DESKTOP-32488B5\\SQLEXPRESS;Initial Catalog =distribuidora;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public conexionbd()
        {
            conectarbd.ConnectionString = cadena; 
        }
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Abierta");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR al abrir la BD " + ex.Message);
            }
        }
        public static string type;

        public void cerrar()
        {
            conectarbd.Close();
        }


    }
}
