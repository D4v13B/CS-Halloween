using Parcial2.Back.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Xml.Linq;
using static Mysqlx.Notice.Frame.Types;

namespace Parcial2.Back
{
    public class Db
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataSet ds;

        public Db()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            con = new MySqlConnection(cadenaConexion);
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        public User AutenticarUsuario(string name, string password, string codigo)
        {
            User user = null;
            try
            {
                string sql = string.IsNullOrEmpty(codigo) ? "SELECT * FROM users WHERE name = @name AND password = @password AND isAdmin = 1" : "SELECT * FROM users WHERE name = @name AND password = @password AND code = @code";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                //Console.WriteLine(sql);

                // Agregar parámetros de forma segura
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                if (!string.IsNullOrEmpty(codigo))
                {
                    cmd.Parameters.AddWithValue("@code", codigo);
                }

                cmd.Connection.Open(); //Es como hacer un execute
                ds = new DataSet();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Procesar los datos recuperados
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        //Console.WriteLine($"ID: {row["id"]}, Nombre: {row["name"]}");
                        user = new User
                        {
                            id = Convert.ToInt32(row["id"]),
                            name = Convert.ToString(row["name"]),
                            skinPhoto = (byte[])(row["skin_photo"]),
                            skin = Convert.ToString(row["skin"]),
                            isAdmin = Convert.ToBoolean(row["isAdmin"]),
                            code = Convert.ToInt32(row["code"]),
                            active = Convert.ToInt32(row["active"]),
                            punctuation = Convert.ToInt32(row["punctuation"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }

            return user;
        }

        public bool registrarCliente(string name, string password, string codigo, string skin, byte[] photo)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO users(name, password, isAdmin, active, skin, skin_photo, code) VALUES(@name, @password, 0, 0, @skin, @skin_photo, @code)";

                // Agregar parámetros de forma segura
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@code", codigo);
                cmd.Parameters.AddWithValue("@skin", skin);
                cmd.Parameters.AddWithValue("@skin_photo", photo);

                cmd.Connection.Open(); //Es como hacer un 

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }
        }

        public List<User> LeerInvitados()
        {
            List<User> users = new List<User>();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM users WHERE isAdmin != 1";

                cmd.Connection.Open(); //Es como hacer un 
                ds = new DataSet();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Procesar los datos recuperados
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        User user = new User()
                        {
                            id = Convert.ToInt32(row["id"]),
                            name = Convert.ToString(row["name"]),
                            skinPhoto = (byte[])(row["skin_photo"]),
                            skin = Convert.ToString(row["skin"]),
                            isAdmin = Convert.ToBoolean(row["isAdmin"]),
                            code = Convert.ToInt32(row["code"]),
                            active = Convert.ToInt32(row["active"]),
                            punctuation = Convert.ToInt32(row["punctuation"])
                        };

                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }

            return users;
        }

        /**
         *Funcion para crear casitas
         */
        public bool CrearCasa(string name, int initialQuantity, string tiposDulces)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO stops(name, sweetInitialQuantity, sweetActualQuantity, sweetTypes) VALUES(@name, @quantity, @quantity, @types)";

                // Agregar parámetros de forma segura
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", initialQuantity);
                cmd.Parameters.AddWithValue("@types", tiposDulces);

                cmd.Connection.Open(); //Es como hacer un 

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }
        }
        /**
         * Leer todas las paradas de la base de datos
         */
        public List<Stop> LeerParadas()
        {
            List<Stop> stops = new List<Stop>();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM stops";

                cmd.Connection.Open(); //Es como hacer un 
                ds = new DataSet();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Procesar los datos recuperados
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Stop stop = new Stop()
                        {
                            id = row["id"] != DBNull.Value ? Convert.ToInt32(row["id"]) : 0, // Manejar DBNull
                            name = row["name"] != DBNull.Value ? Convert.ToString(row["name"]) : string.Empty, // Manejar DBNull
                            sweetInitialQuantity = row["sweetInitialQuantity"] != DBNull.Value ? Convert.ToInt32(row["sweetInitialQuantity"]) : 0, // Manejar DBNull
                            sweetActualQuantity = row["sweetActualQuantity"] != DBNull.Value ? Convert.ToInt32(row["sweetActualQuantity"]) : 0 // Manejar DBNull
                        };

                        stops.Add(stop);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }

            return stops;
        }

        public bool EliminarRegistro(int id, string tabla)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM @table WHERE id = @id"; // Consulta SQL para eliminar

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@table", tabla);

                // Abrir la conexión
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                // Ejecutar la consulta
                int filasAfectadas = cmd.ExecuteNonQuery();

                // Retornar true si se eliminó al menos una fila
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Retornar false si hubo algún error
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public bool VotarDisfraz(int punctuation, int userId)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE users SET punctuation = punctuation + @score WHERE id = @userId";

                // Agregar parámetros de forma 
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@score", punctuation);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }
        }

        public List<User> Ranking()
        {
            List<User> top = new List<User>();

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM users WHERE skin_photo IS NOT NULL AND skin_photo <> '' ORDER BY punctuation DESC LIMIT 3;";

                cmd.Connection.Open(); //Es como hacer un 
                ds = new DataSet();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Procesar los datos recuperados
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        User user = new User()
                        {
                            id = Convert.ToInt32(row["id"]),
                            name = Convert.ToString(row["name"]),
                            skinPhoto = (byte[])(row["skin_photo"]),
                            skin = Convert.ToString(row["skin"]),
                            isAdmin = Convert.ToBoolean(row["isAdmin"]),
                            code = Convert.ToInt32(row["code"]),
                            active = Convert.ToInt32(row["active"]),
                            punctuation = Convert.ToInt32(row["punctuation"])
                        };

                        top.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }

            return top;
        }

        public bool ActualizarDulces(int quantity, int casita)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE stops SET sweetActualQuantity = sweetActualQuantity+ @quantity WHERE id = @stopId";

                // Agregar parámetros de forma 
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@stopId", casita);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close(); //Cerrar conexion
                }
            }
        }
    }
}
