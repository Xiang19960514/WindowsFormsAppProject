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
    public partial class SalesRevenue : Form
    {
        List<int> 數量 = new List<int>();
        List<int> 價格 = new List<int>();
        int 營業額 = 0;
        public SalesRevenue()
        {
            InitializeComponent();
        }

        private void SalesRevenue_Load(object sender, EventArgs e)
        {
            
            購物車資料讀取();
        }
        public void 購物車資料讀取()
        {
            營業額 = 0;
            數量.Clear();
            價格.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSql = "select * from orders join members on orders.memberid = members.memberid join orderdetails on orders.orderid = orderdetails.orderid order by ordertime";
            SqlCommand cmd = new SqlCommand(strSql, con);
            
            SqlDataReader reader = cmd.ExecuteReader();

            listView歷史訂單.Clear();
            listView歷史訂單.LargeImageList = null;
            listView歷史訂單.SmallImageList = null;
            listView歷史訂單.View = View.Details;

            listView歷史訂單.Columns.Add("訂單ID", 80);
            listView歷史訂單.Columns.Add("會員ID", 80);
            listView歷史訂單.Columns.Add("商品名稱", 180);
            listView歷史訂單.Columns.Add("數量", 80);
            listView歷史訂單.Columns.Add("單價", 80);
            listView歷史訂單.Columns.Add("時間", 200);

            listView歷史訂單.GridLines = true;
            listView歷史訂單.FullRowSelect = true;//藍色框框

            while (reader.Read()) //可以讀取到上面SELECT裡面所有欄位的東西
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["orderid"].ToString();
                item.SubItems.Add(reader["memberid"].ToString());
                //單點名稱.Add((string)reader["productname"]);

                item.SubItems.Add(reader["ProductName"].ToString()); //存字串
                //產品名稱.Add((string)reader["Productname"]);
                item.SubItems.Add(reader["Quantity"].ToString());
                數量.Add((int)reader["Quantity"]);
                item.SubItems.Add(reader["Price"].ToString());
                價格.Add((int)reader["Price"]);
                item.SubItems.Add(reader["ordertime"].ToString());
                //OrderList orderList = new OrderList();

                //.Add(Convert.ToInt32(reader["Price"]));
                //item.SubItems.Add(orderList.價格);
                //新增訂單 查詢購物車 查詢訂單明細

                // 數量.Add((int)reader["Quantity"]);


                //把上面的值 帶入 listview商品展示.itens.Add  放到列表去
                listView歷史訂單.Items.Add(item);

            }
            for (int i = 0; i < 數量.Count; i++) 
            {
                營業額 += 數量[i] * 價格[i];
            }
            lbl總營業額.Text = $"總營業額:{營業額}元";
            reader.Close();
            con.Close();
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            營業額 = 0;
            數量.Clear();
            價格.Clear();//讀取陣列都要在Clear
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSql = "select * from orders join members on orders.memberid = members.memberid join orderdetails on orders.orderid = orderdetails.orderid  where ordertime between @dtpstart and @dtpend order by ordertime";
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.AddWithValue("@dtpstart", dtp起.Value);
            cmd.Parameters.AddWithValue("@dtpend", dtp終.Value);
            SqlDataReader reader = cmd.ExecuteReader();

            listView歷史訂單.Clear();
            listView歷史訂單.LargeImageList = null;
            listView歷史訂單.SmallImageList = null;
            listView歷史訂單.View = View.Details;

            listView歷史訂單.Columns.Add("訂單ID", 80);
            listView歷史訂單.Columns.Add("會員ID", 80);
            listView歷史訂單.Columns.Add("商品名稱", 180);
            listView歷史訂單.Columns.Add("數量", 80);
            listView歷史訂單.Columns.Add("單價", 80);
            listView歷史訂單.Columns.Add("時間", 200);

            listView歷史訂單.GridLines = true;
            listView歷史訂單.FullRowSelect = true;//藍色框框

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader["orderid"].ToString(); //reader=取值  add=存值 陣列存法  等號的話就是一般型態存法 addwithvalue. >>也是存
                item.SubItems.Add(reader["memberid"].ToString());
                //單點名稱.Add((string)reader["productname"]);

                item.SubItems.Add(reader["ProductName"].ToString()); //存字串
                //產品名稱.Add((string)reader["Productname"]);
                item.SubItems.Add(reader["Quantity"].ToString());//subitem 列表語法
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["ordertime"].ToString());
                數量.Add((int)reader["Quantity"]);
                
                價格.Add((int)reader["Price"]);
               
                //OrderList orderList = new OrderList();

                //.Add(Convert.ToInt32(reader["Price"]));
                //item.SubItems.Add(orderList.價格);
                //新增訂單 查詢購物車 查詢訂單明細

                // 數量.Add((int)reader["Quantity"]);


                //把上面的值 帶入 listview商品展示.itens.Add  放到列表去
                listView歷史訂單.Items.Add(item);

            }

            for (int i = 0; i < 數量.Count; i++)
            {
                營業額 += 數量[i] * 價格[i]; //沒有+=就只會顯示最後一筆
            }
            lbl總營業額.Text = $"總營業額:{營業額}元";

            reader.Close();
            con.Close();
        }
    }
}
