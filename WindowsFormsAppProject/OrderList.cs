using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class OrderList : Form
    {
        List<string> 單點名稱 = new List<string>();
        List<int> 單點ID = new List<int>();
        List<string> 套餐名稱 = new List<string>();        
        List<int> 套餐ID = new List<int>();
        List<int> 價格 = new List<int>();
        List<int> 數量 = new List<int>();

        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            顯示listView列表模式();
            購物車資料讀取();
        }
        void 顯示listView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
          
            listView商品展示.Columns.Add("單點ID", 200);
            listView商品展示.Columns.Add("單點名稱", 200); 
            listView商品展示.Columns.Add("套餐ID", 100);
            listView商品展示.Columns.Add("套餐名稱");
            listView商品展示.Columns.Add("商品數量", 100);
            listView商品展示.Columns.Add("商品價格", 100);
            listView商品展示.GridLines = true;
            listView商品展示.FullRowSelect = true;

            for (int i = 0; i < 單點名稱.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Text = 單點名稱[i].ToString();
                item.SubItems.Add(單點ID[i].ToString());
                item.SubItems.Add(價格[i].ToString());
               // item.ForeColor = Color.DarkBlue;
                //item.Tag = listID[i];

                listView商品展示.Items.Add(item);
            }

        }
        void 購物車資料讀取() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSql = "select p.ProductID as 產品編號,productname as 產品名稱,p.Price as 價格 from products p join shoppingcart s on　p.productid = s.productid union all select s.setID,setname,setdiscount from setmeal s join shoppingcart on s.setid = shoppingcart.setid";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                單點名稱.Add((string)reader["產品名稱"]);
                單點ID.Add((int)reader["產品編號"]);
                //套餐名稱.Add((string)reader["setName"]);
                //套餐ID.Add((int)reader["setID"]);
                價格.Add((int)reader["價格"]);
                //數量.Add((int)reader["Quantity"]);

            }
            reader.Close();
            con.Close();
        }
    }
}
