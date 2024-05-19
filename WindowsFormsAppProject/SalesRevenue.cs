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
        public SalesRevenue()
        {
            InitializeComponent();
        }

        private void SalesRevenue_Load(object sender, EventArgs e)
        {
            
            Revenue revenue = new Revenue();
            revenue.購物車資料讀取();
        }
    }
}
