using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.ConexionDB
{
    public class Conexion
    {
        private static string servidor = "Orlando\\SQLEXPRESS";
        private static string dbdata = "Zapatos20250273";

        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data Source = {servidor}; Initial Catalog = {dbdata}; Integrated Security = true;";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor" + ex,"Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
