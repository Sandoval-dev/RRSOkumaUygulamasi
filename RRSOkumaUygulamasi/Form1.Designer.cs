
namespace RRSOkumaUygulamasi
{
    partial class Form1
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
            this.btn_getir = new System.Windows.Forms.Button();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Baslik = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(1016, 30);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(92, 41);
            this.btn_getir.TabIndex = 0;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(3, 18);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.ScriptErrorsSuppressed = true;
            this.web_browser.Size = new System.Drawing.Size(773, 582);
            this.web_browser.TabIndex = 1;
            this.web_browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(15, 39);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(978, 22);
            this.txt_rssurl.TabIndex = 2;
            this.txt_rssurl.Text = "https://www.sabah.com.tr/rss/spor.xml";
            this.txt_rssurl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rssurl);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RRS URL";
            // 
            // lst_Baslik
            // 
            this.lst_Baslik.FormattingEnabled = true;
            this.lst_Baslik.ItemHeight = 16;
            this.lst_Baslik.Location = new System.Drawing.Point(0, 21);
            this.lst_Baslik.Name = "lst_Baslik";
            this.lst_Baslik.Size = new System.Drawing.Size(320, 532);
            this.lst_Baslik.TabIndex = 4;
            this.lst_Baslik.SelectedIndexChanged += new System.EventHandler(this.lst_Baslik_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Baslik);
            this.groupBox2.Location = new System.Drawing.Point(27, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 567);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_browser);
            this.groupBox3.Location = new System.Drawing.Point(366, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 603);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 757);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RRS Okuma Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Baslik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

