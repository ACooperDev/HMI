namespace HMI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.loadWebPageiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView4 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView5 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView6 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfDisplaysToolStripMenuItem,
            this.loadWebPageiniToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // numberOfDisplaysToolStripMenuItem
            // 
            this.numberOfDisplaysToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.numberOfDisplaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.numberOfDisplaysToolStripMenuItem.Name = "numberOfDisplaysToolStripMenuItem";
            this.numberOfDisplaysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numberOfDisplaysToolStripMenuItem.Text = "Number of Displays";
            this.numberOfDisplaysToolStripMenuItem.Click += new System.EventHandler(this.numberOfDisplaysToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // loadWebPageiniToolStripMenuItem
            // 
            this.loadWebPageiniToolStripMenuItem.Name = "loadWebPageiniToolStripMenuItem";
            this.loadWebPageiniToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadWebPageiniToolStripMenuItem.Text = "Load WebPage.ini";
            this.loadWebPageiniToolStripMenuItem.Click += new System.EventHandler(this.loadWebPageiniToolStripMenuItem_Click_1);
            // 
            // webView1
            // 
            this.webView1.AllowExternalDrop = true;
            this.webView1.CreationProperties = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.Location = new System.Drawing.Point(10, 50);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(449, 402);
            this.webView1.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView1.TabIndex = 1;
            this.webView1.ZoomFactor = 1D;
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(477, 50);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(183, 165);
            this.webView2.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView2.TabIndex = 8;
            this.webView2.Visible = false;
            this.webView2.ZoomFactor = 1D;
            // 
            // webView3
            // 
            this.webView3.AllowExternalDrop = true;
            this.webView3.CreationProperties = null;
            this.webView3.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView3.Location = new System.Drawing.Point(680, 50);
            this.webView3.Name = "webView3";
            this.webView3.Size = new System.Drawing.Size(183, 165);
            this.webView3.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView3.TabIndex = 11;
            this.webView3.Visible = false;
            this.webView3.ZoomFactor = 1D;
            // 
            // webView4
            // 
            this.webView4.AllowExternalDrop = true;
            this.webView4.CreationProperties = null;
            this.webView4.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView4.Location = new System.Drawing.Point(477, 248);
            this.webView4.Name = "webView4";
            this.webView4.Size = new System.Drawing.Size(183, 165);
            this.webView4.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView4.TabIndex = 14;
            this.webView4.Visible = false;
            this.webView4.ZoomFactor = 1D;
            // 
            // webView5
            // 
            this.webView5.AllowExternalDrop = true;
            this.webView5.CreationProperties = null;
            this.webView5.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView5.Location = new System.Drawing.Point(680, 248);
            this.webView5.Name = "webView5";
            this.webView5.Size = new System.Drawing.Size(183, 165);
            this.webView5.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView5.TabIndex = 15;
            this.webView5.Visible = false;
            this.webView5.ZoomFactor = 1D;
            // 
            // webView6
            // 
            this.webView6.AllowExternalDrop = true;
            this.webView6.CreationProperties = null;
            this.webView6.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView6.Location = new System.Drawing.Point(477, 430);
            this.webView6.Name = "webView6";
            this.webView6.Size = new System.Drawing.Size(183, 165);
            this.webView6.Source = new System.Uri("https://www.cognex.com", System.UriKind.Absolute);
            this.webView6.TabIndex = 16;
            this.webView6.Visible = false;
            this.webView6.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(873, 615);
            this.Controls.Add(this.webView6);
            this.Controls.Add(this.webView5);
            this.Controls.Add(this.webView4);
            this.Controls.Add(this.webView3);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.webView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MultiHMI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfDisplaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.ToolStripMenuItem loadWebPageiniToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView5;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView6;
    }
}

