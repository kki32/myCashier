using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public class GlobalEnums
    {

        public enum HistoryStyle
        {
            Add, Edit, Damaged
        }


        public enum Severity
        {
            Error, Info, Warning, Important
        }

        public enum CodeError
        {
            CE1 = 10000,
            CE2 = 10001
            
        }

    }
}
