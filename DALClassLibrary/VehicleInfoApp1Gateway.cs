using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClassLibrary
{
    static public class VehicleInfoApp1Gateway
    {
        static public SqlConnection Connection { private set; get; }
        static public SqlCommand Command { private set; get; }

        public const String SERVER = @".\MSSSERVER2008R2";
        // public const String SERVER = @".\SQLSERVER2008R2";
        // USE your own SQL Server Name here .....

        public const String DATABASE = "VehicleInfoApp1";

        static VehicleInfoApp1Gateway()
        {
            Connection = new SqlConnection(
                @"server = " + SERVER + "; database = " + DATABASE + "; " 
                + "integrated security = true;");
            Command = new SqlCommand(string.Empty,Connection);
        }
    }
}
