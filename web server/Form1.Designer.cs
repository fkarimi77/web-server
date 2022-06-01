namespace web_server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startserverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopserver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serverlogstext = new System.Windows.Forms.TextBox();
            this.serverporttext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startserverBtn
            // 
            this.startserverBtn.Location = new System.Drawing.Point(51, 77);
            this.startserverBtn.Name = "startserverBtn";
            this.startserverBtn.Size = new System.Drawing.Size(130, 42);
            this.startserverBtn.TabIndex = 0;
            this.startserverBtn.Text = "Start Server";
            this.startserverBtn.UseVisualStyleBackColor = true;
            this.startserverBtn.Click += new System.EventHandler(this.startserverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stopserver
            // 
            this.stopserver.Location = new System.Drawing.Point(51, 137);
            this.stopserver.Name = "stopserver";
            this.stopserver.Size = new System.Drawing.Size(130, 38);
            this.stopserver.TabIndex = 3;
            this.stopserver.Text = "Stop Server";
            this.stopserver.UseVisualStyleBackColor = true;
            this.stopserver.Click += new System.EventHandler(this.stopserver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Logs";
            // 
            // serverlogstext
            // 
            this.serverlogstext.Location = new System.Drawing.Point(240, 77);
            this.serverlogstext.Multiline = true;
            this.serverlogstext.Name = "serverlogstext";
            this.serverlogstext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverlogstext.Size = new System.Drawing.Size(362, 254);
            this.serverlogstext.TabIndex = 5;
            // 
            // serverporttext
            // 
            this.serverporttext.Location = new System.Drawing.Point(51, 232);
            this.serverporttext.Name = "serverporttext";
            this.serverporttext.Size = new System.Drawing.Size(130, 23);
            this.serverporttext.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.serverporttext);
            this.Controls.Add(this.serverlogstext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startserverBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startserverBtn;
        private Label label1;
        private Button stopserver;
        private Label label2;
        private TextBox serverlogstext;
        private TextBox serverporttext;
    }
}