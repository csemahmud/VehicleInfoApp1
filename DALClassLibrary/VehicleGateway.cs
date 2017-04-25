using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelClassLibrary;

namespace DALClassLibrary
{
    static public class VehicleGateway
    {
        static SqlConnection connection = VehicleInfoApp1Gateway.Connection;
        static SqlCommand command = VehicleInfoApp1Gateway.Command;
        
        static public bool Check_ByRegNo(string regNo)
        {
            connection.Open();
            command.CommandText = string.Format(
                "select * from Vehicle where RegNo = '{0}';", regNo);
            SqlDataReader reader = command.ExecuteReader();
            bool flag = reader.Read();
            connection.Close();
            return flag;
        }

        static public bool Check_ByEngineNo(string engineNo)
        {
            connection.Open();
            command.CommandText = string.Format(
                "select * from Vehicle where EngineNo = '{0}';",engineNo);
            SqlDataReader reader = command.ExecuteReader();
            bool flag = reader.Read();
            connection.Close();
            return flag;
        }

        static public int Insert_Into_Database(string regNo, string engineNo)
        {
            connection.Open();
            command.CommandText = string.Format(
                "insert into Vehicle values ('{0}','{1}');", regNo, engineNo);
            int returnValue = command.ExecuteNonQuery();
            connection.Close();
            return returnValue;
        }

        static public List<Vehicle> Get_All()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            connection.Open();
            command.CommandText = "select * from Vehicle";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vehicle aVehicle = new Vehicle((int)reader[0],
                    reader[1].ToString(), reader[2].ToString());
                vehicleList.Add(aVehicle);
            }
            connection.Close();
            return vehicleList;
        }
    }
}
