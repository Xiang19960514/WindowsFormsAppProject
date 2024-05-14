using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WindowsFormsAppProject
{
    public class GlobalVar
    {
        public static string image_dir = @"C:\Users\del79\OneDrive\桌面\我的專題\轉檔圖片\轉檔後單點";
        public static string image_setmeal = @"C:\Users\del79\OneDrive\桌面\我的專題\轉檔圖片\轉檔後套餐";
        public static int 商品ID;
        public static int 內容各別顯示;
        public static string strDBConnectionString = "";//連線字串 其他的放FORM就好
        // public static List<ArrayList> list訂購品項集合 = new List<ArrayList>();
        // public static string 訂購人資訊 = "";

        public static void 訂單清除() 
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "delete shoppingcart"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();


        }
    }

}
