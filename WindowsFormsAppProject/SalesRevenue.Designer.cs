namespace WindowsFormsAppProject
{
    partial class SalesRevenue
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn年營業額 = new System.Windows.Forms.Button();
            this.btn月營業額 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.BurlyWood;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-9, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 525);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn年營業額
            // 
            this.btn年營業額.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn年營業額.ForeColor = System.Drawing.Color.Navy;
            this.btn年營業額.Location = new System.Drawing.Point(39, 13);
            this.btn年營業額.Name = "btn年營業額";
            this.btn年營業額.Size = new System.Drawing.Size(162, 50);
            this.btn年營業額.TabIndex = 1;
            this.btn年營業額.Text = "年營業額";
            this.btn年營業額.UseVisualStyleBackColor = true;
            // 
            // btn月營業額
            // 
            this.btn月營業額.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn月營業額.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn月營業額.Location = new System.Drawing.Point(290, 13);
            this.btn月營業額.Name = "btn月營業額";
            this.btn月營業額.Size = new System.Drawing.Size(162, 50);
            this.btn月營業額.TabIndex = 2;
            this.btn月營業額.Text = "月營業額";
            this.btn月營業額.UseVisualStyleBackColor = true;
            // 
            // SalesRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 591);
            this.Controls.Add(this.btn月營業額);
            this.Controls.Add(this.btn年營業額);
            this.Controls.Add(this.listView1);
            this.Name = "SalesRevenue";
            this.Text = "SalesRevenue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn年營業額;
        private System.Windows.Forms.Button btn月營業額;
    }
}