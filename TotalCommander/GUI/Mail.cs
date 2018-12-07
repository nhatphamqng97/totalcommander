using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;


namespace TotalCommander.GUI
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Tbn_Password.PasswordChar = '*';
        }

        public void SetMailTo(string MailTo, string Subject)
        {
            Tbn_Recever.Text = MailTo;
            Tbn_Subject.Text = Subject;
        }
        public void settexpath()
        {
            Tbn_AttachFile.Text = null;
        }

        // Nhận đường dẫn từ lớp ngoài.
        public void SetPathAttachFile(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                string extention = Path.GetExtension(path);
                Tbn_AttachFile.Text = "";
                if (di.Attributes != FileAttributes.Directory && extention != "")
                {
                    Tbn_AttachFile.Text = path;
                }
                else
                {
                    MessageBox.Show(" Chương trình không thể gởi một folder, hay nhiều file. \n Vui lòng chọn một file khác trong mục Duyệt...", "Lỗi thực thi...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đường dẫn đến file không thể truy cập:" + ex.Message + "\n Vui lòng nhấn nút duyệt để chọn file. ", "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chọn file cần đính kèm.
        private void Btn_chooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                if (of.ShowDialog() == DialogResult.OK)
                {
                    Tbn_AttachFile.Text = of.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi:  " + ex.Message, "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Form load.hr
        private void Mail_Load(object sender, EventArgs e)
        {
            Tbn_Password.Focus();
            Rbn_Gmail.Checked = true;

        }

        // Khoi tao bien bool 
        Boolean bl = false;

        // Button Goi.
        private void Btn_Send_Click(object sender, EventArgs e)
        {        
            SendMail();
        }

        // Ham Goi mail
        private void SendMail()
        {
            TSS.Text = "Đang Gửi Mail đến" + Tbn_Recever.Text + "...";
            bl = false;
            CheckInfo();
            if (bl)
            {
                Tbn_UserName.Focus();
                return;
            }
            try
            {
                System.Net.NetworkCredential NkC = new System.Net.NetworkCredential(Tbn_UserName.Text, Tbn_Password.Text);
                // Tao mot bien mailmessage.
                MailMessage mmg = new MailMessage();

                // Dia chi goi mail den. Co the goi qua nhieu dia chi mail, moi di chi mail ngan cach nhau bang dau phay.
                String[] addr = Tbn_Recever.Text.Split(',');
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mmg.To.Add(addr[i]);
                mmg.ReplyTo = new MailAddress(Tbn_Recever.Text);
                // chu de goi di
                mmg.Subject = Tbn_Subject.Text;

                // Email nguoi goi
                mmg.From = new MailAddress(Tbn_UserName.Text);

                // Noi dung goi di
                mmg.Body = Rtb_Content.Text;
                mmg.IsBodyHtml = true;

                // Cc 
                if (Tbn_Cc.Text != string.Empty)
                {
                    MailAddress mCc = new MailAddress(Tbn_Cc.Text);
                    mmg.CC.Add(mCc);
                }

                mmg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                // File dinh kem.
                if (Tbn_AttachFile.Text != string.Empty)
                {
                    Attachment atF = new Attachment(Tbn_AttachFile.Text);
                    if (atF != null)
                    {
                        mmg.Attachments.Add(atF);
                    }
                }

                //  Tien hanh goi mail qua Gmail
                SmtpClient smtC = new SmtpClient();
                if (Rbn_Gmail.Checked == true)
                    try
                    {
                        smtC.Host = "smtp.gmail.com";
                        smtC.EnableSsl = true;
                    }
                    catch
                    {
                        smtC.Host = "smtp.gmail.com";
                        smtC.EnableSsl = true;
                    }
                if (Rbn_YahooMail.Checked == true)
                {
                    try
                    {
                        smtC.Host = "smtp.mail.yahoo.com";
                        smtC.EnableSsl = false;
                    }
                    catch
                    {
                        smtC.Host = "smtp.mail.yahoo.com";
                        smtC.EnableSsl = false;
                    }
                }
                if (Rbn_LiveMail.Checked == true)
                {
                    try
                    {
                        smtC.Credentials = new System.Net.NetworkCredential(Tbn_UserName.Text, Tbn_Password.Text);
                        smtC.Host = "smtp.live.com";
                        smtC.EnableSsl = true;
                    }
                    catch
                    {
                        smtC.Credentials = new System.Net.NetworkCredential(Tbn_UserName.Text, Tbn_Password.Text);
                        smtC.Host = "smtp.live.com";
                        smtC.EnableSsl = true;
                    }
                }

                smtC.Credentials = NkC;
                smtC.Port = 587;
                smtC.Send(mmg);
                MessageBox.Show("Thư đã được gởi đến: " + Tbn_Recever.Text + " , " + Tbn_Cc.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thực thi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TSS.Text = " Mail đã được gởi đến:" + Tbn_Recever.Text;
        }

        // Kiem tra thong tin da nhap.
        private void CheckInfo()
        {
            String strMessage = " Những mục sau đây là bắt buộc phải nhập: \r\n";
            ErrorProvider er1 = new ErrorProvider();
            if (Tbn_UserName.Text == "")
            {
                bl = true;
                strMessage += "Email người gởi" + "\r\n";
                er1.Clear();
                er1.SetError(Tbn_UserName, " Bắt buộc phải nhập mục này!");
                return;
            }
            if (Tbn_Password.Text == "")
            {
                bl = true;
                strMessage += "Mật khẩu " + "\r\n";
                er1.Clear();
                er1.SetError(Tbn_Password, " Bắt buộc phải nhập mục này!");
                return;
            }

            if (Tbn_Subject.Text == "")
            {
                Tbn_Subject.Text = "Không chủ đề.";
            }

            if (bl)
            {
                MessageBox.Show(strMessage, " Lỗi thực thi...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Button xoa.
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Rbn_Gmail.Checked = true;
            Tbn_Password.Text = null;
            Tbn_UserName.Text = null;
            Tbn_Recever.Text = null;
            Tbn_Subject.Text = null;
            Tbn_Cc.Text = null;
            Rtb_Content.Text = null;

        }
    }
}
