namespace WindowsFormsAppProject
{
    partial class RegisterMember
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
            this.label14 = new System.Windows.Forms.Label();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.cbx性別 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt會員名稱 = new System.Windows.Forms.TextBox();
            this.txt會員編號 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.btn新增會員 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv會員資料呈現 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn修改會員 = new System.Windows.Forms.Button();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料呈現)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(81, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 36);
            this.label14.TabIndex = 152;
            this.label14.Text = "生日";
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(159, 230);
            this.dtp生日.Margin = new System.Windows.Forms.Padding(2);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(221, 38);
            this.dtp生日.TabIndex = 151;
            // 
            // cbx性別
            // 
            this.cbx性別.CausesValidation = false;
            this.cbx性別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx性別.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx性別.FormattingEnabled = true;
            this.cbx性別.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx性別.Location = new System.Drawing.Point(160, 143);
            this.cbx性別.Name = "cbx性別";
            this.cbx性別.Size = new System.Drawing.Size(167, 33);
            this.cbx性別.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(81, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 36);
            this.label9.TabIndex = 144;
            this.label9.Text = "電話";
            // 
            // txt會員名稱
            // 
            this.txt會員名稱.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt會員名稱.Location = new System.Drawing.Point(160, 96);
            this.txt會員名稱.Name = "txt會員名稱";
            this.txt會員名稱.Size = new System.Drawing.Size(167, 31);
            this.txt會員名稱.TabIndex = 140;
            // 
            // txt會員編號
            // 
            this.txt會員編號.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt會員編號.Location = new System.Drawing.Point(160, 52);
            this.txt會員編號.Name = "txt會員編號";
            this.txt會員編號.ReadOnly = true;
            this.txt會員編號.Size = new System.Drawing.Size(167, 31);
            this.txt會員編號.TabIndex = 139;
            this.txt會員編號.TabStop = false;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(160, 187);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(167, 31);
            this.txt電話.TabIndex = 138;
            // 
            // btn新增會員
            // 
            this.btn新增會員.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn新增會員.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增會員.Location = new System.Drawing.Point(6, 274);
            this.btn新增會員.Name = "btn新增會員";
            this.btn新增會員.Size = new System.Drawing.Size(178, 59);
            this.btn新增會員.TabIndex = 136;
            this.btn新增會員.Text = "新增會員";
            this.btn新增會員.UseVisualStyleBackColor = false;
            this.btn新增會員.Click += new System.EventHandler(this.btn新增會員_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(81, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 36);
            this.label11.TabIndex = 135;
            this.label11.Text = "性別";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(29, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 36);
            this.label12.TabIndex = 134;
            this.label12.Text = "會員名稱";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(30, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 36);
            this.label13.TabIndex = 132;
            this.label13.Text = "會員編號";
            // 
            // dgv會員資料呈現
            // 
            this.dgv會員資料呈現.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv會員資料呈現.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料呈現.Location = new System.Drawing.Point(395, 22);
            this.dgv會員資料呈現.Name = "dgv會員資料呈現";
            this.dgv會員資料呈現.RowHeadersWidth = 51;
            this.dgv會員資料呈現.RowTemplate.Height = 27;
            this.dgv會員資料呈現.Size = new System.Drawing.Size(403, 373);
            this.dgv會員資料呈現.TabIndex = 133;
            this.dgv會員資料呈現.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料呈現_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Peru;
            this.groupBox1.Controls.Add(this.btn修改會員);
            this.groupBox1.Controls.Add(this.dgv會員資料呈現);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtp生日);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn重新整理);
            this.groupBox1.Controls.Add(this.btn新增會員);
            this.groupBox1.Controls.Add(this.cbx性別);
            this.groupBox1.Controls.Add(this.txt電話);
            this.groupBox1.Controls.Add(this.txt會員編號);
            this.groupBox1.Controls.Add(this.txt會員名稱);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn搜尋);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 405);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員註冊";
            // 
            // btn修改會員
            // 
            this.btn修改會員.BackColor = System.Drawing.Color.PeachPuff;
            this.btn修改會員.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改會員.Location = new System.Drawing.Point(6, 340);
            this.btn修改會員.Name = "btn修改會員";
            this.btn修改會員.Size = new System.Drawing.Size(178, 59);
            this.btn修改會員.TabIndex = 155;
            this.btn修改會員.Text = "修改會員";
            this.btn修改會員.UseVisualStyleBackColor = false;
            this.btn修改會員.Click += new System.EventHandler(this.btn修改會員_Click);
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.Silver;
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.Location = new System.Drawing.Point(210, 275);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(172, 59);
            this.btn重新整理.TabIndex = 149;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.RosyBrown;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(210, 340);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(172, 59);
            this.btn搜尋.TabIndex = 143;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // RegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterMember";
            this.Text = "RegisterMember";
            this.Load += new System.EventHandler(this.RegisterMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料呈現)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.ComboBox cbx性別;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt會員名稱;
        private System.Windows.Forms.TextBox txt會員編號;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.Button btn新增會員;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv會員資料呈現;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn修改會員;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.Button btn搜尋;
    }
}