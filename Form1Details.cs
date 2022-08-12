using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AssignmentCalendar_5th_Aug
{
    class Form1Details : Form1
    {
        public void displayDays(int month, int year, FlowLayoutPanel flowLayoutPanel, Label lbday)                                                                                  //Display function for dates on calendar
        {
            DateTime now = DateTime.Now;                                                                            //Current Date
            month = now.Month;
            year = now.Year;

            static_month = Convert.ToString(month);
            static_year = Convert.ToString(year);

            lbday.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;                              //lbday is the label containing Month and Year                                               //First day of month

            int dayoftheweek = Convert.ToInt32(new DateTime(year, month, 1).DayOfWeek.ToString("d")) + 1;              //convert start of the month to integer and store in day of the week

            for (int i = 1; i < dayoftheweek; i++)                                                                     // blank user control
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(1000);
                flowLayoutPanel.Controls.Add(ucdays);
            }
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)                                               // blank user control
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel.Controls.Add(ucdays);
            }
        }
    }
}
