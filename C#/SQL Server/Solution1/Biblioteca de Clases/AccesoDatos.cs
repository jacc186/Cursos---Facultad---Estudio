using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca_de_Clases
{
    public static class AccesoDatos
    {
        private static SqlConnection connection;
        private static SqlCommand command;

        static AccesoDatos() 
        {
            connection = new SqlConnection(@"Server=YISUS ; Database=Proem ; Trusted_Connection=True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        static public List<Cliente> leerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {

            connection.Open();

            command.CommandText = "SELECT * FROM Clientes";
            
            SqlDataReader reader =  command.ExecuteReader();

            while(reader.Read())
            {
                clientes.Add(new Cliente( int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                    reader["apellido"].ToString(),
                    reader["direccion"].ToString(),
                    int.Parse(reader["telefono"].ToString())));
            }
            return clientes;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
            connection.Close();
            }
        }
        static public void ModificarCliente(Cliente cliente)
        {
            if(cliente.Id == 0)
            {
                AccesoDatos.InsertarCliente(cliente);
            }
            else
            {
                AccesoDatos.CargarCliente(cliente);
            }
        }

        static public void InsertarCliente(Cliente cliente)
        {
            try
            {
            connection.Open();

            command.CommandText = "INSERT INTO Clientes(nombre, apellido, direccion, telefono) " +
                "VALUES(@nombre, @apellido, @direccion, @telefono)";
            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@direccion", cliente.Direccion);
            command.Parameters.AddWithValue("@telefono", cliente.Telefono);

            command.ExecuteNonQuery();

            command.Parameters.Clear();

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CargarCliente(Cliente cliente)
        {
            try
            {

                connection.Open();

                command.CommandText = "UPDATE Clientes SET nombre = @nombre, apellido = @apellido, direccion = @direccion," +
                    " telefono = @telefono where id = @id;";

                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@id", cliente.Id);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

    }
}
