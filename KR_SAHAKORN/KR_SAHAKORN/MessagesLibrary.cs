using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SAHAKORN
{
    public static class MessageLibrary
    {
        //TODO make more better logging
        public static string CHANGE_PRICE(double oldVal, double newVal)
        {
            return "Change price from " + oldVal + "to " + newVal;
        }

        public static string CHANGE_INCOME(double oldVal, double newVal)
        {
            return "Change price from " + oldVal + "to " + newVal;
        }

        public static string EDIT_ITEM(string date, string field, string before, string after)
        {
            return string.Format(date + " เปลี่ยน " + field + " จาก " + before + " เป็น " + after + Environment.NewLine);
        }

        public static string ADD_ITEM(string date)
        {
            return date + " สินค้าได้ถูกสร้างขึ้น";
        }

        public static string DAMAGED_ITEM(string date, string reason, string before, string after)
        {
            return date + " สินค้าเสียเพราะว่า " + reason + " เลยลดจำนวนใน stock จาก " + before + " ไป " + after;
        }

        public static string CODE_ERROR_TITLE(GlobalEnums.CodeError ce)
        {
            return "Code Error: " + ce;
        }

        public static string CODE_ERROR_MESSAGE()
        {
            return "ติดต่อพลอยและให้ Code Error";
        }
    }
}
