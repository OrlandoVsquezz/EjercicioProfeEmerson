using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.ConexionDB;

namespace Modelos
{
    internal class Usuario
    {

        private int id;
        private string nombre;
        private string email;
        private string clave;
        private int rollId;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Clave { get => clave; set => clave = value; }
        public int RollId { get => rollId; set => rollId = value; }

        public bool RegistrarUsuario()
        {

            try
            {
                SqlConnection conn = Conexion.Conectar();
                string queryhas = "INSERT INTO Usuarios (Nombre, Email,clave,RolId) VALUES (@Nombre, @Email, @clave,@RolId)";
                SqlCommand insertar = new SqlCommand(queryhas, conn);
                insertar.Parameters.AddWithValue("@Nombre", nombre);
                insertar.Parameters.AddWithValue("@Email", email);
                insertar.Parameters.AddWithValue("@clave", clave);
                insertar.Parameters.AddWithValue("@RolId", rollId);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Este Usuario ya existe , utiliza otro correo electronico");
                return false;
            }
        }

        public bool VerificarLogin(string correo, string clave)
        {
            string hashEnBaseDeDatos = "";
            SqlConnection conn = Conexion.Conectar();
            string query = "SELECT clave FROM Usuarios WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Email", correo);

            if (cmd.ExecuteScalar() == null)
            {
                return false;

            }
            else
            {
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
            }
        }
        public static DataTable cargarRoles()
        {
            SqlConnection conn = Conexion.Conectar();
            string querycargar = "select Id,Nombre from Roles;";
            SqlDataAdapter dt = new SqlDataAdapter(querycargar, conn);
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

    }
}
