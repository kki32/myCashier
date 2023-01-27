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
            CE2 = 10001,
            CE3 = 10002,
            CE4 = 10003
        }


        public const string TYPE = "ชนิด";
        public const string NAME = "รายการสินค้า";
        public const string PRICE = "ราคาต่อชิ้น";
        //public const string COLUMN_4 = "กำไรต่อชิ้น";
        public const string PROFIT = "กำไรต่อชิ้น";
        public const string COLUMN_6 = "ในแพ็คมี";
        public const string ORIGINAL_COST = "ราคาต้นทุน";
        public const string INSTOCK = "ใน stock";
        public const string LOCATION = "ที่ซื้อ";


        public const string COLD_WATER = "น้ำเปล่าเย็น เล็ก";
        public const string WATER = "น้ำเปล่า เล็ก (28/2/61)";


    }
}
