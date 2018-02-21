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
            var q = quantity;

            while (item.quantityPerPack > 1 && q >= item.quantityPerPack)
            {
                q = q - item.quantityPerPack;
                this.totalCost += item.pricePerPack;
            }

            this.totalCost += q * item.price;
        }
    }
}
