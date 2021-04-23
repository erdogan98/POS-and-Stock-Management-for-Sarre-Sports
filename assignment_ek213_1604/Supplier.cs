using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_ek213_1604
{
   public  class Supplier
    {
        List<Items> itemsList;
        List<Customer> customerList;
        public DateTime DateandTime { get; }
        public Items anItem { get; }
        public Customer aCustomer { get; }

        private static int orderNum;

        ushort aStockLevel;
        public Supplier()
        {
            itemsList = new List<Items>();
            testData();
        }
        public Supplier(Items itemName, Customer customer)
        {
            anItem = itemName;
            aCustomer = customer;
            aStockLevel = 0;
            orderNum = 0;
            DateandTime = DateTime.Now;
        } 
        public string GetOrderInfo()
        {
            /*             null-conditional operator "?." is used to avoid System.NullReferenceException ERROR.
                            The reason of this is when Display all purchases button is clicked, program
                            returns references anItem,customerList,item && itemsList all null

             */
            //interpolated expressions to construct interpolated strings ↓
            return $"Order No:{orderNum++},| Customer: {aCustomer.GetCustomerName}, | Email: {aCustomer.GetCustomerEmail}, " +
                $"  | Order Date: {DateandTime}" + Environment.NewLine;
        }
        //recording items
        public void testData()
        {       //items

            Clothing c = new Clothing("Shorts", "Red", 30, 15m);
            c.reStock(1);
            itemsList.Add(c);

            c = new Clothing("Capris", "Blue", 32, 50m);
            c.reStock(1);
            itemsList.Add(c);

            c = new Clothing("Leggings", "White", 35, 15m);
            c.reStock(1);
            itemsList.Add(c);

            c = new Clothing("Vest", "Black", 27, 20m);
            c.reStock(1);
            itemsList.Add(c);

            new Clothing("Top", "Purple", 37, 23m);
            c.reStock(1);
            itemsList.Add(c);

            new Clothing("Jacket", "Yellow", 35, 120m);
            c.reStock(1);
            itemsList.Add(c);

            Shoe s = new Shoe("Racer", 9, 150);
            s.reStock(1);
            itemsList.Add(s);

            s = new Shoe("Stability", 10, 175m);
            s.reStock(1);
            itemsList.Add(s);

            s = new Shoe("Neutral", 11, 150m);
            s.reStock(1);
            itemsList.Add(s);

            s = new Shoe("Trail", 12, 250m);
            s.reStock(1);
            itemsList.Add(s);

            s = new Shoe("Track", 13, 350m);
            s.reStock(1);
            itemsList.Add(s);

            Accesory a = new Accesory("Bag1", 129.99m, "Small");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("Bag2", 299.99m, "Large");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("Snack1", 4.99m, "Carbs");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("Simple", 14.99m, "Watch1");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("Heart Rate", 24.99m, "Watch2");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("GPS", 34.99m, "Watch3");
            a.reStock(1);
            itemsList.Add(a);

            a = new Accesory("GPS and Heart Rate", 44.99m, "Watch4");
            a.reStock(1);
            itemsList.Add(a);

        }

        //adding items to a list 
        public void addList(Items i)
        {
            itemsList.Add(i);
        }

        public List<Items> item
        {
            get { return itemsList; }
        }

        public List<StockSystem> lowStock(int minLvl)
        {
            List<StockSystem> s = new List<StockSystem>();

            foreach (Items i in itemsList)
            {
                if (i is StockSystem)
                {
                    StockSystem ss = (StockSystem)i;
                    if (ss.StockLevel < minLvl)
                        s.Add(ss);
                }
            }

            return s;
        }
    }
}

