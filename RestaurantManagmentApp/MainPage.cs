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
    public partial class MainPage : Form
    {
        connection con = new connection();
        String tableNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            /*try
            {*/
            con.Open();
            string tableQuery = "SELECT * FROM `tablelist`";
            MySqlDataReader tableData;
            tableData = con.ExecuteReader(tableQuery);
            if (tableData.HasRows)
            {

                Button buttonDynamic;
                int x = 1;
                int y = 1;

                while (tableData.Read())
                {

                    //id = row["id"].ToString();
                    tableNumber = tableData["tableNumber"].ToString();

                    buttonDynamic = new Button();
                    buttonDynamic.Text = tableNumber;
                    buttonDynamic.Name = tableNumber;
                    buttonDynamic.Size = new Size(100, 40);
                    buttonDynamic.Location = new Point(25 *(x + 1), 45 * y);
                    buttonDynamic.Click += (s, ee) =>
                    {
                        Button clickedButton = (Button)s;
                        Form2 f2 = new Form2();
                        f2.Show();
                        f2.setLabel(clickedButton.Text);
                    };


                    this.tableList.Controls.Add(buttonDynamic);

                    if (x == 6)
                    {
                        x = 0;
                        y++;
                    }

                    x++;
                }
            }
            else
            {
                MessageBox.Show("Table Data not found", "Information");
            }
            con.Close();

            loadFoodData();
        }

        private void loadFoodData()
        {

            DataTable foodlist = new DataTable();
            con.Open();
            string tableQuery = "SELECT * FROM `foodlist`";
            MySqlDataReader tableData;
            tableData = con.ExecuteReader(tableQuery);
            foodlist.Load(tableData);

            foodTable.DataSource = foodlist;
            con.Close();
        }

        private void foodTable_MouseClick(object sender, MouseEventArgs e)
        {
            IdInputBox.Text = foodTable.CurrentRow.Cells[0].Value.ToString();
            foodNameInputBox.Text = foodTable.CurrentRow.Cells[1].Value.ToString();
            priceInputBox.Text = foodTable.CurrentRow.Cells[2].Value.ToString();
        }


        private void insertMenu_Click(object sender, EventArgs e)
        {
            con.insertFoodData(IdInputBox.Text, foodNameInputBox.Text, priceInputBox.Text);
            loadFoodData();

        }

        private void updateMenu_Click(object sender, EventArgs e)
        {
            con.updateFoodData(IdInputBox.Text, foodNameInputBox.Text, priceInputBox.Text);
            loadFoodData();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            con.deleteFoodData(IdInputBox.Text);
            loadFoodData();
        }
    }
}
