using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;           // MUST download JSON using NUGet package
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;

namespace KR_SAHAKORN
{
    public static class FileHelper
    {
        public static string ExportStockCsv()
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            var fileName = "KR_SAHAKORN_STOCK_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".csv";
            path = path + @"..\" + fileName;
            using (var w = new StreamWriter(path, false, Encoding.UTF8))
            {
                var header = string.Format("{0},{1},{2},{3},{4},{5},{6}", GlobalEnums.LOCATION, GlobalEnums.TYPE, GlobalEnums.NAME, GlobalEnums.PRICE, GlobalEnums.INSTOCK,
                    GlobalEnums.ORIGINAL_COST, GlobalEnums.PROFIT);
                w.WriteLine(header);
                w.Flush();

                foreach (Item item in InfoManager.getStockItems())
                {
                    var line = string.Format("{0},{1},{2},{3},{4},{5},{6}", item.location, item.type, item.name, item.price, item.instock, Item.GetOriginalCost(item), item.profit);
                    w.WriteLine(line);
                    w.Flush();
                }
            }

            return Path.GetFullPath(fileName);
        }

        public static string ExportSignBookCsv(string buyerName, DateTime from, DateTime to)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            var fileName = "KR_SAHAKORN_SIGN_BOOK_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".csv";
            path = path + @"..\" + fileName;
            using (var w = new StreamWriter(path, false, Encoding.UTF8))
            {
                var line = string.Format("{0},{1},{2},{3},{4},{5},{6}", "Trans ID", "ของ", "วันที่", "ชื่อสินค้า", "จำนวน", "ราคาต่อหน่วย", "รวมทั้งสิ้น");

                w.WriteLine(line);
                w.Flush();
                if (buyerName == InfoManager.EVERYONE)
                {
                    foreach (string buyer in InfoManager.LoadBuyerNames())
                    {
                        WriteBuyerDetailToCsv(buyer, from, to, w);
                    }
                }
                else
                {
                    WriteBuyerDetailToCsv(buyerName, from, to, w);
                }
            }


            return Path.GetFullPath(fileName);
        }

        private static void WriteBuyerDetailToCsv(string buyerName, DateTime from, DateTime to, StreamWriter w)
        {
            foreach (Transaction trans in InfoManager.getSignTransaction(buyerName))
            {
                if (trans.date.Date >= from && trans.date.Date <= to)
                {
                    foreach (BoughtItem b in trans.bought)
                    {
                        var line = string.Format("{0},{1},{2},{3},{4},{5},{6}", trans.id, b.buyer, trans.date, b.item.name, b.quantity, b.item.price, b.totalCost);
                        w.WriteLine(line);
                        w.Flush();
                    }
                }
            }
        }

        public static List<Item> ImportStockCsv()
        {

            var records = new List<Item>();
            using (var reader = new StreamReader("ราคาสหกรณ์.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<Item>().ToList();
                }
            }

            var stocks = InfoManager.getStockItems();
            var products = stocks.Select(x => x.name);
            foreach (var record in records)
            {
                if (!products.Contains(record.name))
                    InfoManager.AddNewProduct(record);
            }

            return records;
        }
 
        
    }
}
