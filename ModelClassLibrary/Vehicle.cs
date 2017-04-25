using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary
{
    public class Vehicle
    {
        public int DatabaseId { private set; get; }
        public string RegNo { private set; get; }
        public string EngineNo { private set; get; }

        public Vehicle(int databaseId, string regNo, string engineNo) 
            : this(databaseId, regNo)
        {
            EngineNo = engineNo;
        }

        public Vehicle()
        {
 
        }

        public Vehicle(int databaseId, string regNo) : this()
        {
            // TODO: Complete member initialization
            this.DatabaseId = databaseId;
            this.RegNo = regNo;
        }
    }
}
