using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static List<int> 產品編號 = new List<int>();
        public static List<string> 名稱 = new List<string>();
        public static int ID = 0;
        public static List<int> 價格 = new List<int>();
        public static List<int> 數量 = new List<int>();
        public static bool is查看歷史訂單 = true;//true=查看歷史訂單 false=結帳
        public static bool is登入成功 = false;
        public static bool islogin取消 = false;
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
