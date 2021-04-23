using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_ek213_1604
{
    public class Items
    {
        private String itemName;
        private Decimal itemPrice;
        private ushort aStockLevel;
        public Items(String Name, Decimal Price)
        {
            itemName = Name;
            itemPrice = Price;
        }

        public String GetItemName
        {
         get { return itemName; }
            set { itemName = value; }
        }

        public  Decimal Price
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public virtual ushort Sell(ushort item)
        {
            return item;
        }

        public virtual ushort reStock(ushort item)
        {
            return item;
        }

        public ushort StockLevel
        {
            get { return aStockLevel; }
        }

        /*
         this could be used if there was any task related to buy items with money
         *//*
        public ushort PurchaseItem(ushort num)
        {
            ushort total;

            if (num <= aStockLevel)
            {
               aStockLevel -= num;
                total = num;
            }
            else
            {
                total = aStockLevel;
            }

            return total;
        }*/

    }
}
