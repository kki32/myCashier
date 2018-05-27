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
            CE3 = 10002
        }

        public const string COLUMN_1 = "ชนิด";
        public const string COLUMN_2 = "รายการสินค้า";
        public const string COLUMN_3 = "ราคาต่อชิ้น";
        public const string COLUMN_4 = "ราคาต่อแพ็ค";
        public const string COLUMN_5 = "ในแพ็คมี";
        public const string COLUMN_6 = "ใน stock";
        public const string COLUMN_7 = "ควรมีใน stock";
        public const string COLUMN_8 = "ราคาต้นทุน (จำนวน/แพ็ค)";
        public const string COLD_WATER = "น้ำเปล่าเย็น เล็ก";


    }
}
