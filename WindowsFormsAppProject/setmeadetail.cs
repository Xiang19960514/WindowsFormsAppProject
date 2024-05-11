using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppProject
{
    public partial class setmealdetail : Form
    {

        public setmealdetail()
        {
            InitializeComponent();
        }

        private void setmealdetail_Load(object sender, EventArgs e)
        {
            顯示商品詳細資訊();
           
        }
        int 價格計算() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select products.productid,[set].setid,price,setdiscount from products join [set] on products.ProductID = [set].productid join setmeal on [set].setid = setmeal.setid where setmeal.setid = @SearchID";
           

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.商品ID);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> 套餐價格 = new List<int>();
            int discount = 0;
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                套餐價格.Add((int)reader["price"]);
                discount = (int)reader["setdiscount"];


               
                //套餐價格.Sum(); //218 (只有取第一個套餐但他不只一個品項 所以是228-10=218)
               
            }
            int i = 套餐價格.Sum() - discount;
            //Console.WriteLine(i);測試用

            reader.Close();
            con.Close();
            return i;//只要能獨立運算 不需要外部的運算式or資料 就不用在方法裡面設參數
            //依方法裡面的功能判定是否需要外部提供資料 需要的話 方法(要設參數)型態+名稱 不用的話就是放小括號就好
        }
           
               
           
        void 顯示商品詳細資訊()
        {
            if (GlobalVar.商品ID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from";
                if (GlobalVar.內容各別顯示 == 1)
                {
                    strSQL += " setmeal where setID = @SearchId"; 
                }
                else  
                {
                    strSQL += " products where productID = @SearchId";
                }
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", GlobalVar.商品ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    if (GlobalVar.內容各別顯示 == 1)
                    {
                        txt商品名稱.Text = reader["setname"].ToString();
                        txt商品描述.Text = reader["description"].ToString();

                        txt商品價格.Text = 價格計算().ToString();


                    }   
                    else
                    {   
                        txt商品名稱.Text = reader["productname"].ToString();
                        txt商品價格.Text = reader["price"].ToString();
                        txt商品描述.Text = reader["description"].ToString();
                    }
                }

                reader.Close();
                con.Close();
            }
        }
    }
}////////////////
