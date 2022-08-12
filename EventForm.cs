using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;



namespace AssignmentCalendar_5th_Aug
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
            
        }

        private void EventForm_Load(object sender, EventArgs e)                                                         //to display date in form when clicked
        {
            
            txday.Text = Form1.static_month + "/" + UserControlDays.static_days + "/" + Form1.static_year;
            using (StreamReader sr = new StreamReader("Event.txt"))
            {
                string line = "";
                line = sr.ReadToEnd();
                richTextBox1.Text = line;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)                                                          //saving event in .txt file
        {
            EF_details details = new EF_details();
            details.SaveEvent(txevent.Text);
            DialogResult result = MessageBox.Show("Event saved successfully!", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void dFormat()
        {
            txday.Text = Form1.static_month + "/" + UserControlDays.static_days + "/" + Form1.static_year;
        }
    }
}
