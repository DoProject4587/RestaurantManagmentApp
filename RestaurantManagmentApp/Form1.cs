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
namespace RestaurantManagmentApp
{
    public partial class Form1 : Form
    {
        connection con = new connection();
        String tableNumber;
        String foodName;
        String foodPrice;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
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
                        buttonDynamic.Location = new Point(105 * (x + 1), 45 * y);
                        buttonDynamic.Click += (s, ee) => {
                            Button clickedButton = (Button)s;
                            Form2 f2 = new Form2();
                            f2.Show();
                            f2.setLabel(clickedButton.Text);
                        };


                        this.Order.Controls.Add(buttonDynamic);

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



                con.Open();
                string foodQuery = "SELECT * FROM `foodlist`";
                MySqlDataReader foodData;
                foodData = con.ExecuteReader(foodQuery);

                if (foodData.HasRows)
                {
                    Button buttonDynamic;
                    int x = 1;
                    int y = 1;

                    while (foodData.Read())
                    {
                        foodName = foodData["Name"].ToString();
                        foodPrice = foodData["Price"].ToString();

                        buttonDynamic = new Button();
                        buttonDynamic.Text = foodName + " " + foodPrice;
                        buttonDynamic.Name = foodName;
                        buttonDynamic.Size = new Size(100, 40);
                        buttonDynamic.Location = new Point(105 * (x + 1), 45 * y);
                        /*buttonDynamic.Click += (s, ee) => {
                            Button clickedButton = (Button)s;
                            Form2 f2 = new Form2();
                            f2.Show();
                            f2.setLabel(clickedButton.Text);
                        };*/


                        this.editFoodList.Controls.Add(buttonDynamic);

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
                    MessageBox.Show("Food Data not found", "Information");
                }
                con.Close();

               
            //}
            /*catch
            {
                MessageBox.Show("Connection Error", "Information");
            }*/
        }
    }
}
