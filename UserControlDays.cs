using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCalendar_5th_Aug
{
    public partial class UserControlDays : UserControl                      //using inheritance of the inbuilt usercontrol function


    {
        public static string static_days;
        public UserControlDays()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            if (numday == 1000)
            {
                lbdays.Enabled = false;
            }
            else
            {
                lbdays.Enabled = true;
                lbdays.Text = numday + "";
            }
        }
        private void lbdays_Click(object sender, EventArgs e)
        {
            static_days = lbdays.Text;
            EventForm eventform = new EventForm();
            eventform.Show();
        }
    }
}
