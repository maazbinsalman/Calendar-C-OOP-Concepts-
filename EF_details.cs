using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentCalendar_5th_Aug
{
    class EF_details : EventForm
    {
        public void SaveEvent(string txevent)
        {
            using (StreamWriter sw = File.AppendText("Event.txt"))
            {
                sw.WriteLine("");
                sw.Write(UserControlDays.static_days + "/");
                sw.Write(Form1.static_month + "/");
                sw.Write(Form1.static_year + " ");
                sw.Write(" " + txevent);

            }
        }
    }
}
