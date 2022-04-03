using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows;

namespace Distribuidora
{
    internal class conexionbd
    {

        //string cadena = "Data Source=LAPTOP-AH2SJNIQ\\SQLEXPRESS;Initial Catalog =distribuidora;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public conexionbd()
        {
            string nombre_server = Dns.GetHostName();
            conectarbd.ConnectionString = "Data Source = "+nombre_server+"\\SQLEXPRESS; Initial Catalog = distribuidora; Integrated Security = True"; 
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
