using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class BoughtItem
    {
        public Item item;

        public string buyer;
        public int quantity;
        public double totalCost = 0;

        public BoughtItem(Item item, int quantity, string buyer)
        {
            this.item = item;
            this.buyer = buyer;
            this.quantity = quantity;

            this.totalCost += (this.quantity * item.price);
        }


        public double totalProfit => Math.Round(quantity * item.rawProfit, 2);
    }
}
