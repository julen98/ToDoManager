using Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDay : UserControl
    {
        public static string static_day;
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        public void days(int numday)
        {
            label1.Text = numday + "";
        }
    }
}
