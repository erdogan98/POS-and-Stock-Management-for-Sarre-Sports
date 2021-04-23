using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_ek213_1604
{
    public class Customer
    {
        //attributes
        private String custName;
        private String custEmail;
        Decimal CustBalance;

       private bool GDPR = true; // is this General Data Protection Regulation?

        Items lastPurchasedItem;
        //constructors

        public Customer(String aName, String anEmail)
        {
            custName = aName;
            custEmail = anEmail;
        }
        public Customer(String aName, String anEmail, Decimal Balance)
        {
            custName = aName;
            custEmail = anEmail;
            lastPurchasedItem = null;
            CustBalance = Balance;
        }

        //methods and probs

        public string GetCustomerName
        {
            get { return custName; }
        }

        public string GetCustomerEmail
        {
            get { return custEmail; }
        }
        public Items LastPurchase
        {
             get {return lastPurchasedItem; }
        }
        public void deposit(Decimal quantitiy)
        {
            CustBalance += quantitiy;
        }

        public Decimal balance
        {
            get { return CustBalance; }
        }
        //purchase item 

        public bool PurchaseItem(Items purchase)
        {
            bool total = false;
            if (/*CustBalance >= purchase.Price &&*/ purchase?.StockLevel > 0)
            {
                total = true;
                CustBalance -= purchase.Price;
                lastPurchasedItem = purchase;
                purchase.Sell(1);
            }
            return total;
        }

        /* this is for decreasing the current balance of the customer. 
         It is not needed in the current assignment. Not needed in the final version *//*
        public bool dropBalance(Decimal quantity)
        {
            bool total = false;

            if (CustBalance >= quantity && quantity >= 0)
            {
                total = true;
                CustBalance -= quantity;
            }
            return total;
        }*/


    }
}
