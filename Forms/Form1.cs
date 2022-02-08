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


        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        }

        private void lblhora_Click(object sender, EventArgs e)
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
    }
}
