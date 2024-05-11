using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public OrderList()
        {
            InitializeComponent();
        }

          private void OrderList_Load(object sender, EventArgs e)
        {
            
        }
        //void 顯示listView列表模式()
        //{
        //    listView商品展示.Clear();
        //    listView商品展示.LargeImageList = null;
        //    listView商品展示.SmallImageList = null;
        //    listView商品展示.View = View.Details;
        //    listView商品展示.Columns.Add("id", 100);
        //    listView商品展示.Columns.Add("商品名稱", 200);
        //    listView商品展示.Columns.Add("商品價格", 100);
        //    listView商品展示.GridLines = true;
        //    listView商品展示.FullRowSelect = true;

        //    for (int i = 0; i < listId.Count; i += 1)
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
        //        item.Text = listId[i].ToString();
        //        item.SubItems.Add(list商品名稱[i]);
        //        item.SubItems.Add(list商品價格[i].ToString());
        //        item.ForeColor = Color.DarkBlue;
        //        item.Tag = listId[i];

        //        listView商品展示.Items.Add(item);
        //    }
  
    }
}
