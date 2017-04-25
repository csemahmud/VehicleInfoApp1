using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALClassLibrary;
using ModelClassLibrary;

namespace BLLClassLibrary
{
    static public class VehicleManager
    {   
        static public string Insert_Vehicle(string regNo, string engineNo)
        {
            if (string.IsNullOrEmpty(regNo))
                return "\n\tReg No. is mandatory .";

            if (string.IsNullOrEmpty(engineNo))
                return "\n\tEngine No. is mandatory";

            if (VehicleGateway.Check_ByRegNo(regNo))
                return string.Format(
                    "\n\tReg No. {0} already exists .\n\tEnter a unique one .",
                    regNo);

            if (VehicleGateway.Check_ByEngineNo(engineNo))
                return string.Format(
                    "\n\tEngine No. {0} already exists .\n\tEnter a unique one .",
                    engineNo);

            if (VehicleGateway.Insert_Into_Database(regNo, engineNo) >= 1)
                return string.Format(
                    "\n\tVehicle with Reg No. {0}, Engine No. {1} has been saved .",
                    regNo, engineNo);

            return "\n\tCan not save vehicle .";

        }

        static public List<Vehicle> Get_All()
        {
            return VehicleGateway.Get_All();
        }
    }
}
