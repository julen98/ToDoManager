using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Set the min and max size of sidebar
            if (sidebarExpand)
            {
                // if sidebar is expanded, minimize
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            } 
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

            
        }
        private void iconMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            calendarUserControl.Hide();
            listViewUserControl.Show();
            listViewUserControl.BringToFront();
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            listViewUserControl.Hide();
            calendarUserControl.Show();
            calendarUserControl.BringToFront();
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void calendarUserControl_Load(object sender, EventArgs e)
        {
        }
    }
}
