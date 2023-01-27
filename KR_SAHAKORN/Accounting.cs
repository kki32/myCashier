using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    class Accounting
    {

        public double paid;
        public double received;
        public DateTime date;
        public double gotPerDay;

        public Accounting(DateTime date, double paid, double received, double gotPerDay)
        {
            this.date = date;
            this.paid = paid;
            this.received = received;
            this.gotPerDay = gotPerDay;
        }

    }
}
