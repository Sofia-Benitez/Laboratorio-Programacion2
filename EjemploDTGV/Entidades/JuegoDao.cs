using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDao()
        {
            cadenaConexion = @"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True";
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE from JUEGOS WHERE codigo_juego = {codigoJuego}";
                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"insert into juegos (codigo_juego, codigo_usuario, nombre, precio, genero) " +
                    $"values (@codigoJuego, @codigoUsuario, @nombre, @precio, @genero)";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@codigoJuego", juego.CodigoJuego);
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> lista = new List<Biblioteca>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS.USERNAME as usuario FROM " +
                    $"JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO;";


                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    lista.Add(new Biblioteca(Convert.ToInt32(dataReader["codigoJuego"]), dataReader["genero"].ToString(),dataReader["juego"].ToString(),dataReader["usuario"].ToString()));
                }
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;
            try
            {
                conexion.Open();
                comando.CommandText = $"select * from juegos where codigo_juego = {codigoJuego}";
                SqlDataReader dataReader = comando.ExecuteReader();

                while(dataReader.Read())
                {
                    juego = new Juego(Convert.ToInt32(dataReader["codigo_usuario"]), dataReader["genero"].ToString(), dataReader["nombre"].ToString(), Convert.ToDouble(dataReader["precio"]),Convert.ToInt32(dataReader["codigo_juego"]));
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
            return juego;
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"update juegos set nombre = @nombre, precio = @precio, genero = @genero where codigo_juego = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            
        }
    }
}
