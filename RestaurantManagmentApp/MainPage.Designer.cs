
namespace RestaurantManagmentApp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tableList = new System.Windows.Forms.TabPage();
            this.editMenu = new System.Windows.Forms.TabPage();
            this.deleteMenu = new System.Windows.Forms.Button();
            this.insertMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceInputBox = new System.Windows.Forms.TextBox();
            this.foodNameInputBox = new System.Windows.Forms.TextBox();
            this.updateMenu = new System.Windows.Forms.Button();
            this.foodTable = new System.Windows.Forms.DataGridView();
            this.orderList = new System.Windows.Forms.TabPage();
            this.totalPriceVar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBillButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceChargeInput = new System.Windows.Forms.TextBox();
            this.vatInput = new System.Windows.Forms.TextBox();
            this.foodOrderList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dashboard = new System.Windows.Forms.TabPage();
            this.historyOrderListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.historyFoodItem = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.foodRank = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.editMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).BeginInit();
            this.orderList.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tableList);
            this.tabControl.Controls.Add(this.dashboard);
            this.tabControl.Controls.Add(this.editMenu);
            this.tabControl.Controls.Add(this.orderList);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.Location = new System.Drawing.Point(24, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1866, 648);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tableList
            // 
            this.tableList.Location = new System.Drawing.Point(4, 29);
            this.tableList.Name = "tableList";
            this.tableList.Padding = new System.Windows.Forms.Padding(3);
            this.tableList.Size = new System.Drawing.Size(1858, 615);
            this.tableList.TabIndex = 0;
            this.tableList.Text = "Create Order";
            this.tableList.UseVisualStyleBackColor = true;
            // 
            // editMenu
            // 
            this.editMenu.Controls.Add(this.deleteMenu);
            this.editMenu.Controls.Add(this.insertMenu);
            this.editMenu.Controls.Add(this.label3);
            this.editMenu.Controls.Add(this.label2);
            this.editMenu.Controls.Add(this.priceInputBox);
            this.editMenu.Controls.Add(this.foodNameInputBox);
            this.editMenu.Controls.Add(this.updateMenu);
            this.editMenu.Controls.Add(this.foodTable);
            this.editMenu.Location = new System.Drawing.Point(4, 29);
            this.editMenu.Name = "editMenu";
            this.editMenu.Padding = new System.Windows.Forms.Padding(3);
            this.editMenu.Size = new System.Drawing.Size(1858, 615);
            this.editMenu.TabIndex = 1;
            this.editMenu.Text = "Edit Menu";
            this.editMenu.UseVisualStyleBackColor = true;
            // 
            // deleteMenu
            // 
            this.deleteMenu.Location = new System.Drawing.Point(340, 447);
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(122, 43);
            this.deleteMenu.TabIndex = 8;
            this.deleteMenu.Text = "Delete Menu";
            this.deleteMenu.UseVisualStyleBackColor = true;
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // insertMenu
            // 
            this.insertMenu.Location = new System.Drawing.Point(28, 448);
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.Size = new System.Drawing.Size(119, 42);
            this.insertMenu.TabIndex = 7;
            this.insertMenu.Text = "Insert Menu";
            this.insertMenu.UseVisualStyleBackColor = true;
            this.insertMenu.Click += new System.EventHandler(this.insertMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Name";
            // 
            // priceInputBox
            // 
            this.priceInputBox.Location = new System.Drawing.Point(156, 281);
            this.priceInputBox.Name = "priceInputBox";
            this.priceInputBox.Size = new System.Drawing.Size(218, 26);
            this.priceInputBox.TabIndex = 4;
            // 
            // foodNameInputBox
            // 
            this.foodNameInputBox.Location = new System.Drawing.Point(156, 167);
            this.foodNameInputBox.Name = "foodNameInputBox";
            this.foodNameInputBox.Size = new System.Drawing.Size(218, 26);
            this.foodNameInputBox.TabIndex = 3;
            // 
            // updateMenu
            // 
            this.updateMenu.Location = new System.Drawing.Point(185, 448);
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(122, 43);
            this.updateMenu.TabIndex = 1;
            this.updateMenu.Text = "Update Menu";
            this.updateMenu.UseVisualStyleBackColor = true;
            this.updateMenu.Click += new System.EventHandler(this.updateMenu_Click);
            // 
            // foodTable
            // 
            this.foodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodTable.Location = new System.Drawing.Point(599, 21);
            this.foodTable.Name = "foodTable";
            this.foodTable.RowHeadersWidth = 62;
            this.foodTable.RowTemplate.Height = 28;
            this.foodTable.Size = new System.Drawing.Size(505, 470);
            this.foodTable.TabIndex = 0;
            this.foodTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.foodTable_MouseClick);
            // 
            // orderList
            // 
            this.orderList.Controls.Add(this.totalPriceVar);
            this.orderList.Controls.Add(this.label6);
            this.orderList.Controls.Add(this.checkBillButton);
            this.orderList.Controls.Add(this.editOrderButton);
            this.orderList.Controls.Add(this.label5);
            this.orderList.Controls.Add(this.label4);
            this.orderList.Controls.Add(this.serviceChargeInput);
            this.orderList.Controls.Add(this.vatInput);
            this.orderList.Controls.Add(this.foodOrderList);
            this.orderList.Controls.Add(this.orderListView);
            this.orderList.Location = new System.Drawing.Point(4, 29);
            this.orderList.Name = "orderList";
            this.orderList.Padding = new System.Windows.Forms.Padding(3);
            this.orderList.Size = new System.Drawing.Size(1858, 615);
            this.orderList.TabIndex = 2;
            this.orderList.Text = "Pending Order";
            this.orderList.UseVisualStyleBackColor = true;
            // 
            // totalPriceVar
            // 
            this.totalPriceVar.AutoSize = true;
            this.totalPriceVar.Location = new System.Drawing.Point(828, 455);
            this.totalPriceVar.Name = "totalPriceVar";
            this.totalPriceVar.Size = new System.Drawing.Size(0, 20);
            this.totalPriceVar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Price";
            // 
            // checkBillButton
            // 
            this.checkBillButton.Location = new System.Drawing.Point(655, 508);
            this.checkBillButton.Name = "checkBillButton";
            this.checkBillButton.Size = new System.Drawing.Size(398, 49);
            this.checkBillButton.TabIndex = 7;
            this.checkBillButton.Text = "Check Bill";
            this.checkBillButton.UseVisualStyleBackColor = true;
            this.checkBillButton.Click += new System.EventHandler(this.checkBillButton_Click);
            // 
            // editOrderButton
            // 
            this.editOrderButton.Location = new System.Drawing.Point(655, 6);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(99, 40);
            this.editOrderButton.TabIndex = 6;
            this.editOrderButton.Text = "Edit Order";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Service Charge %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vat %";
            // 
            // serviceChargeInput
            // 
            this.serviceChargeInput.Location = new System.Drawing.Point(832, 402);
            this.serviceChargeInput.Name = "serviceChargeInput";
            this.serviceChargeInput.Size = new System.Drawing.Size(132, 26);
            this.serviceChargeInput.TabIndex = 3;
            this.serviceChargeInput.TextChanged += new System.EventHandler(this.serviceChargeInput_TextChanged);
            // 
            // vatInput
            // 
            this.vatInput.Location = new System.Drawing.Point(832, 351);
            this.vatInput.Name = "vatInput";
            this.vatInput.Size = new System.Drawing.Size(132, 26);
            this.vatInput.TabIndex = 2;
            this.vatInput.TextChanged += new System.EventHandler(this.vatInput_TextChanged);
            // 
            // foodOrderList
            // 
            this.foodOrderList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.foodOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.foodOrderList.FullRowSelect = true;
            this.foodOrderList.GridLines = true;
            this.foodOrderList.HideSelection = false;
            this.foodOrderList.Location = new System.Drawing.Point(655, 52);
            this.foodOrderList.MultiSelect = false;
            this.foodOrderList.Name = "foodOrderList";
            this.foodOrderList.Size = new System.Drawing.Size(472, 263);
            this.foodOrderList.TabIndex = 1;
            this.foodOrderList.UseCompatibleStateImageBehavior = false;
            this.foodOrderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Food Name";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Quantuty";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "Price";
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.orderListView.FullRowSelect = true;
            this.orderListView.GridLines = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(26, 33);
            this.orderListView.MultiSelect = false;
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(572, 558);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Table Number";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order Status";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date/Time";
            this.columnHeader8.Width = 150;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.label14);
            this.dashboard.Controls.Add(this.foodRank);
            this.dashboard.Controls.Add(this.label13);
            this.dashboard.Controls.Add(this.label12);
            this.dashboard.Controls.Add(this.label11);
            this.dashboard.Controls.Add(this.label10);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.label8);
            this.dashboard.Controls.Add(this.label7);
            this.dashboard.Controls.Add(this.historyFoodItem);
            this.dashboard.Controls.Add(this.historyOrderListView);
            this.dashboard.Location = new System.Drawing.Point(4, 29);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(1858, 615);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // historyOrderListView
            // 
            this.historyOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.historyOrderListView.FullRowSelect = true;
            this.historyOrderListView.GridLines = true;
            this.historyOrderListView.HideSelection = false;
            this.historyOrderListView.Location = new System.Drawing.Point(13, 72);
            this.historyOrderListView.MultiSelect = false;
            this.historyOrderListView.Name = "historyOrderListView";
            this.historyOrderListView.Size = new System.Drawing.Size(873, 520);
            this.historyOrderListView.TabIndex = 0;
            this.historyOrderListView.UseCompatibleStateImageBehavior = false;
            this.historyOrderListView.View = System.Windows.Forms.View.Details;
            this.historyOrderListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.historyOrderListView_MouseClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Receipt Id";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Table Number";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 2;
            this.columnHeader11.Text = "Status";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader12
            // 
            this.columnHeader12.DisplayIndex = 3;
            this.columnHeader12.Text = "Total Price";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Vat";
            this.columnHeader13.Width = 30;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Service Charge";
            this.columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "DateTime";
            this.columnHeader15.Width = 150;
            // 
            // historyFoodItem
            // 
            this.historyFoodItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.historyFoodItem.GridLines = true;
            this.historyFoodItem.HideSelection = false;
            this.historyFoodItem.Location = new System.Drawing.Point(913, 72);
            this.historyFoodItem.MultiSelect = false;
            this.historyFoodItem.Name = "historyFoodItem";
            this.historyFoodItem.Size = new System.Drawing.Size(388, 250);
            this.historyFoodItem.TabIndex = 1;
            this.historyFoodItem.UseCompatibleStateImageBehavior = false;
            this.historyFoodItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Food Id";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Food Name";
            this.columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Quantity";
            this.columnHeader18.Width = 50;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Price";
            this.columnHeader19.Width = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Income Today";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Paid Orders Today";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(839, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Pending Orders Today";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(754, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Bath";
            // 
            // foodRank
            // 
            this.foodRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21});
            this.foodRank.GridLines = true;
            this.foodRank.HideSelection = false;
            this.foodRank.Location = new System.Drawing.Point(913, 385);
            this.foodRank.MultiSelect = false;
            this.foodRank.Name = "foodRank";
            this.foodRank.Size = new System.Drawing.Size(287, 207);
            this.foodRank.TabIndex = 9;
            this.foodRank.UseCompatibleStateImageBehavior = false;
            this.foodRank.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Food Name";
            this.columnHeader20.Width = 100;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Number of Order";
            this.columnHeader21.Width = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(913, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Top 5 Selected";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 672);
            this.Controls.Add(this.tabControl);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl.ResumeLayout(false);
            this.editMenu.ResumeLayout(false);
            this.editMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).EndInit();
            this.orderList.ResumeLayout(false);
            this.orderList.PerformLayout();
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView foodTable;
        private System.Windows.Forms.Button updateMenu;
        private System.Windows.Forms.TextBox priceInputBox;
        private System.Windows.Forms.TextBox foodNameInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteMenu;
        private System.Windows.Forms.Button insertMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serviceChargeInput;
        private System.Windows.Forms.TextBox vatInput;
        private System.Windows.Forms.Button checkBillButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        protected internal System.Windows.Forms.TabControl tabControl;
        protected internal System.Windows.Forms.ListView foodOrderList;
        protected internal System.Windows.Forms.Label totalPriceVar;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView historyFoodItem;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView foodRank;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Label label14;
        protected internal System.Windows.Forms.TabPage tableList;
        protected internal System.Windows.Forms.TabPage editMenu;
        protected internal System.Windows.Forms.TabPage orderList;
        protected internal System.Windows.Forms.TabPage dashboard;
        protected internal System.Windows.Forms.ListView orderListView;
        protected internal System.Windows.Forms.ListView historyOrderListView;
    }
}