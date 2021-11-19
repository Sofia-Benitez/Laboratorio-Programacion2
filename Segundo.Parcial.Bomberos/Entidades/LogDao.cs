using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogDao
    {
        private SqlCommand command;
        private SqlConnection connection;

        public LogDao()
        {
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=bomberos-db;Integrated Security=True");
        }

        public void Insertar(string log)
        {
            try
            {
                string comando = "INSERT into log (entrada, alumno) VALUES (@log, 'Sofia Benitez')";
                SqlCommand sqlCommand = new SqlCommand(comando, connection);
                sqlCommand.Parameters.AddWithValue("@log", log);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            
        }

        public string LeerLog()
        {
            try
            {
                string comando = "SELECT entrada FROM log";
                SqlCommand sqlCommand = new SqlCommand(comando, connection);
                
                connection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                StringBuilder sb = new StringBuilder();
                while(dataReader.Read())
                {
                    string log = dataReader.GetString(0);//retorna el valor de una columna especificada, 0 es la entrada prq es a unica uqe hay
                    sb.AppendLine(log);
                }

                return sb.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
