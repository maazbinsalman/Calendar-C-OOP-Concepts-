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
    public partial class Form1 : Form
    {
        int month, year;
        public static string static_month,static_year;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)      
        {
            daycontainer.Controls.Clear();      
            nextmonth();
            Form1Details bn = new Form1Details();
            bn.displayDays(month, year, daycontainer, lbday);
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();                                                                            
            prevmonth();
            Form1Details bp = new Form1Details();
            bp.displayDays(month, year, daycontainer, lbday);
        }

        private void Form1_Load(object sender, EventArgs e)                                                          //Displaying Date and Time on Top
        {
            Form1Details dd = new Form1Details();
            dd.displayDays(month, year, daycontainer, lbday);

            timer1.Start();
            label8.Text = DateTime.Now.ToLongTimeString();
            label9.Text = DateTime.Now.ToLongDateString();
        }

        private  void timer1_Tick(object sender, EventArgs e)                                                          //Timer for updating Time Continously
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        public void nextmonth()
        {
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
                month++;
        }

        public void prevmonth()
        {
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
                month--;
        }
    }
}
 