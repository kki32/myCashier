using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class Item
    {
        public string name;
        public int instock;
        public double price;
        public string originalPrice;
        public string type;
        public int minInstock;
        public double pricePerPack;
        public int quantityPerPack;
        public List<ItemHistory> histories = new List<ItemHistory>();
 

        public Item(string name, double price, int instock, int minInstock, string type, string originalPrice = "", double pricePerPack = 0, int quantityPerPack = 0)
        {
            this.name = name;
            this.instock = instock;
            this.price = price;
            this.type = type;
            this.minInstock = minInstock;
            this.originalPrice = originalPrice;
            this.pricePerPack = pricePerPack;
            this.quantityPerPack = quantityPerPack;
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
