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

namespace Forms
{
    public partial class Calendar1 : Form
    {
        int month, year;
        public Calendar1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String month2 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = month2 + " , " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i <= dayoftheweek; i++)
            {
                Calendar.UserControlBlank ucblank = new Calendar.UserControlBlank();
                Daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendar.UserControlDay ucdays = new Calendar.UserControlDay();
                ucdays.days(i);
                Daycontainer.Controls.Add(ucdays);
            }
        }

        private void Daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            Daycontainer.Controls.Clear();
            month--;
            DateTime now = DateTime.Now;
            String month2 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = month2 + " , " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i <= dayoftheweek; i++)
            {
                Calendar.UserControlBlank ucblank = new Calendar.UserControlBlank();
                Daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendar.UserControlDay ucdays = new Calendar.UserControlDay();
                ucdays.days(i);
                Daycontainer.Controls.Add(ucdays);
            }


        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            Daycontainer.Controls.Clear();
            month++;
            DateTime now = DateTime.Now;
            String month2 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = month2 + " , " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i <= dayoftheweek; i++)
            {
                Calendar.UserControlBlank ucblank = new Calendar.UserControlBlank();
                Daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendar.UserControlDay ucdays = new Calendar.UserControlDay();
                ucdays.days(i);
                Daycontainer.Controls.Add(ucdays);
            }


        }
    }
}
