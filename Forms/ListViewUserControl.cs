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
    public partial class ListViewUserControl : UserControl
    {
        public ListViewUserControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem eachRow = new ListViewItem(txtID.Texts);
            ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(eachRow, txtName.Texts);

            eachRow.SubItems.Add(txtName.Texts);
            eachRow.SubItems.Add(DateTime.Now.ToString());
            listView.Items.Add(eachRow);
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID__TextChanged(object sender, EventArgs e)
        {

        }

    }
}
