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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); //設定放連線資料庫的物件
            scsb.DataSource = @".";
            scsb.InitialCatalog = "專題";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;//連線資料庫
        }

        private void btn商品上架_Click(object sender, EventArgs e)
        {
            if (txt商品編號.Text != "" && txt商品名稱.Text != "" && txt商品類別.Text != "" && txt商品價格.Text != "" && txt商品存貨.Text != "") //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推
                string strSQL = "insert into student values(@productID ,@productname ,@Category, @Price, @Inventory );";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@productID", txt商品編號.Text);
                cmd.Parameters.AddWithValue("@productname", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@Category", txt商品類別.Text); //雙引號只需要前面那段變數名 後面路徑不需要
                cmd.Parameters.AddWithValue("@Price", txt商品價格.Text);
                cmd.Parameters.AddWithValue("@Inventory", txt商品存貨.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"資訊新增成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("新增資料失敗");
            }
        }

        private void btn商品修改_Click(object sender, EventArgs e)
        {

        }

        private void btn清除_Click(object sender, EventArgs e)
        {

        }

        private void btn資料測試_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫

            string strSQL = "select * from Products"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫    
            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
            //cmd = 所有資料的欄位表格 然後轉給reader
            string strMsg = "";
            int count = 0;

            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                string 商品編號 = (string)reader["ProductID"];
                string 商品名稱 = (string)reader["ProductName"];
                int 庫存量 = (int)reader["Inventory"];
                int 商品價格 = (int)reader["Price"];
                string 商品分類 = (string)reader["Category"];
                string 商品描述 = (string)reader[]
               

                strMsg += $"{id}{姓名}{性別}{年齡}{生日}\n";  //如果只有打=的話 就只會跑一次 因為是迴圈 要讓他一直跑 所以是+=

            }

            strMsg += "--------------------------------";
            strMsg += $"資料筆數 : {count}";
            reader.Close();
            con.Close();
            MessageBox.Show(strMsg);
        }
    }
}
