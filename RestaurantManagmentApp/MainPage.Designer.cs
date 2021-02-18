
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
            this.foodTable = new System.Windows.Forms.DataGridView();
            this.updateMenu = new System.Windows.Forms.Button();
            this.IdInputBox = new System.Windows.Forms.TextBox();
            this.foodNameInputBox = new System.Windows.Forms.TextBox();
            this.priceInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertMenu = new System.Windows.Forms.Button();
            this.deleteMenu = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.editMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tableList);
            this.tabControl.Controls.Add(this.editMenu);
            this.tabControl.Location = new System.Drawing.Point(24, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1151, 648);
            this.tabControl.TabIndex = 0;
            // 
            // tableList
            // 
            this.tableList.Location = new System.Drawing.Point(4, 29);
            this.tableList.Name = "tableList";
            this.tableList.Padding = new System.Windows.Forms.Padding(3);
            this.tableList.Size = new System.Drawing.Size(1143, 615);
            this.tableList.TabIndex = 0;
            this.tableList.Text = "Table List";
            this.tableList.UseVisualStyleBackColor = true;
            // 
            // editMenu
            // 
            this.editMenu.Controls.Add(this.deleteMenu);
            this.editMenu.Controls.Add(this.insertMenu);
            this.editMenu.Controls.Add(this.label3);
            this.editMenu.Controls.Add(this.label2);
            this.editMenu.Controls.Add(this.label1);
            this.editMenu.Controls.Add(this.priceInputBox);
            this.editMenu.Controls.Add(this.foodNameInputBox);
            this.editMenu.Controls.Add(this.IdInputBox);
            this.editMenu.Controls.Add(this.updateMenu);
            this.editMenu.Controls.Add(this.foodTable);
            this.editMenu.Location = new System.Drawing.Point(4, 29);
            this.editMenu.Name = "editMenu";
            this.editMenu.Padding = new System.Windows.Forms.Padding(3);
            this.editMenu.Size = new System.Drawing.Size(1143, 615);
            this.editMenu.TabIndex = 1;
            this.editMenu.Text = "Edit Menu";
            this.editMenu.UseVisualStyleBackColor = true;
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
            // IdInputBox
            // 
            this.IdInputBox.Location = new System.Drawing.Point(112, 67);
            this.IdInputBox.Name = "IdInputBox";
            this.IdInputBox.Size = new System.Drawing.Size(218, 26);
            this.IdInputBox.TabIndex = 2;
            // 
            // foodNameInputBox
            // 
            this.foodNameInputBox.Location = new System.Drawing.Point(112, 167);
            this.foodNameInputBox.Name = "foodNameInputBox";
            this.foodNameInputBox.Size = new System.Drawing.Size(218, 26);
            this.foodNameInputBox.TabIndex = 3;
            // 
            // priceInputBox
            // 
            this.priceInputBox.Location = new System.Drawing.Point(112, 281);
            this.priceInputBox.Name = "priceInputBox";
            this.priceInputBox.Size = new System.Drawing.Size(218, 26);
            this.priceInputBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 672);
            this.Controls.Add(this.tabControl);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl.ResumeLayout(false);
            this.editMenu.ResumeLayout(false);
            this.editMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tableList;
        private System.Windows.Forms.TabPage editMenu;
        private System.Windows.Forms.DataGridView foodTable;
        private System.Windows.Forms.Button updateMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceInputBox;
        private System.Windows.Forms.TextBox foodNameInputBox;
        private System.Windows.Forms.TextBox IdInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteMenu;
        private System.Windows.Forms.Button insertMenu;
    }
}