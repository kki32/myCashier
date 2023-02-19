using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_SAHAKORN
{
    public static class MessageLibrary
    {
        public static string IMPORT_ERROR()
        {
            return "มีปัญหาระหว่าง import\n" + CODE_ERROR_MESSAGE();
        }

        public static string EXPORT_ERROR()
        {
            return "มีปัญหาระหว่าง export\n" + CODE_ERROR_MESSAGE();
        }

        public static Message FORMAT_ERROR = new Message("Format error",
          "Format มีปัญหา",
          MessageBoxIcon.Error);

        public static Message EXPORT_STOCK_SUCCESSFUL = new Message("Successful stock export",
            "Export stock {0} เสร็จเรียบร้อยแล้ว",
            MessageBoxIcon.Information);


        public static Message EXPORT_SIGN_BOOK_SUCCESSFUL = new Message("Successful sign book export",
            "Export สมุดเซ็น {0} เสร็จเรียบร้อยแล้ว",
            MessageBoxIcon.Information);

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
