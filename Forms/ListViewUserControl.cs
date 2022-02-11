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
        public int id = 1;
        public ListViewItem eachRow;
        public ListViewUserControl()
        {
            InitializeComponent();
            ListViewUserControl.colorListViewHeader(ref listView, BackColor, ForeColor);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eachRow = new ListViewItem(id++.ToString());
            eachRow.SubItems.Add(txtName.Texts);
            eachRow.SubItems.Add(DateTime.Now.ToString());
            listView.Items.Add(eachRow);
            txtName.Texts = null;
            
        }

        public void addStrings(string name, string date)
        {
            eachRow = new ListViewItem(id++.ToString());
            eachRow.SubItems.Add(name);
            eachRow.SubItems.Add(date);
            listView.Items.Add(eachRow);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID__TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
