using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Form1 : Form
    {       
        //string image_dir = @"C:\Users\del79\OneDrive\桌面\WindowsFormsApp1學生資料查詢\圖片";
        string image_products = @"C:\Users\del79\OneDrive\桌面\我的專題\專題圖片\單點圖片";
        string image_setmeal = @"C:\Users\del79\OneDrive\桌面\我的專題\專題圖片\套餐圖片";
        List<int> ID = new List<int>();//產品編號
        List<string> Name1 = new List<string>();//產品名稱
        List<string> price = new List<string>();//價格

        public Form1()
        {
            InitializeComponent();
        }
        void 顯示圖片列表()
        {
            listView圖片.Items.Clear();//每次呼叫換就會清空

            //listView商品展示.View = View.LargeIcon;  // 大圖示列表   列表模式
            //listView商品展示.View = View.Tile;  // 橫向列表
            listView圖片.View = View.List;  // 直向列表

            image_picture.ImageSize = new Size(70, 70);//像素
                                                       //圖片模式
            listView圖片.LargeImageList = image_picture;  // 大圖 : LargeIcon、Tile
            listView圖片.SmallImageList = image_picture;  // 小圖 : List、SmallIcon
            
            for (int i = 0; i < ID.Count; i++)
            {
                
                //創立存放物品
                ListViewItem item = new ListViewItem();  // 每一個商品的物件
                // i=索引 放入迴圈 跑圖片
                item.ImageIndex = i;
                item.Text = $"{Name1[i]}";
                // item.Tag = listId[i];  // 沒用到的藏起來
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                listView圖片.Items.Add(item);
            }
            
        }
        void 讀取產品的內容(string strSQL)  //單點圖片的void
        {
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            //string strSQL1 = $"select top(1)* from Products"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            listView圖片.Items.Clear();
            while (reader.Read() == true)
            {   
                ID.Add((int)reader["productid"]);//reader=hashtable意思是沒有資料型態 所以前面要打上型態 reader 後面要打上[欄位名稱]
                Name1.Add((string)reader["productname"]);
                price.Add(reader["price"].ToString());//改型態
                string image檔名 = (string)reader["pictures"];
                string 完整圖檔路徑 = $"{image_products}\\{image檔名}";  //單點圖片的void

                Console.WriteLine($"{完整圖檔路徑}");
                 // image_products = @"C:\Users\del79\OneDrive\桌面\我的專題\專題圖片\單點圖片
                // 創建圖檔路徑存放空間 fs=所有圖片路徑 那個資料夾的位置 還不是讀檔案  system IO可以省略
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);//FileStream 建立空間 存取圖檔路徑 
                
                Image img商品圖檔 = Image.FromStream(fs);
                fs.Close();//讀完後要關機

                image_picture.Images.Add(img商品圖檔);//新增圖片
            }
            
            reader.Close();
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); //設定放連線資料庫的物件
            scsb.DataSource = @".";
            scsb.InitialCatalog = "專題";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;//連線資料庫
           
        }

        void 讀取套餐的內容(string strSQL) //套餐圖片的void
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            //string strSQL = $"select top(1)* from Products"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            listView圖片.Items.Clear();
            while (reader.Read() == true)
            {
                ID.Add((int)reader["setID"]);//reader=hashtable意思是沒有資料型態 所以前面要打上型態 reader 後面要打上[欄位名稱]
                Name1.Add((string)reader["setName"]);
                
                string image檔名 = (string)reader["pictures"];
                string 完整圖檔路徑 = $"{image_setmeal}\\{image檔名}";

                Console.WriteLine($"{完整圖檔路徑}");

                // 創建圖檔路徑存放空間 fs=所有圖片路徑 那個資料夾的位置 還不是讀檔案  system IO可以省略
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);//FileStream 建立空間 存取圖檔路徑 

                Image img商品圖檔 = Image.FromStream(fs);
                fs.Close();//讀完後要關機

                image_picture.Images.Add(img商品圖檔);//新增圖片
            }
            
            reader.Close();
            con.Close();
        }

       
        private void btn套餐_Click(object sender, EventArgs e)
        {
            
            //setmeadetail form2 = new setmeadetail();
            //form2.ShowDialog(); 
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "select * from setmeal"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫    
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;
            listView圖片.Items.Clear();
            image_picture.Images.Clear();
            ID.Clear();
            Name1.Clear();
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                
                string 照片 = (string)reader["pictures"];

                strMsg += $"{照片}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=
                count++;
                
            }
            
            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
           
            讀取套餐的內容(strSQL);
           
            顯示圖片列表();

        }

        private void listView圖片_ItemActivate(object sender, EventArgs e)
        {
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg*;.jpg;*.png";//設定檔案類型

        }

        private void btn主餐_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "select top(8)* from products where Category = '主餐'"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
            //cmd.Parameters.AddWithValue("@")
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;
            //Console.Write("listView圖片.Items.Clear()");
            listView圖片.Items.Clear();
            image_picture.Images.Clear();
            ID.Clear();
            Name1.Clear();
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                string 照片 = (string)reader["pictures"];

                strMsg += $"{照片}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=
                count++;
            }
            
            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
            讀取產品的內容(strSQL);
            顯示圖片列表();
        }

        private void btn配餐_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "select * from products where Category = '配餐'"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
            //cmd.Parameters.AddWithValue("@")
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;
            listView圖片.Items.Clear();
            image_picture.Images.Clear();
            Name1.Clear();
            ID.Clear();
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                string 照片 = (string)reader["pictures"];

                strMsg += $"{照片}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=
                count++;
            }

            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
            讀取產品的內容(strSQL);
            顯示圖片列表();
        }

        private void btn飲料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "select * from products where Category = '飲料'"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
            //cmd.Parameters.AddWithValue("@")
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;
            listView圖片.Items.Clear();
            image_picture.Images.Clear();
            Name1.Clear();
            ID.Clear();
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                string 照片 = (string)reader["pictures"];

                strMsg += $"{照片}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=
                count++;
            }

            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
            讀取產品的內容(strSQL);
            顯示圖片列表();
        }

        private void btn點心_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "select * from products where Category = '點心'"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
            //cmd.Parameters.AddWithValue("@")
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;
            listView圖片.Items.Clear();
            image_picture.Images.Clear();
            Name1.Clear();
            ID.Clear();
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                string 照片 = (string)reader["pictures"];

                strMsg += $"{照片}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=
                count++;
            }

            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
            讀取產品的內容(strSQL);
            顯示圖片列表();
        }
    }
}
