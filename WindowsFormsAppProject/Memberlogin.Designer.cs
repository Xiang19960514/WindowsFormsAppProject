namespace WindowsFormsAppProject
{
    partial class Memberlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memberlogin));
            this.btn確認 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt號碼 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn註冊會員 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn取消 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn確認
            // 
            this.btn確認.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認.ForeColor = System.Drawing.Color.Gray;
            this.btn確認.Location = new System.Drawing.Point(216, 106);
            this.btn確認.Name = "btn確認";
            this.btn確認.Size = new System.Drawing.Size(75, 50);
            this.btn確認.TabIndex = 0;
            this.btn確認.Text = "確認";
            this.btn確認.UseVisualStyleBackColor = true;
            this.btn確認.Click += new System.EventHandler(this.btn確認_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "號碼";
            // 
            // txt號碼
            // 
            this.txt號碼.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt號碼.Location = new System.Drawing.Point(88, 52);
            this.txt號碼.Multiline = true;
            this.txt號碼.Name = "txt號碼";
            this.txt號碼.Size = new System.Drawing.Size(184, 34);
            this.txt號碼.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.btn取消);
            this.groupBox1.Controls.Add(this.btn註冊會員);
            this.groupBox1.Controls.Add(this.txt號碼);
            this.groupBox1.Controls.Add(this.btn確認);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(43, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請輸入會員電話";
            // 
            // btn註冊會員
            // 
            this.btn註冊會員.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊會員.ForeColor = System.Drawing.Color.Gray;
            this.btn註冊會員.Location = new System.Drawing.Point(6, 106);
            this.btn註冊會員.Name = "btn註冊會員";
            this.btn註冊會員.Size = new System.Drawing.Size(119, 50);
            this.btn註冊會員.TabIndex = 3;
            this.btn註冊會員.Text = "註冊會員";
            this.btn註冊會員.UseVisualStyleBackColor = true;
            this.btn註冊會員.Click += new System.EventHandler(this.btn註冊會員_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 317);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn取消
            // 
            this.btn取消.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.ForeColor = System.Drawing.Color.Gray;
            this.btn取消.Location = new System.Drawing.Point(131, 106);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(79, 50);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // Memberlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Memberlogin";
            this.Text = "Memberlogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Memberlogin_FormClosing);
            this.Load += new System.EventHandler(this.Memberlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn確認;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt號碼;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn註冊會員;
        private System.Windows.Forms.Button btn取消;
    }
}