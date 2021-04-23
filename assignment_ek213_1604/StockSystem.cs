using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_ek213_1604
{
    public class StockSystem : Items
    {
        public DateTime DateandTime { get; }
        public Customer aCustomer { get; }
        public int OrderNum { get; }

        ushort aStockLevel;

        public StockSystem(String Name, Decimal itemPrice) : base(Name, itemPrice)
        {
            OrderNum = 0;
            aStockLevel = 0;
            DateandTime = DateTime.Now;
        }

        //restock
        public override ushort reStock(ushort quantity)
        {
            return aStockLevel += quantity;
        }


        // sell Items to the customer
        public override ushort Sell(ushort quantity)
        {
            ushort total = 0;

            if (quantity <= aStockLevel)
            {
                total = quantity;
            }
            else
            {
                total = (ushort)aStockLevel;
            }

            aStockLevel -= total;

            return total;
        }


        //follow stock level 
        public new ushort StockLevel
        {
            get { return aStockLevel; }
        }

    }

    public class Clothing : StockSystem

    {
        private int cSize;
        private String ClothingName;
        private String ClothingColour;

        public Clothing(String Name, String Colour, int Size, Decimal Price) : base(Name, Price)
        {
            ClothingName = Name;
            ClothingColour = Colour;
            cSize = Size;
        }
        public string GetClothingName
        {
            get { return ClothingName; }
        }
        public string GetClothingColour
        { get { return ClothingColour; } }

        public int GetClothingSize
        { get { return cSize; } }

    }
    public class Shoe : StockSystem
    {

        private String ShoeType;
        private Decimal ShoeSize;
        public Shoe(String Name, int aShoeSize, Decimal Price) : base(Name, Price)
        {
            ShoeType = Name;
            ShoeSize = aShoeSize;
        }

        public String GetShoetype
        {
            get { return ShoeType; }
        }

        public Decimal GetShoeSize
        {
            get { return ShoeSize; }
        }

    }

    public class Accesory : StockSystem
    {
        private String AccName;
        private int capacity;
        private int itemQuantity;
        private String accType;

        //bags
        public Accesory(String Name, Decimal Price, String type) : base(Name, Price)
        {
            AccName = Name;

        }

        public String getAccName
        {
            get { return AccName; }
        }
        
        public int getCapacity
        {
            get { return capacity; }
        }
        public int getitemQuantity
        {
            get { return itemQuantity; }
        }

        public String getaccType
        {
            get { return accType; }
        }
    }
}
