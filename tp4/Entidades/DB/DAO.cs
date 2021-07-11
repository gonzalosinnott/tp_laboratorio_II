using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class DAO : ILogs
    {
        private SqlConnection connection;
        private SqlCommand command;
        private static string connectionString = "Server = localhost; Database=Stock; Trusted_Connection=true";
        

        public List<Part> GetAllParts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT Id, Pieza, Tipo,Fabricante,Fecha_Ingreso FROM Piezas", connection))
                {
                    try
                    {
                        List<Part> parts = new List<Part>();
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Part part = new Part();
                                switch (dataReader["Pieza"].ToString())
                                {
                                    case "CLAVIJAS":
                                        part = new Tuners { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                        break;
                                    case "ELECTRONICA":
                                        part = new Electronics { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                        break;
                                    case "MADERA":
                                        part = new Wood { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                        break;
                                    case "PICKUPS":
                                        part = new Pickup { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                        break;
                                }
                                parts.Add(part);
                            }
                        }
                        return parts;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        public List<Guitar> GetAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT Serial_Number, Guitar_Type, Wood, Electronics, Pickups, Tuners, Manufacture_Date FROM Productos", connection))
                {
                    try
                    {
                        List<Guitar> parts = new List<Guitar>();
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Guitar part = new Guitar();
                                switch (dataReader["Guitar_Type"].ToString())
                                {
                                    case "LES PAUL":
                                        part = new LesPaul { Id = Convert.ToInt32(dataReader["Serial_Number"]), ClassType = dataReader["Guitar_Type"].ToString(), Wood = dataReader["Wood"].ToString(), Pickups = dataReader["Pickups"].ToString(), Tuners = dataReader["Tuners"].ToString(), Electronics = dataReader["Electronics"].ToString(), ManufactureDate = dataReader["Manufacture_Date"].ToString() };
                                        break;
                                    case "SG":
                                        part = new SG { Id = Convert.ToInt32(dataReader["Serial_Number"]), ClassType = dataReader["Guitar_Type"].ToString(), Wood = dataReader["Wood"].ToString(), Pickups = dataReader["Pickups"].ToString(), Tuners = dataReader["Tuners"].ToString(), Electronics = dataReader["Electronics"].ToString(), ManufactureDate = dataReader["Manufacture_Date"].ToString() };
                                        break;
                                    case "TELECASTER":
                                        part = new Telecaster { Id = Convert.ToInt32(dataReader["Serial_Number"]), ClassType = dataReader["Guitar_Type"].ToString(), Wood = dataReader["Wood"].ToString(), Pickups = dataReader["Pickups"].ToString(), Tuners = dataReader["Tuners"].ToString(), Electronics = dataReader["Electronics"].ToString(), ManufactureDate = dataReader["Manufacture_Date"].ToString() };
                                        break;
                                }
                                parts.Add(part);
                            }
                        }
                        return parts;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }                               
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }                    
                }
            }
        }

        public bool SaveProduct(int id, string classType, string wood, string electronics, string pickups, string Tuners, string manufactureDate)
        {
            bool retorno = false;
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Productos (Serial_Number,Guitar_Type,Wood,Electronics,Pickups,Tuners,Manufacture_Date) VALUES (@Serial_Number,@Guitar_Type,@Wood,@Electronics,@Pickups,@Tuners,@Manufacture_Date);";
                command.Parameters.AddWithValue("@Serial_Number", id);
                command.Parameters.AddWithValue("@Guitar_Type", classType);
                command.Parameters.AddWithValue("@Wood", wood);
                command.Parameters.AddWithValue("@Electronics", electronics);
                command.Parameters.AddWithValue("@Pickups", pickups);
                command.Parameters.AddWithValue("@Tuners", Tuners);
                command.Parameters.AddWithValue("@Manufacture_Date", manufactureDate);

                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }

        public bool SavePiece(int id, string classType, string type, string manufacturer, string manufactureDate)
        {
            bool retorno = false;
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Piezas (Id,Pieza,Tipo,Fabricante,Fecha_Ingreso) VALUES (@Id,@Pieza,@Tipo,@Fabricante,@Fecha_Ingreso);";
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Pieza", classType);
                command.Parameters.AddWithValue("@Tipo", type);
                command.Parameters.AddWithValue("@Fabricante", manufacturer);
                command.Parameters.AddWithValue("@Fecha_Ingreso", manufactureDate);
                
                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }

        public bool DeletePiece(int id)
        {
            bool retorno = false;
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "DELETE FROM Piezas WHERE id=@Id;";
                command.Parameters.AddWithValue("@Id", id);
                
                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }
    }
}
