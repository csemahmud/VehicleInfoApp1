using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary
{
    public class Schedule
    {
        private Vehicle avehicle;

        public int DatabaseId { private set; get; }
        public Vehicle aVehicle { private set; get; }
        public DateTime Date_S { private set; get; }
        public string Shift { private set; get; }
        public string BookedBy { private set; get; }
        public string Address { private set; get; }
        public string VehicleRegNo { private set; get; }

        public Schedule(int databaseId, Vehicle avehicle, DateTime date_S,
            string shift, string bookedBy, string address) : this(avehicle,date_S,
            shift,bookedBy,address)
        {
            DatabaseId = databaseId;
        }

        public Schedule(Vehicle avehicle, DateTime date_S, string shift, string bookedBy, string address)
            : this()
        {
            // TODO: Complete member initialization
            this.aVehicle = avehicle;
            string dateStr = date_S.Month.ToString();
            dateStr += "/";
            dateStr += date_S.Day.ToString();
            dateStr += "/";
            dateStr += date_S.Year.ToString();
            dateStr += " 00:00:00";
            this.Date_S = Convert.ToDateTime(dateStr);
            this.Shift = shift;
            this.BookedBy = bookedBy;
            this.Address = address;
            this.VehicleRegNo = aVehicle.RegNo;
        }

        public Schedule()
        {
            // TODO: Complete member initialization
        }
    }
}
