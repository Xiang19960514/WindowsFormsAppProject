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
            
            購物車資料讀取();
        }
             
        void 購物車資料讀取() 
        {
             SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
             con.Open();
             string strSql = "select p.ProductID,productname,p.Price,s.Quantity from products p join shoppingcart s on　p.productid = s.productid union all select s.setID,setname,setdiscount,shoppingcart.Quantity from setmeal s join shoppingcart on s.setid = shoppingcart.setid";
             SqlCommand cmd = new SqlCommand(strSql, con);
             SqlDataReader reader = cmd.ExecuteReader();
             listView商品展示.Clear();
             listView商品展示.LargeImageList = null;
             listView商品展示.SmallImageList = null;
             listView商品展示.View = View.Details;

             listView商品展示.Columns.Add("所有ID", 200);
             listView商品展示.Columns.Add("所有商品名稱", 200);
             listView商品展示.Columns.Add("價格", 100);
             listView商品展示.Columns.Add("數量", 50);

             listView商品展示.GridLines = true;
             listView商品展示.FullRowSelect = true;//藍色框框

            while (reader.Read())
            {
                

               
              ListViewItem item = new ListViewItem();
              item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
              item.Text = reader["Productid"].ToString();//只有第一個是text 其他都是subitems
              item.SubItems.Add((string)reader["productname"]);
              item.SubItems.Add(reader["Price"].ToString()); //存字串
              item.SubItems.Add(reader["Quantity"].ToString());
                    // item.ForeColor = Color.DarkBlue;
                    //item.Tag = listID[i];

                    //把上面的值 帶入 listview商品展示.itens.Add  放到列表去
                    listView商品展示.Items.Add(item);
                
            }
            reader.Close();
            con.Close();
        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            if (listView商品展示.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("是否輸入會員電話","輸入會員", MessageBoxButtons.YesNo);//前面是內容後面是標題
                switch (dr) 
                {
                 case DialogResult.Yes:
                        Memberlogin memberlogin = new Memberlogin();
                        memberlogin.ShowDialog();
                        break;
                        case DialogResult.No:
                        break;
                }
            }
            else 
            {
                MessageBox.Show("不買拉倒 滾");
            }
        }
    }
}
