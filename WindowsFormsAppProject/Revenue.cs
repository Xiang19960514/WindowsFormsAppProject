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
    public partial class Revenue : Form
    {   
        List<string> 產品名稱 = new List<string>();
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            
            Memberlogin memberlogin = new Memberlogin();
            memberlogin.ShowDialog();
            購物車資料讀取();
        }
        

        void 購物車資料讀取()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSql = "select * from orders join members on orders.memberid = members.memberid join orderdetails on orders.orderid = orderdetails.orderid where members.memberid =@ID ";
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ID", GlobalVar.ID);
            SqlDataReader reader = cmd.ExecuteReader();
            
            listView歷史訂單.Clear();
            listView歷史訂單.LargeImageList = null;
            listView歷史訂單.SmallImageList = null;
            listView歷史訂單.View = View.Details;

            listView歷史訂單.Columns.Add("訂單ID", 80);
            listView歷史訂單.Columns.Add("會員ID", 150);
            listView歷史訂單.Columns.Add("商品名稱", 80);
            listView歷史訂單.Columns.Add("數量", 50);
            listView歷史訂單.Columns.Add("單價", 50);

            listView歷史訂單.GridLines = true;
            listView歷史訂單.FullRowSelect = true;//藍色框框

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = reader["orderid"].ToString();
                item.SubItems.Add(reader["memberid"].ToString());
                //單點名稱.Add((string)reader["productname"]);

                item.SubItems.Add(reader["ProductName"].ToString()); //存字串
                //產品名稱.Add((string)reader["Productname"]);
                item.SubItems.Add(reader["Quantity"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                //OrderList orderList = new OrderList();

                //.Add(Convert.ToInt32(reader["Price"]));
                //item.SubItems.Add(orderList.價格);
                //新增訂單 查詢購物車 查詢訂單明細

                // 數量.Add((int)reader["Quantity"]);


                //把上面的值 帶入 listview商品展示.itens.Add  放到列表去
                listView歷史訂單.Items.Add(item);

            }
           
            
            reader.Close();
            con.Close();
        }
    }
}
