using Modelos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Categoria
    {

        private int idCategoria;
        private string nombre;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static DataTable cargarCategoria()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select Id, Nombre from Categorias";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }

    }
}
