namespace WindowsFormsAppProject
{
    partial class Revenue
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
            this.listView歷史訂單 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView歷史訂單
            // 
            this.listView歷史訂單.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView歷史訂單.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView歷史訂單.HideSelection = false;
            this.listView歷史訂單.Location = new System.Drawing.Point(13, 13);
            this.listView歷史訂單.Name = "listView歷史訂單";
            this.listView歷史訂單.Size = new System.Drawing.Size(775, 425);
            this.listView歷史訂單.TabIndex = 0;
            this.listView歷史訂單.UseCompatibleStateImageBehavior = false;
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.listView歷史訂單);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView歷史訂單;
    }
}