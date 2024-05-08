using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProject
{
    public class GlobalVar
    {
        public static string strDBConnectionString = "";//連線字串 其他的放FORM就好
        public static List<ArrayList> list訂購品項集合 = new List<ArrayList>();
        public static string 訂購人資訊 = "";
    }
}
