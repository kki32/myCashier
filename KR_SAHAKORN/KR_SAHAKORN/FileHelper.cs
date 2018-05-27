using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;           // MUST download JSON using NUGet package
using System.Windows.Forms;

namespace KR_SAHAKORN
{
    public static class FileHelper
    {
        public static string WriteCsv()
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            var fileName = "KR_SAHAKORN_STOCK_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".csv";
            path = path + @"..\" + fileName;
            using (var w = new StreamWriter(path, false, Encoding.UTF8))
            {
                var header = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", GlobalEnums.COLUMN_1, GlobalEnums.COLUMN_2, GlobalEnums.COLUMN_3, GlobalEnums.COLUMN_4, GlobalEnums.COLUMN_5, GlobalEnums.COLUMN_6, GlobalEnums.COLUMN_7, GlobalEnums.COLUMN_8);
                w.WriteLine(header);
                w.Flush();

                foreach (Item item in InfoManager.getStockItems())
                {
                    var line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", item.type, item.name, item.price, item.pricePerPack, item.quantityPerPack, item.instock, item.minInstock, item.originalPrice);
                    w.WriteLine(line);
                    w.Flush();
                }
            }

            return Path.GetFullPath(fileName);
        }
 
        
    }
}
