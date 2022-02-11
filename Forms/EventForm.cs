using Calendar;
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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Texts = UserControlDay.static_day + "/" + Calendar1.static_month + "/" + Calendar1.static_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListViewUserControl listViewUserControl = new ListViewUserControl();
            listViewUserControl.addStrings(txtEvent.Texts, txtDate.Texts);

        }
    }
}
