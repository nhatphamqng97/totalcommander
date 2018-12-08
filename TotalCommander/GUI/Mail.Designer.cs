namespace TotalCommander.GUI
{
    partial class Mail
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
            this.Tbn_UserName = new System.Windows.Forms.TextBox();
            this.Tbn_Password = new System.Windows.Forms.TextBox();
            this.Tbn_Cc = new System.Windows.Forms.TextBox();
            this.Tbn_Recever = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tbn_Subject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbn_Cc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rtb_Content = new System.Windows.Forms.RichTextBox();
            this.Btn_chooseFile = new System.Windows.Forms.Button();
            this.Tbn_AttachFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rbn_LiveMail = new System.Windows.Forms.RadioButton();
            this.Rbn_YahooMail = new System.Windows.Forms.RadioButton();
            this.Rbn_Gmail = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbn_UserName
            // 
            this.Tbn_UserName.Location = new System.Drawing.Point(133, 16);
            this.Tbn_UserName.Name = "Tbn_UserName";
            this.Tbn_UserName.Size = new System.Drawing.Size(236, 25);
            this.Tbn_UserName.TabIndex = 0;
            // 
            // Tbn_Password
            // 
            this.Tbn_Password.Location = new System.Drawing.Point(133, 47);
            this.Tbn_Password.Name = "Tbn_Password";
            this.Tbn_Password.PasswordChar = '*';
            this.Tbn_Password.Size = new System.Drawing.Size(236, 25);
            this.Tbn_Password.TabIndex = 1;
            // 
            // Tbn_Cc
            // 
            this.Tbn_Cc.Location = new System.Drawing.Point(133, 109);
            this.Tbn_Cc.Name = "Tbn_Cc";
            this.Tbn_Cc.Size = new System.Drawing.Size(236, 25);
            this.Tbn_Cc.TabIndex = 4;
            // 
            // Tbn_Recever
            // 
            this.Tbn_Recever.Location = new System.Drawing.Point(133, 78);
            this.Tbn_Recever.Name = "Tbn_Recever";
            this.Tbn_Recever.Size = new System.Drawing.Size(236, 25);
            this.Tbn_Recever.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbn_Subject);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbn_Cc);
            this.groupBox1.Controls.Add(this.Tbn_Cc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tbn_Recever);
            this.groupBox1.Controls.Add(this.Tbn_UserName);
            this.groupBox1.Controls.Add(this.Tbn_Password);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // Tbn_Subject
            // 
            this.Tbn_Subject.Location = new System.Drawing.Point(133, 140);
            this.Tbn_Subject.Name = "Tbn_Subject";
            this.Tbn_Subject.Size = new System.Drawing.Size(236, 25);
            this.Tbn_Subject.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject";
            // 
            // lbn_Cc
            // 
            this.lbn_Cc.AutoSize = true;
            this.lbn_Cc.Location = new System.Drawing.Point(15, 112);
            this.lbn_Cc.Name = "lbn_Cc";
            this.lbn_Cc.Size = new System.Drawing.Size(25, 17);
            this.lbn_Cc.TabIndex = 9;
            this.lbn_Cc.Text = "Cc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rtb_Content);
            this.groupBox2.Controls.Add(this.Btn_chooseFile);
            this.groupBox2.Controls.Add(this.Tbn_AttachFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Content";
            // 
            // Rtb_Content
            // 
            this.Rtb_Content.Location = new System.Drawing.Point(9, 64);
            this.Rtb_Content.Name = "Rtb_Content";
            this.Rtb_Content.Size = new System.Drawing.Size(369, 128);
            this.Rtb_Content.TabIndex = 2;
            this.Rtb_Content.Text = "Content";
            // 
            // Btn_chooseFile
            // 
            this.Btn_chooseFile.Location = new System.Drawing.Point(299, 24);
            this.Btn_chooseFile.Name = "Btn_chooseFile";
            this.Btn_chooseFile.Size = new System.Drawing.Size(70, 25);
            this.Btn_chooseFile.TabIndex = 1;
            this.Btn_chooseFile.Text = "Browse...";
            this.Btn_chooseFile.UseVisualStyleBackColor = true;
            this.Btn_chooseFile.Click += new System.EventHandler(this.Btn_chooseFile_Click);
            // 
            // Tbn_AttachFile
            // 
            this.Tbn_AttachFile.Location = new System.Drawing.Point(85, 24);
            this.Tbn_AttachFile.Name = "Tbn_AttachFile";
            this.Tbn_AttachFile.Size = new System.Drawing.Size(208, 25);
            this.Tbn_AttachFile.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Attach File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(412, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSS
            // 
            this.TSS.Name = "TSS";
            this.TSS.Size = new System.Drawing.Size(48, 17);
            this.TSS.Text = "Ready...";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(232, 451);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(70, 25);
            this.Btn_Send.TabIndex = 0;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(320, 451);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(70, 25);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rbn_LiveMail);
            this.groupBox3.Controls.Add(this.Rbn_YahooMail);
            this.groupBox3.Controls.Add(this.Rbn_Gmail);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 48);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mail Services";
            // 
            // Rbn_LiveMail
            // 
            this.Rbn_LiveMail.AutoSize = true;
            this.Rbn_LiveMail.Location = new System.Drawing.Point(277, 21);
            this.Rbn_LiveMail.Name = "Rbn_LiveMail";
            this.Rbn_LiveMail.Size = new System.Drawing.Size(82, 21);
            this.Rbn_LiveMail.TabIndex = 2;
            this.Rbn_LiveMail.TabStop = true;
            this.Rbn_LiveMail.Text = "Live Mail";
            this.Rbn_LiveMail.UseVisualStyleBackColor = true;
            // 
            // Rbn_YahooMail
            // 
            this.Rbn_YahooMail.AutoSize = true;
            this.Rbn_YahooMail.Location = new System.Drawing.Point(145, 21);
            this.Rbn_YahooMail.Name = "Rbn_YahooMail";
            this.Rbn_YahooMail.Size = new System.Drawing.Size(93, 21);
            this.Rbn_YahooMail.TabIndex = 1;
            this.Rbn_YahooMail.TabStop = true;
            this.Rbn_YahooMail.Text = "Yahoo Mail";
            this.Rbn_YahooMail.UseVisualStyleBackColor = true;
            // 
            // Rbn_Gmail
            // 
            this.Rbn_Gmail.AutoSize = true;
            this.Rbn_Gmail.Location = new System.Drawing.Point(18, 21);
            this.Rbn_Gmail.Name = "Rbn_Gmail";
            this.Rbn_Gmail.Size = new System.Drawing.Size(60, 21);
            this.Rbn_Gmail.TabIndex = 0;
            this.Rbn_Gmail.TabStop = true;
            this.Rbn_Gmail.Text = "Gmail";
            this.Rbn_Gmail.UseVisualStyleBackColor = true;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mail";
            this.Text = "Email";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbn_UserName;
        private System.Windows.Forms.TextBox Tbn_Password;
        private System.Windows.Forms.TextBox Tbn_Cc;
        private System.Windows.Forms.TextBox Tbn_Recever;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbn_Cc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbn_Subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Rtb_Content;
        private System.Windows.Forms.Button Btn_chooseFile;
        private System.Windows.Forms.TextBox Tbn_AttachFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rbn_LiveMail;
        private System.Windows.Forms.RadioButton Rbn_YahooMail;
        private System.Windows.Forms.RadioButton Rbn_Gmail;
        private System.Windows.Forms.ToolStripStatusLabel TSS;
    }
}