namespace assignment_ek213_1604
{
    partial class POSandStockMng
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCustEmailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addNewCustomerTxtBox = new System.Windows.Forms.TextBox();
            this.AddNewCustomerBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.ButtonDisplayOrder = new System.Windows.Forms.Button();
            this.LowStockList = new System.Windows.Forms.ListBox();
            this.ShowLessThanButton = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonReStock = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxReStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSellItem = new System.Windows.Forms.TextBox();
            this.TextBoxLessThan = new System.Windows.Forms.TextBox();
            this.Items = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.addCustEmailTextBox);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.addNewCustomerTxtBox);
            this.groupBox6.Controls.Add(this.AddNewCustomerBtn);
            this.groupBox6.Location = new System.Drawing.Point(210, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 240);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add New Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // addCustEmailTextBox
            // 
            this.addCustEmailTextBox.Location = new System.Drawing.Point(9, 94);
            this.addCustEmailTextBox.Name = "addCustEmailTextBox";
            this.addCustEmailTextBox.Size = new System.Drawing.Size(263, 20);
            this.addCustEmailTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name";
            // 
            // addNewCustomerTxtBox
            // 
            this.addNewCustomerTxtBox.Location = new System.Drawing.Point(9, 41);
            this.addNewCustomerTxtBox.Name = "addNewCustomerTxtBox";
            this.addNewCustomerTxtBox.Size = new System.Drawing.Size(263, 20);
            this.addNewCustomerTxtBox.TabIndex = 1;
            // 
            // AddNewCustomerBtn
            // 
            this.AddNewCustomerBtn.Location = new System.Drawing.Point(89, 174);
            this.AddNewCustomerBtn.Name = "AddNewCustomerBtn";
            this.AddNewCustomerBtn.Size = new System.Drawing.Size(100, 53);
            this.AddNewCustomerBtn.TabIndex = 0;
            this.AddNewCustomerBtn.Text = "Add New Customer";
            this.AddNewCustomerBtn.UseVisualStyleBackColor = true;
            this.AddNewCustomerBtn.Click += new System.EventHandler(this.AddNewCustomerBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxOrders);
            this.groupBox4.Controls.Add(this.ButtonDisplayOrder);
            this.groupBox4.Location = new System.Drawing.Point(561, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(663, 649);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of All Purchases By Customers";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(5, 14);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(653, 589);
            this.listBoxOrders.TabIndex = 17;
            // 
            // ButtonDisplayOrder
            // 
            this.ButtonDisplayOrder.Location = new System.Drawing.Point(4, 605);
            this.ButtonDisplayOrder.Name = "ButtonDisplayOrder";
            this.ButtonDisplayOrder.Size = new System.Drawing.Size(169, 33);
            this.ButtonDisplayOrder.TabIndex = 16;
            this.ButtonDisplayOrder.Text = "Display All Purchases";
            this.ButtonDisplayOrder.UseVisualStyleBackColor = true;
            this.ButtonDisplayOrder.Click += new System.EventHandler(this.ButtonDisplayOrder_Click);
            // 
            // LowStockList
            // 
            this.LowStockList.FormattingEnabled = true;
            this.LowStockList.Location = new System.Drawing.Point(211, 20);
            this.LowStockList.Margin = new System.Windows.Forms.Padding(2);
            this.LowStockList.Name = "LowStockList";
            this.LowStockList.Size = new System.Drawing.Size(209, 303);
            this.LowStockList.TabIndex = 29;
            // 
            // ShowLessThanButton
            // 
            this.ShowLessThanButton.Location = new System.Drawing.Point(211, 322);
            this.ShowLessThanButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowLessThanButton.Name = "ShowLessThanButton";
            this.ShowLessThanButton.Size = new System.Drawing.Size(170, 42);
            this.ShowLessThanButton.TabIndex = 27;
            this.ShowLessThanButton.Text = "Show Items Requiring Stock Less Than ➜";
            this.ShowLessThanButton.UseVisualStyleBackColor = true;
            this.ShowLessThanButton.Click += new System.EventHandler(this.ShowLessThanButton_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(5, 20);
            this.listBoxItems.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(189, 303);
            this.listBoxItems.TabIndex = 26;
            // 
            // buttonReStock
            // 
            this.buttonReStock.Location = new System.Drawing.Point(5, 328);
            this.buttonReStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReStock.Name = "buttonReStock";
            this.buttonReStock.Size = new System.Drawing.Size(63, 43);
            this.buttonReStock.TabIndex = 25;
            this.buttonReStock.Text = "ReStock Item";
            this.buttonReStock.UseVisualStyleBackColor = true;
            this.buttonReStock.Click += new System.EventHandler(this.buttonReStock_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(4, 200);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(117, 27);
            this.buttonSell.TabIndex = 24;
            this.buttonSell.Text = "Sell Item to Customer";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxReStock
            // 
            this.textBoxReStock.Location = new System.Drawing.Point(72, 334);
            this.textBoxReStock.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReStock.Multiline = true;
            this.textBoxReStock.Name = "textBoxReStock";
            this.textBoxReStock.Size = new System.Drawing.Size(47, 37);
            this.textBoxReStock.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(4, 35);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(178, 21);
            this.CustomerComboBox.TabIndex = 5;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSellItem);
            this.groupBox1.Controls.Add(this.CustomerComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSell);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(194, 240);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(4, 94);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(178, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Select Number of Items as You Wish";
            // 
            // textBoxSellItem
            // 
            this.textBoxSellItem.Location = new System.Drawing.Point(0, 174);
            this.textBoxSellItem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSellItem.Name = "textBoxSellItem";
            this.textBoxSellItem.Size = new System.Drawing.Size(181, 20);
            this.textBoxSellItem.TabIndex = 31;
            // 
            // TextBoxLessThan
            // 
            this.TextBoxLessThan.Location = new System.Drawing.Point(385, 328);
            this.TextBoxLessThan.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxLessThan.Multiline = true;
            this.TextBoxLessThan.Name = "TextBoxLessThan";
            this.TextBoxLessThan.Size = new System.Drawing.Size(39, 34);
            this.TextBoxLessThan.TabIndex = 28;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.LowStockList);
            this.Items.Controls.Add(this.TextBoxLessThan);
            this.Items.Controls.Add(this.listBoxItems);
            this.Items.Controls.Add(this.ShowLessThanButton);
            this.Items.Controls.Add(this.textBoxReStock);
            this.Items.Controls.Add(this.buttonReStock);
            this.Items.Location = new System.Drawing.Point(2, 272);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(438, 377);
            this.Items.TabIndex = 31;
            this.Items.TabStop = false;
            this.Items.Text = "Items";
            // 
            // POSandStockMng
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1463, 705);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "POSandStockMng";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Stock Management and Point of Sale System. ";
            this.Load += new System.EventHandler(this.POSandStockMng_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addCustEmailTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addNewCustomerTxtBox;
        private System.Windows.Forms.Button AddNewCustomerBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonDisplayOrder;
        private System.Windows.Forms.ListBox LowStockList;
        private System.Windows.Forms.Button ShowLessThanButton;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonReStock;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxReStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSellItem;
        private System.Windows.Forms.TextBox TextBoxLessThan;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Items;
        private System.Windows.Forms.ListBox listBoxOrders;
    }
}