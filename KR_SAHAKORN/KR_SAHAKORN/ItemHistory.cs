using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class ItemHistory
    {
        public DateTime date;
        public string before;
        public string after;
        public string field;
        public GlobalEnums.HistoryStyle style;

        public ItemHistory(DateTime date, string before, string after, string field, GlobalEnums.HistoryStyle style)
        {
            this.date = date;
            this.before = before;
            this.after = after;
            this.field = field;
            this.style = style;
        }

   

    }
}
