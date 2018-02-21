using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class OtherHistory
    {
        public DateTime date;
        public string message;

        public OtherHistory(DateTime date, string message)
        {
            this.date = date;
            this.message = message;
        }
    }
}
