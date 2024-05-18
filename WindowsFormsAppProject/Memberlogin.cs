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
    public partial class Memberlogin : Form
    {     
        int number = 0;
        int ID = 0;
        int orderid = 0;
        List<string> ProductName = new List<string>();
        List<int> Quantity = new List<int>();
        List<int> 單價 = new List<int>();
        bool is取消 = false;
        
        public Memberlogin()
        {
            InitializeComponent();
        }

        private void Memberlogin_Load(object sender, EventArgs e)
        {
            
        }
        void 查詢ID() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫
            string strSQL = "select * from members where number = @number";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@memberid", ); 錯誤示範
            cmd.Parameters.AddWithValue("@number", txt號碼.Text); //參數只帶值  memberid是欄位名稱 沒有值 所以不用代入
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                ID = ((int)reader["MemberID"]); //add存值 = 把MEMBERID存到陣列ID裡面去
                GlobalVar.ID = ID;
                GlobalVar.is登入成功 = true;
            }


            reader.Close();
            con.Close();
        }
        void 新增訂單() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推
            string strSQL = "insert into Orders values( @MemberID, @OrderTime,)";
            //"insert into Orders values(1, '1985-07-10 09:30:00', '已出貨')";
            //"insert into products values(@productname , @Inventory, @Price, @Category , @Description, @pboxPictures)";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            
            //cmd.Parameters.AddWithValue("@MemberID",);
            DateTime orderTime = new DateTime(1985, 7, 10, 9, 30, 0);
            cmd.Parameters.AddWithValue("@OrderTime", orderTime);          
                     
            
            int rows = cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            查詢ID();

            
            if (ID > 0) // 有沒有登入成功
            {
                if (GlobalVar.is查看歷史訂單 == true)
                {   // 查看歷史訂單
                    GlobalVar.islogin取消 = false;
                    MessageBox.Show("登入成功");
                    Close();
                    //Revenue revenue = new Revenue();
                    //revenue.ShowDialog();

                }
                else
                {   // 點選結帳
                    MessageBox.Show("登入成功");
                    產生訂單();
                    查詢購物車();
                    產生訂單明細();
                    MessageBox.Show("謝謝惠顧");



                    OrderList orderList = new OrderList();
                    orderList.輸出訂購單();
                    清除購物車資料();
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("查無此人");
            }
            //con.Close();
        }

        private void btn註冊會員_Click(object sender, EventArgs e)
        {
            RegisterMember memberlogin = new RegisterMember();
            memberlogin.ShowDialog();

        }

        void 產生訂單() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

            //修改為 不換圖片也不會出BUG 多了一個IF去判斷
            string strSQL = "insert into orders(MemberID) values(@MemberID); declare @ID int set @ID = scope_identity() select @ID as 產生當下訂單編號";
           
            
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@MemberID", ID);
           

            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                        //cmd = 所有資料的欄位表格 然後轉給reader

            if (reader.Read() == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
            {
                orderid =(int)reader["產生當下訂單編號"];
            }

            reader.Close();
            con.Close();
        }

        void 查詢購物車()
        {

            ProductName.Clear();
            Quantity.Clear();
            單價.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

           
            string strSQL = "select p.ProductID as 產品編號,productname as 產品名稱,p.Price as 價格,s.Quantity as 數量 from products p join shoppingcart s on　p.productid = s.productid union all select s.setID,setname,setdiscount,shoppingcart.Quantity from setmeal s join shoppingcart on s.setid = shoppingcart.setid";
            //這裡的價格 進 ORDERLIST 價格有問題 哪一個試算完的價格 因為現在進去的是折扣-5 不是真正價格


            SqlCommand cmd = new SqlCommand(strSQL, con);



            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                        //cmd = 所有資料的欄位表格 然後轉給reader

            while (reader.Read() == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
            {
                ProductName.Add((string)reader["產品名稱"]);
                Quantity.Add((int)reader["數量"]);
                單價.Add((int)reader["價格"]);

            }

            reader.Close();
            con.Close();
        }

        void 產生訂單明細()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

            //修改為 不換圖片也不會出BUG 多了一個IF去判斷
            string strSQL = "insert into OrderDetails values (@OrderID,@productid,@Productname,@price,@Quantity)";


            SqlCommand cmd = new SqlCommand(strSQL, con);
            for (int i = 0; i < GlobalVar.產品編號.Count; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OrderID", orderid);
                cmd.Parameters.AddWithValue("@productid", GlobalVar.產品編號[i]);
                cmd.Parameters.AddWithValue("@ProductName", GlobalVar.名稱[i]);
                cmd.Parameters.AddWithValue("@price", GlobalVar.價格[i]);
                cmd.Parameters.AddWithValue("@Quantity", GlobalVar.數量[i]);
                
                cmd.ExecuteNonQuery();//只執行不查詢
            }

            foreach (int a in GlobalVar.產品編號) 
            {
                Console.WriteLine($"ID:{a}");
            }

            con.Close();
            GlobalVar.產品編號.Clear();
            GlobalVar.名稱.Clear();
            GlobalVar.價格.Clear();
            GlobalVar.數量.Clear();
        }
        void 清除購物車資料() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

            //修改為 不換圖片也不會出BUG 多了一個IF去判斷
            string strSQL = "truncate table shoppingcart";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Memberlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.is登入成功 == true)
            {
                //MessageBox.Show("登入成功");
            }
            else
            {
                if (is取消 == false)
                {
                    e.Cancel = true;
                }
                //MessageBox.Show("登入失敗");

            }
            

            
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            is取消 = true;
            GlobalVar.islogin取消 = true;
            
            Close();
        }
    }//----
}
