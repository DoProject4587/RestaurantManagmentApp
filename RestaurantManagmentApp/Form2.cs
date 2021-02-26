using System;
using System.Collections.Generic;
using System.Globalization;
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
        public MainPage MyParent { get; set; }
        public String receiptToUpdate;
        public Dictionary<String, ListViewItem> selectedFoodItemMap = new Dictionary<String, ListViewItem>();

        connection con = new connection();
        String tableNumber = "";
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
            tableNumber = newlabel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void foodListSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (IsInCollection(foodListSelector.CurrentRow.Cells[1].Value.ToString()))
            {
                foreach (ListViewItem item in selectedFood.Items)
                {

                    if (item.SubItems[1].Text == foodListSelector.CurrentRow.Cells[1].Value.ToString())
                    {
                        int quantity = Int32.Parse(item.SubItems[3].Text);
                        quantity++;

                        item.SubItems[3].Text = quantity.ToString();
                        selectedFoodItemMap[item.SubItems[0].Text].SubItems[3].Text = quantity.ToString();
                    }
                }
            }
            else
            {
                string[] row = { foodListSelector.CurrentRow.Cells[0].Value.ToString(), foodListSelector.CurrentRow.Cells[1].Value.ToString(), foodListSelector.CurrentRow.Cells[2].Value.ToString(), "1" };
                selectedFood.Items.Add(new ListViewItem(row));
                selectedFoodItemMap.Add(foodListSelector.CurrentRow.Cells[0].Value.ToString(), new ListViewItem(row));


            }
        }

        private bool IsInCollection(String foodName)
        {
            foreach (ListViewItem item in selectedFood.Items)
            {
                bool subItemEqualFlag = true;
                
                string sub1 = item.SubItems[1].Text;
                string sub2 = foodName;
                if (sub1 != sub2)
                {
                    subItemEqualFlag = false;
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

            if (selectedFood.SelectedItems.Count > 0 && foodListSelector.CurrentRow != null)
            {
              
                int quantity = Int32.Parse(selectedFood.SelectedItems[0].SubItems[3].Text);
                quantity++;


                selectedFood.SelectedItems[0].SubItems[3].Text = quantity.ToString();
                selectedFoodItemMap[selectedFood.SelectedItems[0].SubItems[0].Text].SubItems[3].Text = quantity.ToString();
            }
            else
            {
                if (selectedFood.SelectedItems.Count >0)
                {
                        int quantity = Int32.Parse(selectedFood.SelectedItems[0].SubItems[3].Text);
                    quantity++;


                    selectedFood.SelectedItems[0].SubItems[3].Text = quantity.ToString();
                    selectedFoodItemMap[selectedFood.SelectedItems[0].SubItems[0].Text].SubItems[3].Text = quantity.ToString();
                }

                if (foodListSelector.CurrentRow != null)
                {
                    if (IsInCollection(foodListSelector.CurrentRow.Cells[1].Value.ToString()))
                    {
                        foreach (ListViewItem item in selectedFood.Items)
                        {
                        
                                if(item.SubItems[1].Text == foodListSelector.CurrentRow.Cells[1].Value.ToString())
                            {
                                int quantity = Int32.Parse(item.SubItems[3].Text);
                                quantity++;

                                item.SubItems[3].Text = quantity.ToString();
                                selectedFoodItemMap[item.SubItems[0].Text].SubItems[3].Text = quantity.ToString();
                            }
                        }
                    }
                    else
                    {
                            string[] row = { foodListSelector.CurrentRow.Cells[0].Value.ToString(), foodListSelector.CurrentRow.Cells[1].Value.ToString(), foodListSelector.CurrentRow.Cells[2].Value.ToString(), "1" };
                            selectedFood.Items.Add(new ListViewItem(row));
                            selectedFoodItemMap.Add(foodListSelector.CurrentRow.Cells[0].Value.ToString(),new ListViewItem(row));


                    }
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(selectedFood.SelectedItems.Count > 0)
            {

                int quantity = Int32.Parse(selectedFood.SelectedItems[0].SubItems[3].Text);
           

                if (quantity>1) 
                {
                     quantity--;
                    selectedFood.SelectedItems[0].SubItems[3].Text = quantity.ToString();
                    selectedFoodItemMap[selectedFood.SelectedItems[0].SubItems[0].Text].SubItems[3].Text = quantity.ToString();
                }
                else
                {
                    selectedFood.Items.Remove(selectedFood.SelectedItems[0]);
                    selectedFoodItemMap.Remove(selectedFood.SelectedItems[0].SubItems[0].Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListView tempFoodOrder = new ListView();
            if (receiptToUpdate != null)
            {
                con.Open();
                string foodOrderQuery = "DELETE FROM `food_receipt_juction` WHERE `Reciept` =" + receiptToUpdate;
                MySqlDataReader foodOrderData;
                foodOrderData = con.ExecuteReader(foodOrderQuery);
                con.Close();

                con.updateOrder(selectedFood, receiptToUpdate);

                double totalPrice = 0;
                double vat = 0;
                double serviceCharge = 0;

                con.Open();
                string orderQuery = "SELECT `Vat`, `ServiceCharge` FROM `recieptlist` WHERE  `Id` = " + receiptToUpdate;
                MySqlDataReader orderData;
                orderData = con.ExecuteReader(orderQuery);

                if (orderData.HasRows)
                {

                    while (orderData.Read())
                    {

                        vat = double.Parse(orderData["Vat"].ToString(), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        serviceCharge = double.Parse(orderData["ServiceCharge"].ToString(), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                    }
                }
                con.Close();

                con.Open();
                string foodOrderQueryToReset = "SELECT `Id`, `FoodId`,`FoodName`,`Quantity`,`OederPrice`,`Reciept` FROM `food_receipt_juction` WHERE `Reciept` = '" + receiptToUpdate + "'";
                MySqlDataReader foodOrderDataToReset;
                foodOrderDataToReset = con.ExecuteReader(foodOrderQueryToReset);

                if (foodOrderDataToReset.HasRows)
                {

                    while (foodOrderDataToReset.Read())
                    {

                        String foodId = foodOrderDataToReset["foodId"].ToString();
                        String foodName = foodOrderDataToReset["FoodName"].ToString();
                        String foodQuantity = foodOrderDataToReset["Quantity"].ToString();
                        String foodPrice = foodOrderDataToReset["OederPrice"].ToString();

                        string[] row = { foodId, foodName, foodPrice, foodQuantity };
                        MyParent.foodOrderList.Items.Add(new ListViewItem(row));

                        double eachfoodQuantity = double.Parse(foodQuantity, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        double eachfoorPrice = double.Parse(foodPrice, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        double eachTotalFoodPrice = eachfoorPrice * eachfoodQuantity;

                        totalPrice += Math.Round(eachTotalFoodPrice, 2);
                    }
                    double vatPrice = totalPrice * (vat / 100);
                    double serviceChargeprice = totalPrice * (serviceCharge / 100);

                    totalPrice += vatPrice;
                    totalPrice += serviceChargeprice;

                    MyParent.totalPriceVar.Text = totalPrice.ToString();
                    con.Close();
                }
            }

            else
            {
                con.confirmOrder(tableNumber, "0", selectedFood);
                MyParent.tableList.Controls.Clear();
                MyParent.orderListView.Items.Clear();
                MyParent.historyOrderListView.Items.Clear();

                MyParent.loadTableData();
                MyParent.loadpOrderData();
                MyParent.getTableStatus();
                MyParent.loadHistoryOrder();
                MyParent.loadDashboard();
            }
            MyParent.Show();


            this.Close();

        }


        private void foodListSelector_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (selectedFood.SelectedItems.Count > 0)
            {
                selectedFood.SelectedItems[0].Selected = false;
            }
        }

        private void selectedFood_MouseClick(object sender, MouseEventArgs e)
        {
            if (foodListSelector.CurrentRow != null)
            {
                foodListSelector.CurrentRow.Selected = false;
            }
        }
    }
}
