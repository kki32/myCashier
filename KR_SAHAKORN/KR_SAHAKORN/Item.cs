using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class Item
    {
        public string location;
        public string type;
        public string name;
        public int instock;
        public double price;

        public string message;

        public double profit
        {
            get
            {
                return Math.Round(price - originalPrice, 2);
            }
        }

        public static string GetOriginalCost(Item item)
        {
            return item.totalPrice + "/" + item.quantityPerPack + " = " + Math.Round(item.originalPrice, 2).ToString();
        }

        public double totalPrice;
        public int quantityPerPack;
        public double originalPrice
        {
            get
            {
                return totalPrice / quantityPerPack;
            }
        }

        public double salePrice
        {
            get
            {
                return originalPrice * 1.15;
            }
        }

        public int minInstock;
        //public double pricePerPack;
        //public int quantityPerPack;
        public List<ItemHistory> histories = new List<ItemHistory>();
 

        public Item(string location, string type, string name, double price, double totalPrice, int quantityPerPack, int instock, string message)
        {
            this.location = location;
            this.type = type;
            this.name = name;
            this.price = price;
            this.totalPrice = totalPrice;
            this.quantityPerPack = quantityPerPack;

            this.instock = instock;
            this.message = message;
        }


        public void AddItemHistory(ItemHistory history)
        {
            histories.Add(history);
        }

        public List<ItemHistory> getAllItemHistories()
        {
            return histories;
        }
    }
}
