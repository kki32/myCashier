using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class Transaction
    {
        public List<BoughtItem> bought = new List<BoughtItem>();
        public double finalTotalCost = 0;
        public double given = 0;
        public bool isCompleted = false;
        public bool isCash = true;
        public double leftOver = 0;
        public DateTime date;
        public int id = InfoManager.currentTransactionId;

          public void AddItem(BoughtItem item)
        {
            bought.Add(item);
            finalTotalCost += item.totalCost;
        }

        public Transaction()
        {

        }

        public void setIsCash(bool isCash)
        {
            this.isCash = isCash;
        }

        public void setIsCompleted(bool isCompleted)
        {
            this.isCompleted = isCompleted;
        }

        private void updateLeftOver()
        {
            leftOver = given - finalTotalCost;
        }

    }
}
