
namespace RestaurantManagmentApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Order = new System.Windows.Forms.TabPage();
            this.editFoodList = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Collection";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Order);
            this.tabControl1.Controls.Add(this.editFoodList);
            this.tabControl1.Location = new System.Drawing.Point(26, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 615);
            this.tabControl1.TabIndex = 1;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.label1);
            this.Order.Location = new System.Drawing.Point(4, 29);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(1162, 582);
            this.Order.TabIndex = 0;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // editFoodList
            // 
            this.editFoodList.Location = new System.Drawing.Point(4, 29);
            this.editFoodList.Name = "editFoodList";
            this.editFoodList.Padding = new System.Windows.Forms.Padding(3);
            this.editFoodList.Size = new System.Drawing.Size(1162, 582);
            this.editFoodList.TabIndex = 1;
            this.editFoodList.Text = "Edit Food List";
            this.editFoodList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1208, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.TabPage editFoodList;
    }
}

