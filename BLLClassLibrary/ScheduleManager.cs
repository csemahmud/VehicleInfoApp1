using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALClassLibrary;
using ModelClassLibrary;

namespace BLLClassLibrary
{
    static public class ScheduleManager
    {        
        static public List<string> Get_Shift()
        {
            return ScheduleGateway.Get_Shift();
        }

        static public string Insert_Schedule(Schedule aSchedule)
        {
            if (ScheduleGateway.Check_Schedule(aSchedule))
                return "\n\tSorry, this Schedule is aleady booked ."
                    + "\n\tEnter Another one .";
            if (ScheduleGateway.Insert_Into_Database(aSchedule)>=1)
                return "\n\tYour Schedule is saved .";
            return "\n\tCan not save schedule .";
        }

        static public List<Schedule> Get_All(int vehicleId)
        {
            return ScheduleGateway.Get_All(vehicleId);
        }

        static public List<Schedule> Get_All(DateTime startTime, 
            DateTime endTime)
        {
            List<Schedule> scheduleList = ScheduleGateway.Get_All();
            List<Schedule> modifiedScheduleList = new List<Schedule>();

            foreach(Schedule aSchedule in scheduleList)
            {
                TimeSpan afterStartTime = aSchedule.Date_S - startTime;
                TimeSpan beforeEndTime = endTime - aSchedule.Date_S;
                if ((Convert.ToInt32(afterStartTime.Days) >= 0) 
                    && (Convert.ToInt32(beforeEndTime.Days) >= 0)
                    && (Convert.ToInt32(beforeEndTime.Hours) >= 0))
                {
                    modifiedScheduleList.Add(aSchedule); 
                }
            }

            return modifiedScheduleList;
        }
    }
}
