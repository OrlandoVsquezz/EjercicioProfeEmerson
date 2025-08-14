using Modelos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    internal class Zapato
    {

        private int idZapato;
        private int idCategoria;
        private string nombre;
        private double precio;
        private string imagenURL;
        private DateTime fechaCreacion;

        public int IdZapato { get => idZapato; set => idZapato = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string ImagenURL { get => imagenURL; set => imagenURL = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

         public static DataTable cargarzapatos()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conexion.Conectar();
                string cadena = "select *from vistaCategoria";
                SqlDataAdapter data = new SqlDataAdapter(cadena, conexion);
                DataTable tablavirtual = new DataTable();
                data.Fill(tablavirtual);
                return tablavirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos" + ex);
                return null;
            }

        }

        public bool insertarZapatos()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Insert into Zapatos (CategoriaId, Nombre, Precio, ImagenURL, FechaCreacion) values (@CategoriaId, @Nombre, @Precio, @ImagenURL, @FechaCreacion);";
                SqlCommand insertar = new SqlCommand(consultaQuery, conexion);
                insertar.Parameters.AddWithValue("@CategoriaId", idCategoria);
                insertar.Parameters.AddWithValue("@Nombre", nombre);
                insertar.Parameters.AddWithValue("@Precio", precio);
                insertar.Parameters.AddWithValue("@ImagenURL", imagenURL);
                insertar.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Verificar si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
