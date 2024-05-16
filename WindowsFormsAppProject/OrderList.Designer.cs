namespace WindowsFormsAppProject
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.btn繼續訂購關閉 = new System.Windows.Forms.Button();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.lbl訂購品項列表 = new System.Windows.Forms.Label();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.txt訂購人資料 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn繼續訂購關閉
            // 
            this.btn繼續訂購關閉.BackColor = System.Drawing.Color.PeachPuff;
            this.btn繼續訂購關閉.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn繼續訂購關閉.ForeColor = System.Drawing.Color.Maroon;
            this.btn繼續訂購關閉.Location = new System.Drawing.Point(364, 407);
            this.btn繼續訂購關閉.Margin = new System.Windows.Forms.Padding(4);
            this.btn繼續訂購關閉.Name = "btn繼續訂購關閉";
            this.btn繼續訂購關閉.Size = new System.Drawing.Size(288, 48);
            this.btn繼續訂購關閉.TabIndex = 19;
            this.btn繼續訂購關閉.Text = "繼續訂購(關閉)";
            this.btn繼續訂購關閉.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn繼續訂購關閉.UseVisualStyleBackColor = false;
            // 
            // btn結帳
            // 
            this.btn結帳.BackColor = System.Drawing.Color.RosyBrown;
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.ForeColor = System.Drawing.Color.Black;
            this.btn結帳.Location = new System.Drawing.Point(364, 463);
            this.btn結帳.Margin = new System.Windows.Forms.Padding(4);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(288, 48);
            this.btn結帳.TabIndex = 18;
            this.btn結帳.Text = "結帳";
            this.btn結帳.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn結帳.UseVisualStyleBackColor = false;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.ForeColor = System.Drawing.Color.Red;
            this.btn清除所有品項.Location = new System.Drawing.Point(68, 463);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(4);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(288, 48);
            this.btn清除所有品項.TabIndex = 17;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(68, 407);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(4);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(288, 48);
            this.btn移除所選品項.TabIndex = 16;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(217, 525);
            this.lbl訂單總價.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(288, 67);
            this.lbl訂單總價.TabIndex = 14;
            this.lbl訂單總價.Text = "訂單總價 00000 元";
            this.lbl訂單總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.AutoSize = true;
            this.lbl訂購人資料.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl訂購人資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(374, 26);
            this.lbl訂購人資料.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(167, 38);
            this.lbl訂購人資料.TabIndex = 11;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // lbl訂購品項列表
            // 
            this.lbl訂購品項列表.AutoSize = true;
            this.lbl訂購品項列表.BackColor = System.Drawing.Color.Sienna;
            this.lbl訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購品項列表.Location = new System.Drawing.Point(50, 26);
            this.lbl訂購品項列表.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂購品項列表.Name = "lbl訂購品項列表";
            this.lbl訂購品項列表.Size = new System.Drawing.Size(167, 38);
            this.lbl訂購品項列表.TabIndex = 10;
            this.lbl訂購品項列表.Text = "購物車列表";
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.Teal;
            this.listView商品展示.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView商品展示.ForeColor = System.Drawing.Color.Transparent;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(45, 72);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(685, 317);
            this.listView商品展示.TabIndex = 20;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            // 
            // txt訂購人資料
            // 
            this.txt訂購人資料.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人資料.Location = new System.Drawing.Point(548, 26);
            this.txt訂購人資料.Name = "txt訂購人資料";
            this.txt訂購人資料.Size = new System.Drawing.Size(182, 40);
            this.txt訂購人資料.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 603);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(767, 601);
            this.Controls.Add(this.txt訂購人資料);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.btn繼續訂購關閉);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.lbl訂購品項列表);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn繼續訂購關閉;
        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.Label lbl訂購品項列表;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.TextBox txt訂購人資料;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}