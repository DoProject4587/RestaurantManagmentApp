using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RestaurantManagmentApp
{
    public partial class Form2 : Form
    {
        connection con = new connection();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadFoodData();
        }

        public void setLabel(String newlabel)
        {
            label1.Text = newlabel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void foodListSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] row = { foodListSelector.CurrentRow.Cells[1].Value.ToString(), foodListSelector.CurrentRow.Cells[2].Value.ToString(), "1" };
            
            if(!IsInCollection(new ListViewItem(row)))
            {
                selectedFood.Items.Add(new ListViewItem(row));
            }
        }

        private bool IsInCollection(ListViewItem lvi)
        {
            foreach (ListViewItem item in selectedFood.Items)
            {
                bool subItemEqualFlag = true;
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    if (sub1 != sub2)
                    {
                        subItemEqualFlag = false;
                    }
                }
                if (subItemEqualFlag)
                    return true;
            }
            return false;
        }

        private void loadFoodData()
        {

            DataTable foodlist = new DataTable();
            con.Open();
            string tableQuery = "SELECT Id,Name,Price FROM `foodlist`";
            MySqlDataReader tableData;
            tableData = con.ExecuteReader(tableQuery);
            foodlist.Load(tableData);

            foodListSelector.DataSource = foodlist;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedFood.SelectedItems.Count >0)
            {
                    int quantity = Int32.Parse(selectedFood.SelectedItems[0].SubItems[2].Text);
                quantity++;


                selectedFood.SelectedItems[0].SubItems[2].Text = quantity.ToString();
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(selectedFood.SelectedItems.Count > 0)
            {

                int quantity = Int32.Parse(selectedFood.SelectedItems[0].SubItems[2].Text);
           

                if (quantity>1) 
                {
                     quantity--;
                    selectedFood.SelectedItems[0].SubItems[2].Text = quantity.ToString();            
                }
                else
                {
                    selectedFood.Items.Remove(selectedFood.SelectedItems[0]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
