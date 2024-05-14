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
                ID = (int)reader["MemberID"]; //add存值 = 把MEMBERID存到陣列ID裡面去            
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

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫

            if (ID > 0)
            {                
                string strSQL = "insert into Orders(MemberID) Values (@MemberID)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("MemberID", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("登入成功");
                OrderList orderList = new OrderList();
                orderList.輸出訂購單();
                GlobalVar.訂單清除();
                Close();
            }
            else
            {
                MessageBox.Show("查無此人");
            }
            con.Close();
        }
    }
}
