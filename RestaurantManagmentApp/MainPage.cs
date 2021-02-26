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
    public partial class MainPage : Form
    {
        connection con = new connection();
        double totalFoodPrice;
        String receiptId;
        String selectedTableNumber;
        Dictionary<String, ListViewItem> selectedFoodItemMap = new Dictionary<String, ListViewItem>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            loadTableData();
            loadFoodData();
            loadpOrderData();
            getTableStatus();
            loadHistoryOrder();
            loadDashboard();
        }

        public void loadDashboard()
        {
            int pendingOrder = 0;
            int paidOrder = 0;
            double totalIncome = 0;

            con.Open();
            string historyOrderQuery = "SELECT `Id`,`tableNumber`,`totalPrice`,`Status`,`Vat`,`ServiceCharge`,`DateTime` FROM `recieptlist`WHERE DATE(`DateTime`) = CURDATE()";
            MySqlDataReader historyOrderData;
            historyOrderData = con.ExecuteReader(historyOrderQuery);

            if (historyOrderData.HasRows)
            {

                while (historyOrderData.Read())
                {

                    if (historyOrderData["Status"].ToString() == "Paid"){
                        totalIncome += double.Parse(historyOrderData["totalPrice"].ToString(), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        paidOrder++;
                    }
                    else if (historyOrderData["Status"].ToString() == "Unpaid")
                    {
                        pendingOrder++;
                    }

                }

            }
            con.Close();

            this.label10.Text = Math.Round(totalIncome,2).ToString();
            this.label11.Text = paidOrder.ToString();
            this.label12.Text = pendingOrder.ToString();

            int maxRank = 5;
            int i = 1;
            foodRank.Items.Clear();
            con.Open();
            string rankFoodQuery = "SELECT `FoodName`,COUNT(*) as fq FROM `food_receipt_juction`  WHERE DATE(`DateTime`) = CURDATE()  GROUP BY `FoodId` ORDER BY fq DESC";
            MySqlDataReader rankFood;
            rankFood = con.ExecuteReader(rankFoodQuery);

            if (rankFood.HasRows)
            {

                while (rankFood.Read())
                {

                    if(i <= maxRank)
                    {
                        string[] row = { rankFood["FoodName"].ToString(), rankFood["fq"].ToString()};
                        foodRank.Items.Add(new ListViewItem(row));
                        i++;
                    }
                    else
                    {
                        break;
                    }

                }

            }
            con.Close();
        }

        public void loadTableData()
        {
            DataTable table = new DataTable();
            String tableNumber;
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
                    buttonDynamic.Size = new Size(100, 60);
                    buttonDynamic.Location = new Point(110 * (x + 1) - 90, 70 * y);
                    buttonDynamic.Click += (s, ee) =>
                    {
                        Button clickedButton = (Button)s;
                        Form2 f2 = new Form2();
                        f2.Show();
                        f2.MyParent = this;
                        f2.setLabel(clickedButton.Text);
                        this.Hide();
                    };


                    this.tableList.Controls.Add(buttonDynamic);

                    if (x == 4)
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
        }
        public void loadFoodData()
        {

            DataTable foodlist = new DataTable();
            con.Open();
            string tableQuery = "SELECT `Id`,`Name`,`Price` FROM `foodlist`";
            MySqlDataReader tableData;
            tableData = con.ExecuteReader(tableQuery);
            foodlist.Load(tableData);

            foodTable.DataSource = foodlist;
            con.Close();
        }

        public void loadpOrderData()
        {

            con.Open();
            string orderQuery = "SELECT `Id`,`tableNumber`,`Status`, `Vat`, `ServiceCharge`,`DateTime` FROM `recieptlist` WHERE `Status` = 'Unpaid'";
            MySqlDataReader orderData;
            orderData = con.ExecuteReader(orderQuery);

            if (orderData.HasRows)
            {

                while (orderData.Read())
                {
                    string[] row = { orderData["Id"].ToString(), orderData["tableNumber"].ToString(), orderData["Status"].ToString(), orderData["DateTime"].ToString() };
                    orderListView.Items.Add(new ListViewItem(row));
                }
            }
            con.Close();
        }

        private void foodTable_MouseClick(object sender, MouseEventArgs e)
        {
            foodNameInputBox.Text = foodTable.CurrentRow.Cells[1].Value.ToString();
            priceInputBox.Text = foodTable.CurrentRow.Cells[2].Value.ToString();
        }


        private void insertMenu_Click(object sender, EventArgs e)
        {
            con.insertFoodData(foodNameInputBox.Text, priceInputBox.Text);
            loadFoodData();

        }

        private void updateMenu_Click(object sender, EventArgs e)
        {
            con.updateFoodData(foodTable.CurrentRow.Cells[0].Value.ToString(), foodNameInputBox.Text, priceInputBox.Text);
            loadFoodData();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            con.deleteFoodData(foodTable.CurrentRow.Cells[0].Value.ToString());
            foodNameInputBox.Text = "";
            priceInputBox.Text = "";
            loadFoodData();
        }

        public void getTableStatus()
        {
            Dictionary<String, Button> tableListStringMap = new Dictionary<String, Button>();
            foreach (Button eachButton in this.tableList.Controls)
            {
                tableListStringMap.Add(eachButton.Text, eachButton);
            }

            con.Open();
            string receiptQuery = "SELECT * FROM `recieptlist` WHERE Status = 'Unpaid'";
            MySqlDataReader receiptData;
            receiptData = con.ExecuteReader(receiptQuery);
            if (receiptData.HasRows)
            {
                while (receiptData.Read())
                {
                    if (tableListStringMap.ContainsKey( receiptData["tableNumber"].ToString()))
                    {
                        tableListStringMap[receiptData["tableNumber"].ToString()].BackColor = Color.Red;
                        tableListStringMap[receiptData["tableNumber"].ToString()].Enabled = false;
                        this.tableList.Controls.Add(tableListStringMap[receiptData["tableNumber"].ToString()]);
                    }
                }

            }
            con.Close();

            foreach (Button eachBuuton in tableList.Controls)
            {
                Console.WriteLine(eachBuuton.Text);
            }
        }

        private void orderListView_MouseClick(object sender, MouseEventArgs e)
        {
            this.foodOrderList.Items.Clear();
            double vat = 0;
            double serviceCharge = 0;
            receiptId = orderListView.SelectedItems[0].SubItems[0].Text;
            selectedTableNumber = orderListView.SelectedItems[0].SubItems[1].Text;
            con.Open();
            string orderQuery = "SELECT `Vat`, `ServiceCharge` FROM `recieptlist` WHERE `Status` = 'Unpaid' AND `Id` = " + receiptId;
            MySqlDataReader orderData;
            orderData = con.ExecuteReader(orderQuery);

            if (orderData.HasRows)
            {

                while (orderData.Read())
                {

                    this.vatInput.Text = orderData["Vat"].ToString();
                    this.serviceChargeInput.Text = orderData["ServiceCharge"].ToString();

                    vat = double.Parse(orderData["Vat"].ToString(), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                    serviceCharge = double.Parse(orderData["ServiceCharge"].ToString(), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
            }
            con.Close();

            double totalPrice = 0;

            if (this.orderListView.SelectedItems.Count == 1)
            {
               
                con.Open();
                string foodOrderQuery = "SELECT `Id`, `FoodId`,`FoodName`,`Quantity`,`OederPrice`,`Reciept` FROM `food_receipt_juction` WHERE `Reciept` = '"+receiptId+"'";
                MySqlDataReader foodOrderData;
                foodOrderData = con.ExecuteReader(foodOrderQuery);
                selectedFoodItemMap = new Dictionary<String, ListViewItem>();

                if (foodOrderData.HasRows)
                {

                    while (foodOrderData.Read())
                    {

                        String foodId = foodOrderData["foodId"].ToString();
                        String foodName = foodOrderData["FoodName"].ToString();
                        String foodQuantity = foodOrderData["Quantity"].ToString();
                        String foodPrice = foodOrderData["OederPrice"].ToString();
                        Console.WriteLine(foodPrice);

                        string[] row = { foodId, foodName, foodPrice, foodQuantity};
                        this.foodOrderList.Items.Add(new ListViewItem(row));
                        selectedFoodItemMap.Add(foodOrderData["foodId"].ToString(), new ListViewItem(row));

                        double eachfoodQuantity = double.Parse(foodQuantity, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        double eachfoorPrice = double.Parse(foodPrice, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        double eachTotalFoodPrice = eachfoorPrice * eachfoodQuantity;

                        totalPrice += Math.Round(eachTotalFoodPrice, 2);
                        totalFoodPrice += Math.Round(eachfoorPrice, 2);
                    }
                    double vatPrice = totalPrice * (vat / 100);
                    double serviceChargeprice = totalPrice * (serviceCharge / 100);

                    totalPrice += vatPrice;
                    totalPrice += serviceChargeprice;

                    this.totalPriceVar.Text = totalPrice.ToString();
                }
                con.Close();
            }
        }

        public void loadHistoryOrder()
        {
            con.Open();
                string historyOrderQuery = "SELECT `Id`,`tableNumber`,`totalPrice`,`Status`,`Vat`,`ServiceCharge`,`DateTime` FROM `recieptlist` WHERE `Status` = 'Paid'";
                MySqlDataReader historyOrderData;
            historyOrderData = con.ExecuteReader(historyOrderQuery);

                if (historyOrderData.HasRows)
                {

                    while (historyOrderData.Read())
                    {

                        String receipt = historyOrderData["Id"].ToString();
                        String tableNumber = historyOrderData["tableNumber"].ToString();
                        String totalPrice = historyOrderData["totalPrice"].ToString();
                        String Status = historyOrderData["Status"].ToString();
                        String Vat = historyOrderData["Vat"].ToString();
                        String ServiceCharge = historyOrderData["ServiceCharge"].ToString();
                        String DateTime = historyOrderData["DateTime"].ToString();

                    string[] row = { receipt, tableNumber, totalPrice, Status , Vat, ServiceCharge, DateTime};
                        this.historyOrderListView.Items.Add(new ListViewItem(row));
                        
                    }
                  
                }
                con.Close();
        }

        private void vatInput_TextChanged(object sender, EventArgs e)
        {

            if ((vatInput.Text != null && vatInput.Text != "") && (serviceChargeInput.Text != null && serviceChargeInput.Text != "") )
            {

                double vat = double.Parse(vatInput.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                double serviceCharge = double.Parse(serviceChargeInput.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                double serviceChargeprice = totalFoodPrice * (serviceCharge / 100);
                double vatPrice = totalFoodPrice * (vat / 100);

                double newTotalPrice = totalFoodPrice + vatPrice + serviceChargeprice;
                this.totalPriceVar.Text = Math.Round(newTotalPrice, 2).ToString();
            }

        }

        private void serviceChargeInput_TextChanged(object sender, EventArgs e)
        {
            if ((vatInput.Text != null && vatInput.Text != "") && (serviceChargeInput.Text != null && serviceChargeInput.Text != ""))
            {
                double vat = double.Parse(vatInput.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                double serviceCharge = double.Parse(serviceChargeInput.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                double serviceChargeprice = totalFoodPrice * (serviceCharge / 100);
                double vatPrice = totalFoodPrice * (vat / 100);

                double newTotalPrice =  totalFoodPrice + serviceChargeprice + vatPrice;


                this.totalPriceVar.Text = Math.Round(newTotalPrice, 2).ToString();
            }




        }

        private void checkBillButton_Click(object sender, EventArgs e)
        {
            con.checkbill(receiptId, this.totalPriceVar.Text , vatInput.Text, serviceChargeInput.Text);
            orderListView.SelectedItems[0].Remove() ;
            this.foodOrderList.Items.Clear();
            this.historyOrderListView.Items.Clear();

            foreach (Button eachButton in this.tableList.Controls)
            {
                if (eachButton.Text == selectedTableNumber)
                {
                    eachButton.BackColor = Color.Transparent;
                    eachButton.Enabled = true;
                }
            }

            loadHistoryOrder();
            loadDashboard();
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if(orderListView.SelectedItems.Count == 1)
            {

                Form2 f2 = new Form2();
                f2.Show();
                f2.setLabel(selectedTableNumber);

                ListViewItem itemClone;
                foreach (ListViewItem eachRistView in this.foodOrderList.Items)
                {
                    itemClone = eachRistView.Clone() as ListViewItem;
                    this.foodOrderList.Items.Remove(eachRistView);
                    f2.selectedFood.Items.Add(eachRistView);
                    f2.MyParent = this;
                    f2.receiptToUpdate = receiptId;
                    f2.selectedFoodItemMap = selectedFoodItemMap;
                    this.Hide();
                }
            }
           
        }

        private void historyOrderListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (historyOrderListView.SelectedItems.Count > 0)
            {
                String historyReceiptId = historyOrderListView.SelectedItems[0].SubItems[0].Text;
                this.historyFoodItem.Items.Clear();

                con.Open();
                string historyFoodOrderQuery = "SELECT `FoodId`,`FoodName`,`Quantity`,`OederPrice` FROM `food_receipt_juction` WHERE `Reciept` = " + historyReceiptId;
                MySqlDataReader historyFoodOrderData;
                historyFoodOrderData = con.ExecuteReader(historyFoodOrderQuery);

                if (historyFoodOrderData.HasRows)
                {

                    while (historyFoodOrderData.Read())
                    {

                        String foodId = historyFoodOrderData["FoodId"].ToString();
                        String foodName = historyFoodOrderData["FoodName"].ToString();
                        String Quantity = historyFoodOrderData["Quantity"].ToString();
                        String OrderPrice = historyFoodOrderData["OederPrice"].ToString();

                        string[] row = { foodId, foodName, Quantity, OrderPrice };
                        this.historyFoodItem.Items.Add(new ListViewItem(row));

                    }

                }
                con.Close();
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            loadDashboard();
        }
    }
}
