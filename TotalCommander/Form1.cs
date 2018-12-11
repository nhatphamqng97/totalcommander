using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using System.IO;

namespace TotalCommander
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private GUI.uc_DirectoryList gui1;

        private GUI.uc_DirectoryList gui2;
        private List<string> listCopyPath { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.listCopyPath = new List<string>();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.gui1 = new GUI.uc_DirectoryList();
            gui1.Dock = DockStyle.Fill;
            gui1.getCopyAction = new GUI.uc_DirectoryList.DgetCopyAction(copyAction);
            gui1.getCopyPath = new GUI.uc_DirectoryList.DgetCopyPath(pushCopyPath);
            gui1.getPasteAction = new GUI.uc_DirectoryList.DgetPasteAction(pasteAction);
            gui1.getRefreshAll = new GUI.uc_DirectoryList.DgetRefreshAll(refreshAll);
            
            gui1.setEnabledButton = new GUI.uc_DirectoryList.DsetEnabledButton(setEnabledForSelectItem);
            splitMain.Panel1.Controls.Add(gui1);
            //------------------------------------------------------------------------------------
            this.gui2 = new GUI.uc_DirectoryList();
            gui2.Dock = DockStyle.Fill;
            gui2.getCopyAction = new GUI.uc_DirectoryList.DgetCopyAction(copyAction);
            gui2.getCopyPath = new GUI.uc_DirectoryList.DgetCopyPath(pushCopyPath);
            gui2.getPasteAction = new GUI.uc_DirectoryList.DgetPasteAction(pasteAction);
            gui2.getRefreshAll = new GUI.uc_DirectoryList.DgetRefreshAll(refreshAll);

            
            gui2.setEnabledButton = new GUI.uc_DirectoryList.DsetEnabledButton(setEnabledForSelectItem);
            splitMain.Panel2.Controls.Add(gui2);

            splitMain.Panel2Collapsed = true;


        }

        public void refreshAll()
        {
            this.gui1.showDirectoryAndFiles(this.gui1.ListBack.Peek());
            this.gui2.showDirectoryAndFiles(this.gui2.ListBack.Peek());
        }

        //Item thay đổi trạng thái theo content menu của UC_D
        public void setEnabledForSelectItem(bool isSelected)
        {
            btnCopy.Enabled = btnCut.Enabled = btnDelete.Enabled = btnRename.Enabled = isSelected;
        }

        #region Thao Tác Với File

       

        private bool isCopy { get; set; }


        private void copyAction(List<string> listPath, bool isCopy)
        {
            this.isCopy = isCopy;

            this.listCopyPath.Clear();

            this.listCopyPath = listPath;
        }

        //Đẩy đường dẫn cần copy(ListCopyPath) cho giao diện con
        public List<string> pushCopyPath()
        {
            return this.listCopyPath;
        }

        //Xử lý khi người dùng paste
        public void pasteAction(string pastePath)
        {
            if (isCopy)
            {
                foreach (string path in this.listCopyPath)
                    if (!BLL.ClassBLL.Instances.copyAction(path, pastePath))
                        return;
            }
            else
            {
                foreach (string path in this.listCopyPath)
                    if (!BLL.ClassBLL.Instances.moveAction(path, pastePath))
                        return;

                this.isCopy = true;

                this.listCopyPath.Clear();
            }
        }

        #endregion


        #region Application

        //Notepad Button
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Canot Open Application. Error \n" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Mail Button
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.Mail mail = new GUI.Mail();
            mail.ShowDialog();
        }

        //CMD Button
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo.FileName = "cmd.exe"; 
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Canot Open Application. Error \n" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Canot Open Application. Error \n" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        #region Shutdown
        int times;
        bool flag = false;

        private void timershutdown_Tick(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (times > 0)
                {
                    times--;
                    prShutdown.Value = times;
                    prShutdown.Increment(1);
                    ttlbShutdown.Text = " Shutdown After: " + times.ToString() + " s ";
                }
                else
                {
                    timershutdown.Enabled = false;
                    timershutdown.Stop();
                    System.Diagnostics.Process.Start("shutdown", "-s");

                }
            }
        }

        private void tb_Shutdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (tb_Shutdown.Text != null)
                {
                    timershutdown.Enabled = true;
                    timershutdown.Start();
                    times = Convert.ToInt32(tb_Shutdown.Text);

                    prShutdown.Visible = true;
                    prShutdown.Minimum = 0;
                    prShutdown.Maximum = times;

                    ttlbShutdown.Visible = true;
                    flag = true;

                    this.popupControlContainer2.Dispose();
                }
            }
        }

        #endregion


            #endregion

        #region Home Page Action
        private void chkOneScreen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (chkOneScreen.Checked)
            {
                chkTwoScreen.Checked = false;
                splitMain.Panel2Collapsed = true;//Thu Panel 2 lai
            }
            else
                chkOneScreen.Checked = true;
        }


        private void chkTwoScreen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (chkTwoScreen.Checked)
            {
                chkOneScreen.Checked = false;
                splitMain.Panel2Collapsed = false;
            }
            else
                chkTwoScreen.Checked = true;
        }

        //Packing
        private void btnPack_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.PackingForm packingForm = new GUI.PackingForm();
            packingForm.ShowDialog();
        }
        #endregion

    }
}