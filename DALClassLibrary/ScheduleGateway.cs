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
    static public class ScheduleGateway
    {
        static SqlConnection connection = VehicleInfoApp1Gateway.Connection;
        static SqlCommand command = VehicleInfoApp1Gateway.Command;        
        
        static public List<string> Get_Shift()
        {
            List<string> shiftList = new List<string>();
            connection.Open();
            command.CommandText = "select * from Shift;";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                shiftList.Add(reader[0].ToString());
            }
            connection.Close();
            return shiftList;
        }

        static public bool Check_Schedule(Schedule aSchedule)
        {
            connection.Open();
            command.CommandText = string.Format(
                "select * from Schedule where VehicleId = {0} and  " + 
                "[Date] = '{1}' and Shift = '{2}';",
                aSchedule.aVehicle.DatabaseId,aSchedule.Date_S.ToString(), 
                aSchedule.Shift);
            SqlDataReader reader = command.ExecuteReader();
            bool flag = reader.Read();
            connection.Close();
            return flag;
        }

        static public int Insert_Into_Database(Schedule aSchedule)
        {
            connection.Open();
            command.CommandText = string.Format(
                "insert into Schedule values ({0},'{1}','{2}','{3}','{4}');",
                aSchedule.aVehicle.DatabaseId, aSchedule.Date_S.ToString(),
                aSchedule.Shift, aSchedule.BookedBy, aSchedule.Address);
            int returnValue = command.ExecuteNonQuery();
            connection.Close();
            return returnValue;
        }

        static public List<Schedule> Get_All(int vehicleId)
        {
            List<Schedule> scheduleList = new List<Schedule>();
            connection.Open();
            command.CommandText = string.Format(
                "select * from Schedule inner join Vehicle on " 
                + "Schedule.VehicleId = Vehicle.DatabaseId where " 
                + "Vehicle.DatabaseId = {0};", vehicleId);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vehicle aVehicle = new Vehicle((int)reader[6],
                    reader[7].ToString(), reader[8].ToString());
                Schedule aSchedule = new Schedule((int)reader[0],
                    aVehicle, Convert.ToDateTime(reader[2]),
                    reader[3].ToString(), reader[4].ToString(), 
                    reader[5].ToString());
                scheduleList.Add(aSchedule);
            }
            connection.Close();
            return scheduleList;
        }

        static public List<Schedule> Get_All()
        {
            List<Schedule> scheduleList = new List<Schedule>();
            connection.Open();
            command.CommandText = "select * from Schedule inner join Vehicle " 
                + "on Schedule.VehicleId = Vehicle.DatabaseId;";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vehicle aVehicle = new Vehicle((int)reader[6],
                    reader[7].ToString(), reader[8].ToString());
                Schedule aSchedule = new Schedule((int)reader[0],
                    aVehicle, Convert.ToDateTime(reader[2]),
                    reader[3].ToString(), reader[4].ToString(),
                    reader[5].ToString());
                scheduleList.Add(aSchedule);
            }
            connection.Close();
            return scheduleList;
        }
    }
}
