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
        List<string> 輸出訂單 = new List<string>();        
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
             string strSql = "select p.ProductID,productname,p.Price,s.Quantity from products p join shoppingcart s on p.productid = s.productid union all select s.setID,setname,shoppingcart.price,shoppingcart.Quantity from setmeal s join shoppingcart on s.setid = shoppingcart.setid";
             SqlCommand cmd = new SqlCommand(strSql, con);
             SqlDataReader reader = cmd.ExecuteReader();
             listView商品展示.Clear();
             listView商品展示.LargeImageList = null;
             listView商品展示.SmallImageList = null;
             listView商品展示.View = View.Details;

             listView商品展示.Columns.Add("所有ID", 80);
             listView商品展示.Columns.Add("所有商品名稱", 150);
             listView商品展示.Columns.Add("價格", 80);
             listView商品展示.Columns.Add("數量", 50);
             
             listView商品展示.GridLines = true;
             listView商品展示.FullRowSelect = true;//藍色框框

            while (reader.Read())
            {              
              ListViewItem item = new ListViewItem();
              //item.Font = new Font("微軟正黑體", 18, FontStyle.Bold);// 字形物件要NEW
              //item.ForeColor = Color.White; //全域變數的概念
              item.Text = reader["Productid"].ToString();//只有第一個是text 其他都是subitems
              item.SubItems.Add((string)reader["productname"]);
              單點名稱.Add((string)reader["productname"]);
             
              item.SubItems.Add(reader["Price"].ToString()); //存字串
              價格.Add(Convert.ToInt32(reader["Price"]));
              item.SubItems.Add(reader["Quantity"].ToString());
              數量.Add((int)reader["Quantity"]);
                // item.ForeColor = Color.DarkBlue;
                //item.Tag = listID[i];

                //把上面的值 帶入 listview商品展示.itens.Add  放到列表去
                listView商品展示.Items.Add(item);
                
            }
            int 總價 = 0;
            for (int i = 0; i < 價格.Count; i++) 
            {
                總價 += 價格[i]*數量[i]; 
            }
            lbl訂單總價.Text = $"總金額{總價}元";
            reader.Close();
            con.Close();
        }
        public void 輸出訂購單() 
        {
            string str預設檔案目錄 = @"C:/";
            Random myRnd = new Random();
            int numRnd = myRnd.Next(1000, 10000);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + numRnd + "訂單明細.txt";
            string str完整路徑檔名 = str預設檔案目錄 + @"\" + str檔名;
            SaveFileDialog bts = new SaveFileDialog(); //選擇檔案儲存位置和檔案名稱的工具
            bts.InitialDirectory = str預設檔案目錄; // 預設初始顯示的目錄
            bts.FileName = str檔名; //要儲存的檔案的完整路徑和檔案名稱
            bts.Filter = "文字檔text|*.txt"; // (|)後設定檔案類型
            DialogResult R = bts.ShowDialog(); // DialogResult用戶與對話框交互結果的回傳值
            if (R == DialogResult.OK)
            {
                str完整路徑檔名 = bts.FileName;
            }
            else
            {
                return;
            }
            string strMsg = "";

            for (int i = 0; i < 數量.Count; i++)
            {

                strMsg += $"{單點名稱[i]},{數量[i]}份\n";
            }
            輸出訂單.Add(strMsg);
            System.IO.File.WriteAllLines(str完整路徑檔名, 輸出訂單, Encoding.UTF8);
            MessageBox.Show("訂購單儲存成功");           
        }
        private void btn結帳_Click(object sender, EventArgs e)
        {
            if (listView商品展示.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("是否輸入會員電話","輸入會員", MessageBoxButtons.YesNo);//前面是內容後面是標題
                switch (dr) 
                {
                    case DialogResult.Yes://如果有會員的話
                        Memberlogin memberlogin = new Memberlogin();
                        memberlogin.ShowDialog();
                        Close();
                        break;
                    case DialogResult.No://如果沒有會員的話執行這邊            
                        輸出訂購單();
                        GlobalVar.訂單清除();
                        Close();
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

