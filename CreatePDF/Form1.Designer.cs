namespace CreatePDF
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTXT = new System.Windows.Forms.Button();
            this.CreateJPG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTXT
            // 
            this.CreateTXT.Location = new System.Drawing.Point(64, 52);
            this.CreateTXT.Name = "CreateTXT";
            this.CreateTXT.Size = new System.Drawing.Size(150, 86);
            this.CreateTXT.TabIndex = 0;
            this.CreateTXT.Text = "產生文字";
            this.CreateTXT.UseVisualStyleBackColor = true;
            this.CreateTXT.Click += new System.EventHandler(this.Create_Click);
            // 
            // CreateJPG
            // 
            this.CreateJPG.Location = new System.Drawing.Point(64, 193);
            this.CreateJPG.Name = "CreateJPG";
            this.CreateJPG.Size = new System.Drawing.Size(150, 93);
            this.CreateJPG.TabIndex = 1;
            this.CreateJPG.Text = "產生圖檔";
            this.CreateJPG.UseVisualStyleBackColor = true;
            this.CreateJPG.Click += new System.EventHandler(this.CreateJPG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 661);
            this.Controls.Add(this.CreateJPG);
            this.Controls.Add(this.CreateTXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateTXT;
        private System.Windows.Forms.Button CreateJPG;
    }
}

