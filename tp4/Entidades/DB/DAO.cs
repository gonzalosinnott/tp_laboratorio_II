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
        private static string connectionString = "Server = localhost; Database=StocK; Trusted_Connection=true";
        public bool Guardar()
        {
            return true;
        }

        public List<Part> GetAll(string table)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT Id, Pieza, Tipo,Fabricante,Fecha_Ingreso FROM {table}", con))
                {
                    List<Part> parts = new List<Part>();
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Part part = new Part();
                            switch (dataReader["Pieza"].ToString())
                            {
                                case "Tuners":
                                    part = new Tuners { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                    break;
                                case "Electronics":
                                    part = new Electronics { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                    break;
                                case "Wood":
                                    part = new Wood { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() }; 
                                    break;
                                case "Pickup":
                                    part = new Pickup { Id = Convert.ToInt32(dataReader["Id"]), Type = dataReader["Tipo"].ToString(), EntryDate = dataReader["Fecha_Ingreso"].ToString(), Manufacturer = dataReader["Fabricante"].ToString() };
                                    break;
                            }                            
                            parts.Add(part);
                        }
                    }
                    con.Close();
                    return parts;
                }
            }
        }
    }
}
