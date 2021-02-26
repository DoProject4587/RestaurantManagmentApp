using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace RestaurantManagmentApp
{
    class connection
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        static string host = "localhost";
        static string database = "restaurantmanagement";
        static string userDB = "TestUser";
        static string password = "root";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public void insertFoodData(String foodName, String price)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO `foodlist` (`Name`, `Price`) VALUES (@foodName, @price)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@foodName", MySqlDbType.Text).Value = foodName;
                cmd.Parameters.Add("@price", MySqlDbType.Double).Value = price;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        public void updateFoodData(String id, String foodName, String price)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = "UPDATE `foodlist` SET `Id`='" + id + "',`Name`='" + foodName + "',`Price`='" + price+ "' WHERE Id = " + int.Parse(id);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        public void deleteFoodData(String id)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = "DELETE FROM `foodlist` WHERE Id =" + int.Parse(id);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        public void confirmOrder(String tableNumber, String totalPrice, ListView selectedFood)
        {
            long receiptId = insertReceipt(tableNumber, totalPrice);

            var dataList = new List<String>();
            String orderData = "";
            foreach (ListViewItem item in selectedFood.Items)
            {
                Console.WriteLine(item);
                dataList.Add(getInitailOrderData(item, receiptId.ToString()));
            }
            Console.WriteLine(dataList.ToArray());
            orderData += String.Join(", ", dataList.ToArray());
            Console.WriteLine(orderData);
            insertFoodOrder(orderData);


        }

        public void updateOrder(ListView selectedFood, String receiptId)
        {

            var dataList = new List<String>();
            String orderData = "";
            foreach (ListViewItem item in selectedFood.Items)
            {
                Console.WriteLine(item);
                dataList.Add(getInitailOrderData(item, receiptId));
            }
            Console.WriteLine(dataList.ToArray());
            orderData += String.Join(", ", dataList.ToArray());
            insertFoodOrder(orderData);


        }

        private void insertFoodOrder(String orderData)
        {
            String sqlToCreateReceipt = "INSERT INTO `food_receipt_juction` (`FoodId`, `FoodName`, `OederPrice`, `Quantity`, Reciept) VALUES" + orderData;
            Console.WriteLine(sqlToCreateReceipt);
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = sqlToCreateReceipt;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                try
                {
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :: Insert Oeder " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        public void checkbill(String receiptId, String totalPrice, String vatPrice, String serviceChargePrice)
        {
            String sqlToUpdateReceipt = "UPDATE `recieptlist` SET `totalPrice`= "+ totalPrice + ", `Status`='Paid',`Vat`= "+ vatPrice + ",`ServiceCharge`="+ serviceChargePrice + " WHERE Id = " + receiptId;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = sqlToUpdateReceipt;
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = conn;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess Update Receipt");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :: Update Oeder " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private long insertReceipt(String tableNumber, String totalPrice)
        {
            string receiptData = getInitailTableData(tableNumber, totalPrice);
            String sqlToCreateReceipt = "INSERT INTO `recieptlist` (`totalPrice`, `tableNumber`, `Status`) VALUES" + receiptData;
            long insertedId = 0;

            Console.WriteLine(sqlToCreateReceipt);

            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.CommandText = sqlToCreateReceipt;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                try
                {
                    cmd.ExecuteNonQuery();
                    insertedId = cmd.LastInsertedId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :: Insert Rceipt " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return insertedId;
            }
        }
        private string getInitailOrderData(ListViewItem eachOrder, String receiptId)
        {

            String dataList = "";

            dataList =
                             "(" +
                             "'" +
                              eachOrder.SubItems[0].Text +
                             "'" +
                             "," +
                             "'" +
                              eachOrder.SubItems[1].Text +
                             "'" +
                             "," +
                             "'" +
                              eachOrder.SubItems[2].Text +
                             "'" +
                             "," +
                             "'" +
                              eachOrder.SubItems[3].Text +
                             "'" +
                             "," +
                             "'" +
                              receiptId +
                             "'" +
                             ")";

            return dataList;
        }

        private string getInitailTableData(String tableNumber, String totalPrice)
        {
            string data = "";
            data += "(" + "'" + totalPrice + "','" + tableNumber + "','Unpaid')";
            return data;
        }
    }
}