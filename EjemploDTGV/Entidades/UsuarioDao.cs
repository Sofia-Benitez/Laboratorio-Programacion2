using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
       
                conexion.Open();
                comando.CommandText = $"select codigo_usuario, username from usuarios;";
                

                SqlDataReader dataReader =  comando.ExecuteReader();

                while (dataReader.Read())
                {
                    listaUsuarios.Add(new Usuario(Convert.ToInt32(dataReader["codigo_usuario"]), dataReader["username"].ToString()));
                }

                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return listaUsuarios;
        }
    }
}
