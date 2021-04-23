using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace assignment_ek213_1604
{
    public partial class POSandStockMng : Form
    {
        Supplier pos;
        private Items currentItem;
        private Customer CurrentCustomer;
        private List<Supplier> getOrderInfo = new List<Supplier>();


        private List<Customer> CustomerList = new List<Customer>()
        {
            //test
            new Customer("Daenerys Targaryen", "dannylovesdragons@gmail.com", 2500),
            new Customer("Arya Stark", "iKilledNightKing@gmail.com", 1000)
        };


        public POSandStockMng()
        {
            InitializeComponent();
            pos = new Supplier();
        }

        private void POSandStockMng_Load(object sender, EventArgs e)
        {

            FillCustomerComboBox();
            displayItems();

            CustomerComboBox.SelectedIndex = 0;
            CurrentCustomer = CustomerList[0];
            ShowCurrentCustomer();

        }
        //fill combobox customer
        private void FillCustomerComboBox()
        {
            CustomerComboBox.Items.Clear();
            foreach (Customer c in CustomerList)
            {
                CustomerComboBox.Items.Add(c.GetCustomerName);
            }
        }

        //show current customer in ui
        public void ShowCurrentCustomer()
        {
            //  TextBoxBalance.Text = CurrentCustomer.balance.ToString();
            //TextBoxLastItem.Text = CurrentCustomer.LastPurchase?.Name;
            textBoxEmail.Text = CurrentCustomer.GetCustomerEmail;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = CustomerList[CustomerComboBox.SelectedIndex];
            ShowCurrentCustomer();
        }



        //adding new customer
        private void AddNewCustomerBtn_Click(object sender, EventArgs e)
        {
            string custname = addNewCustomerTxtBox.Text;
            string email = addCustEmailTextBox.Text;
            //decimal balance = Convert.ToDecimal(NewCustBalance.Text);

            CustomerList.Add(new Customer(custname, email));

            FillCustomerComboBox();
            addNewCustomerTxtBox.Clear();
            addCustEmailTextBox.Clear();
            // NewCustBalance.Clear();
        }

        //coding the display all purchases button
        private void ButtonDisplayOrder_Click(object sender, EventArgs e)
        {

            listBoxOrders.Items.Clear();
            foreach (Supplier s in getOrderInfo)
            {
                listBoxOrders.Items.Add(s.GetOrderInfo() + " \n ");
            }

        }
        private Items selectedItems()
        {
            Items i;
            /*            selection are made by clicking to an item. after selection if another item is not selected,
                        this code assigns to the first item for selection*/
            i = pos.item[listBoxItems.SelectedIndex != -1 ? listBoxItems.SelectedIndex : 0];
            return i;
        }

        private void displayItems()
        {
            {
                listBoxItems.Items.Clear();

                foreach (Items i in pos.item)
                {
                    listBoxItems.Items.Add(i.GetItemName);

                    if (i is StockSystem)
                    {
                        listBoxItems.Items[listBoxItems.Items.Count - 1] = i.GetItemName + "\t(" + ((StockSystem)i).StockLevel + ")";

                    }

                }

            }
        }
        private void buttonSell_Click(object sender, EventArgs e)
        {


            Items i;
            Customer c;
            c = CurrentCustomer;
            i = selectedItems();

            /*                      switch statement used in order to 
                                    follow stock levels and give message when 
                                        there is no stock
                        try/catch used to stop program from crashing when there is blank textBox*/

            //listBoxItems.Items.Add(TextBoxLastItem.Text.ToString());

            try
            {
                if (i.StockLevel < (i.Sell(ushort.Parse(textBoxSellItem.Text))))
                {
                    getOrderInfo.Add(new Supplier(currentItem, CurrentCustomer));
                    MessageBox.Show("Purchase Successfull");
                }
                
                else if (((ushort.Parse(textBoxSellItem.Text))) > i.StockLevel)
                {
                    MessageBox.Show("We Don't have enough stock. Please Update our stock with ReStock Button");
                }
            }
            catch (Exception)
            {
                if (textBoxSellItem.Text == "")
                {
                    MessageBox.Show("Please Enter Number of Items You Want To Buy");
                }

            }

            displayItems();
            ShowCurrentCustomer();
            textBoxSellItem.Clear();
        }

        private void buttonReStock_Click(object sender, EventArgs e)
        {
            Items i;
            i = selectedItems();
            /*            prompting user to enter reStock number 
                            as they wish, used try/catch method to throw the exception 
                            if addNewCustomerTxtBox left blank*/
            try
            {
                i.reStock(ushort.Parse(textBoxReStock.Text));
            }
            catch (Exception)
            {
                if (addNewCustomerTxtBox.Text == "")
                {
                    MessageBox.Show("Please Enter ReStock Value");
                }

            }
            displayItems();
        }


        private void ShowLessThanButton_Click(object sender, EventArgs e)
        {
            int lowStock;
            List<StockSystem> lowstock_items;

            if (int.TryParse(TextBoxLessThan.Text, out lowStock))
            {
                LowStockList.Items.Clear();
                lowstock_items = pos.lowStock(lowStock);
                foreach (StockSystem s in lowstock_items)
                {
                    LowStockList.Items.Add(s.GetItemName + "\t(" + String.Format("{0:C}", s.Price) + ")\t");
                }
            }
            else
            {
                //display error
                MessageBox.Show("Min. Stock Number not entered properly");
            }
            TextBoxLessThan.Clear();
        }
    }
}
