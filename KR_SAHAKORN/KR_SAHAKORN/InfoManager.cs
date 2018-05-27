using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;           // MUST download JSON using NUGet package


namespace KR_SAHAKORN
{
    public static class InfoManager
    {
        public const int NAME_COL = 0;
        public const int PRICE_COL = 2;
        public const int QUANTITY_COL = 1;
        public const int DATE_COL = 0;
        public const int ID_COL = 0;
        public const string DATE_FORMAT = "dd/MM/yyy";
        public const string DEFAULT_DATE_FORMAT = "MM-dd-yyy";
        public const string EVERYONE = "ทุกคน";
        public const string PASSWORD = "password";
        public const string PASSWORD_CAT = "password";
        public static bool authenticate = false;
        public static bool authenticateCashbook = false;
        public static bool authenticateSignbook = false;
        private static Dictionary<DateTime, Accounting> accounting = new Dictionary<DateTime, Accounting>();
        private static Dictionary<DateTime, Dictionary<string, List<string>>> stockIn = new Dictionary<DateTime, Dictionary<string, List<string>>>();
        private static Dictionary<string, Item> stock = new Dictionary<string, Item>();
        private static string[] buyerNames;
        private static string[] type;
        public static Dictionary<int, Transaction> cashbook = new Dictionary<int, Transaction>();
        public static Dictionary<string, List<Transaction>> signbook = new Dictionary<string, List<Transaction>>();
        public static Transaction currentTransaction;
        public static int currentTransactionId;
        public static bool stockInMode = false;

        public static void LoadCurrentRefId()
        {
            currentTransactionId = Convert.ToInt32(File.ReadAllLines("currentId.txt")[0]);
        }

        public static string[] LoadBuyerNames()
        {
            buyerNames = File.ReadAllLines("buyerName.txt");

            return buyerNames;
        }

        public static string[] LoadType()
        {
            type = File.ReadAllLines("type.txt");
            return type;
        }

        public static void LoadStock()
        {
            string json = "";

            using (StreamReader r = new StreamReader("stock.json"))
            {
                json = r.ReadToEnd();
            }

            stock = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Item>>(json);

            if(stock == null)
            {
                stock = new Dictionary<string, Item>();
            }
        }

        public static void SaveToAccounting(DateTime date, double got)
        {
            if (accounting.ContainsKey(date))
            {
                accounting[date].gotPerDay = got;
            }else
            {
                accounting.Add(date, new Accounting(date, 0, 0, got));
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(accounting);
            System.IO.File.WriteAllText("accounting.json", json, Encoding.Unicode);
        }

        public static void SaveReceivedToAccounting(DateTime date, double received)
        {
            if (accounting.ContainsKey(date))
            {
                accounting[date].received = received;
             }else
            {
                accounting.Add(date, new Accounting(date, 0, received, 0));
            }

    string json = Newtonsoft.Json.JsonConvert.SerializeObject(accounting);
            System.IO.File.WriteAllText("accounting.json", json, Encoding.Unicode);
        }

        public static void SavePaidToAccounting(DateTime date, double paid)
        {
            if (accounting.ContainsKey(date))
            {
                accounting[date].paid = paid;
            }
            else
            {
                accounting.Add(date, new Accounting(date, paid, 0, 0));
            }
        ;

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(accounting);
            System.IO.File.WriteAllText("accounting.json", json, Encoding.Unicode);
        }

        public static void SaveToSignBook(string newBuyer)
        {
            signbook.Add(newBuyer, new List<Transaction>());

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(signbook);
            System.IO.File.WriteAllText("signRecord.json", json, Encoding.Unicode);
        }

        public static void LoadSignbook()
        {
            string json = "";

            using (StreamReader r = new StreamReader("signRecord.json"))
            {
                json = r.ReadToEnd();
            }

            signbook = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, List<Transaction>>>(json);


            if (signbook == null) {
                signbook = new Dictionary<string, List<Transaction>>();
            }

            if (signbook.Count == 0)
            {
                foreach (var b in buyerNames)
                {
                    signbook.Add(b, new List<Transaction>());
                }
            }
        }


        public static double getTotalReconciliation(DateTime date)
        {
            if (accounting.ContainsKey(date))
            {
                return accounting[date].gotPerDay;
            }
            return 0;
        }

        public static double getPaid(DateTime date)
        {
            if (accounting.ContainsKey(date))
            {
                return accounting[date].paid;
            }
            return 0;
        }

        public static double getReceived(DateTime date)
        {
            if (accounting.ContainsKey(date))
            {
                return accounting[date].received;
            }
            return 0;
        }

        public static void LoadAccounting()
        {
            string json = "";

            using (StreamReader r = new StreamReader("accounting.json"))
            {
                json = r.ReadToEnd();
            }

            accounting = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<DateTime, Accounting>>(json);
            if (accounting == null)
            {
                accounting = new Dictionary<DateTime, Accounting>();
            }
        }

        public static void LoadCashbook()
        {
            string json = "";

            using (StreamReader r = new StreamReader("cashRecord.json"))
            {
                json = r.ReadToEnd();
            }

            cashbook = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, Transaction>>(json);
            if(cashbook == null)
            {
                cashbook = new Dictionary<int,Transaction>();
            }
        }



        public static void LogMessage(GlobalEnums.Severity severity, string message, string stackTrace = "")
        {
            var logMessage = "Severity :" + severity +
                   "Date :" + DateTime.Now.ToString() +
            "Message :" + message + Environment.NewLine;
            if(stackTrace != "")
            {
                logMessage += "StackTrace :" + stackTrace;
            }
                
             
                    System.IO.File.WriteAllText("log.txt", logMessage, Encoding.Unicode);
        }

        public static void AddDamagedProduct(string name, int quantity)
        {
            var item = getItem(name);
            item.instock -= quantity;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);
            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);
        }

        public static void SaveCurrentTransactionToCashbook()
        {
            object book;
            foreach (BoughtItem b in currentTransaction.bought)
            {
                //////////////////////////////
                // if name == น้ำเปล่า เล็ก แพ็ค then search for น้ำเปล่า เล็ก, get set quantity = b.quantity
                // if name == น้ำเปล่า ใหญ่่ แพ็ค 
                // if name == ขนมข้าวโพด เอ็มแอนด์เค ช็อคโกแลต (1 แพ็ค 6 ถุง)
                // if name == ขนมข้าวโพด เอ็มแอนด์เค นม (1 แพ็ค 6 ถุง)
                // if name == สแน็คแจ็ค
                // if name == โฟร์โมสต์
                //////////////////////////////
                //TODO
                if (b.item.name.Equals(GlobalEnums.COLD_WATER))
                {
                    stock[GlobalEnums.WATER].instock -= b.quantity;
                }
                else
                {
                    stock[b.item.name].instock -= b.quantity;
                }     
            }
            
            if (currentTransaction.isCash)
            {
                while(currentTransaction.id <= cashbook.Last().Value.id)
                {
                    currentTransaction.id += 1;
                    System.IO.File.WriteAllText("currentId.txt", currentTransactionId.ToString(), Encoding.Unicode);
                }

                cashbook.Add(currentTransaction.id, currentTransaction);
                book = cashbook;
            }
            else
            {
                signbook[currentTransaction.bought[0].buyer].Add(currentTransaction);
                book = signbook;
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(book);

            if (currentTransaction.isCash)
            {
                System.IO.File.WriteAllText("cashRecord.json", json, Encoding.Unicode);
            }
            else
            {
                System.IO.File.WriteAllText("signRecord.json", json, Encoding.Unicode);
            }

            json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);
            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);

            currentTransactionId += 1;
            System.IO.File.WriteAllText("currentId.txt", currentTransactionId.ToString(), Encoding.Unicode);

        }

        public static List<Transaction> getCashBook()
        {
            return cashbook.Values.ToList();
        }

        public static string[] getType()
        {
            return type;
        }

        public static void LoadStockIn()
        {
            string json = "";

            using (StreamReader r = new StreamReader("stockIn.json"))
            {
                json = r.ReadToEnd();
            }

            stockIn = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<DateTime, Dictionary<string, List<string>>>>(json);
            if (stockIn == null)
            {
                stockIn = new Dictionary<DateTime, Dictionary<string, List<string>>> ();
            }
        }
        public static void AddStockIn(DateTime date, string item, string field, string before, string after)
        {
            if (!stockIn.ContainsKey(date)) stockIn[date] = new Dictionary<string, List<string>>();
            if (!stockIn[date].ContainsKey(item)) stockIn[date][item] = new List<string>() { "", "false", "false", "false"};


            if (field.Equals("ใน stock"))
            {
                var difference = Convert.ToDouble(after) - Convert.ToDouble(before);
                if (!stockIn[date][item].First().Equals(""))
                {
                    difference += Convert.ToDouble(stockIn[date][item].First());
                }
                stockIn[date][item][0] = difference.ToString();
            }
            else if (field.Equals("ราคาต่อชิ้น"))
            {
                stockIn[date][item][1] = "true";
            } else if (field.Equals("ราคาต่อแพ็ค"))
            {
                stockIn[date][item][2] = "true";
            }
            else if (field.Equals("ราคาต้นทุน (จำนวน/แพ็ค)"))
            {
                stockIn[date][item][3] = "true";
            }

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(stockIn);
            System.IO.File.WriteAllText("stockIn.json", json, Encoding.Unicode);
        }
        public static Dictionary<string, List<string>> GetStockIn(DateTime date)
        {
            if (stockIn.ContainsKey(date))
            {
                return stockIn[date];
            }
            return null;
       
        }

        public static List<string> GetStockInForSpecificItem(DateTime date, string item)
        {
            return stockIn[date][item];
        }


        public static void AddItemHistory(string name, ItemHistory itemh)
        {
            Item item = stock[name];
            item.AddItemHistory(itemh);

            stock[name] = item;

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);
        }

        public static void setItem(string name, string newValue, string field)
        {
            Item item = stock[name];
         
            if (field.Equals("type") || field.Equals(GlobalEnums.COLUMN_1))
            {
                item.type = newValue;
            }
            else if (field.Equals("name") || field.Equals(GlobalEnums.COLUMN_2))
            {
                item.name = newValue;
                stock.Remove(name);
            }
            else if (field.Equals("price") || field.Equals(GlobalEnums.COLUMN_3))
            {
                item.price = Convert.ToDouble(newValue);
            }
            else if (field.Equals("pricePerPack") || field.Equals(GlobalEnums.COLUMN_4))
            {
                item.pricePerPack = Convert.ToDouble(newValue);
            }
            else if (field.Equals("quantityPerPack") || field.Equals(GlobalEnums.COLUMN_5))
            {
                item.quantityPerPack = Convert.ToInt32(newValue);
            }
            else if (field.Equals("instock") || field.Equals(GlobalEnums.COLUMN_6))
            {
                item.instock = Convert.ToInt32(newValue);
            }
            else if (field.Equals("minInstock") || field.Equals(GlobalEnums.COLUMN_7))
            {
                item.minInstock = Convert.ToInt32(newValue);
            }
            else if (field.Equals("originalPrice") || field.Equals(GlobalEnums.COLUMN_8))
            {
                item.originalPrice = newValue.ToString();
            }
            else
            {
                InfoManager.LogMessage(GlobalEnums.Severity.Warning, "Field does not match");
            }
    

            stock[item.name] = item;

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);
        }

        public static void setItemType(string name, string newValue)
        {
        }

        public static void setItemName(string oldValue, string newValue){
            Item item = stock[oldValue];
            item.name = newValue;
            stock.Add(newValue, item);
            stock.Remove(oldValue);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);
        }

        public static Item getItem(string name)
        {
            return stock[name];
        }

        public static bool containsItem(string name, bool checkInStock = false)
        {
            foreach(var key in getStockKeys())
            {
                if(key == name)
                {
                    if (checkInStock)
                    {
                        return stock[key].instock > 0;
                    }
                    return true;
                }
            }
            return false;
        }

        public static string[] getStockKeys()
        {
            return stock.Keys.ToArray<string>();
        }

        public static Item[] getStockItems()
        {
            return stock.Values.ToArray<Item>();
        }

        public static List<Transaction> getSignTransaction(string buyer)
        {
            return signbook[buyer];
        }

        public static DateTime getMondayOfThisWeek()
        {
            for (var day = DateTime.Today; day != DateTime.Today.AddDays(-7); day = day.AddDays(-1))
            {
                if (day.DayOfWeek == DayOfWeek.Monday)
                {
                    return day;
                }
            }
            return DateTime.Today;
        }
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public static void AddNewProduct(Item item)
        {
            stock[item.name] = item;

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);
        }

        public static void RemoveProduct(string name)
        {
            stock.Remove(name);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);

        }

        public static void RemoveCashbookEntry(int referenceNo)
        {
            foreach(BoughtItem bi in cashbook[referenceNo].bought)
            {
                stock[bi.item.name].instock += bi.quantity;
            }
            cashbook.Remove(referenceNo);
           
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(cashbook);

            System.IO.File.WriteAllText("cashRecord.json", json, Encoding.Unicode);

            json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

            System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);

        }

        public static void RemoveSignbookEntry(string buyer, int referenceNo)
        {
  

            List<Transaction> transToBeDeleted = new List<Transaction>();
            foreach(var trans in signbook[buyer])
            {
                if(trans.id.Equals(referenceNo))
                {
                    transToBeDeleted.Add(trans);
                }
            }

            if(transToBeDeleted.Count > 0)
            {
                foreach(var trans in transToBeDeleted)
                {
                    signbook[buyer].Remove(trans);
                    foreach(var bi in trans.bought)
                    {
                        stock[bi.item.name].instock += bi.quantity;
                    }
  
                }
             

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(signbook);

                System.IO.File.WriteAllText("signRecord.json", json, Encoding.Unicode);

                json = Newtonsoft.Json.JsonConvert.SerializeObject(stock);

                System.IO.File.WriteAllText("stock.json", json, Encoding.Unicode);

            }

        }




        public static void AddNewBuyer(string name)
        {                      
            System.IO.File.AppendAllText("buyerName.txt", Environment.NewLine + name, Encoding.Unicode);

            InfoManager.SaveToSignBook(name);
            InfoManager.LoadBuyerNames();
            InfoManager.LoadSignbook();
        }

      

    }
}
