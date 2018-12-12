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

        private Task task;

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

        //Đẩy đường dẫn ListCopyPath cho giao diện con
        private void copyAction(List<string> listPath, bool isCopy)
        {
            this.isCopy = isCopy;

            this.listCopyPath.Clear();

            this.listCopyPath = listPath;
        }

        //Đẩy đường dẫn cần ListCopyPath cho giao diện con
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


        #region Home Page Action
        //One Page Click
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

        //Two Page Click
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

        //Copy Click
        private void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnPaste.Enabled = true;

            this.listCopyPath.Clear();

            if (this.gui1.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui1.LvMain.SelectedItems)
                    this.listCopyPath.Add(item.Tag.ToString());
            }
            else if (this.gui2.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui2.LvMain.SelectedItems)
                    this.listCopyPath.Add(item.Tag.ToString());
            }
            this.isCopy = true;
        }

        //Cut Click
        private void btnCut_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnPaste.Enabled = true;

            if (this.gui1.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui1.LvMain.SelectedItems)
                    this.listCopyPath.Add(item.Tag.ToString());
            }
            else if (this.gui2.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui2.LvMain.SelectedItems)
                    this.listCopyPath.Add(item.Tag.ToString());
            }

            this.isCopy = false;
        }

        //Paste Click
        private void btnPaste_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnPaste.Enabled = false;

            string pathPaste = "";

            if (this.gui1.LvMain.Focused)
            {
                pathPaste = this.gui1.ListBack.Peek();
            }
            else if (this.gui2.LvMain.Focused)
            {
                pathPaste = this.gui2.ListBack.Peek();
            }
            else
            {
                MessageBox.Show("You must focus on one UI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.task = Task.Run(() => pasteAction(pathPaste));
            timer.Start();
        }

        //Timmer xử lý sự kiên refresh
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.task.IsCompleted)//Các this.task = Task.Run(() khi hoàn thành
            {
                //Gọi hàm refresh lại tất cả các giao diện ở form1
                refreshAll();
                //Dừng bộ đếm khi đã kết thúc tiến trình
                this.timer.Stop();
            }
        }

        //Delete permanently Click
        private void btnPermanentlyDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<string> listPath = new List<string>();

            ListView lvMain = null;

            if (this.gui1.LvMain.Focused)
                lvMain = this.gui1.LvMain;
            else if (this.gui2.LvMain.Focused)
                lvMain = this.gui2.LvMain;


            //Nếu không nhận được lvMain nào thì thoát ra
            if (lvMain == null)
            {
                MessageBox.Show("You must select some items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setEnabledForSelectItem(false);
                return;
            }

            foreach (ListViewItem item in lvMain.SelectedItems)
                listPath.Add(item.Tag.ToString());

            if (listPath.Count > 1)
            {
                //Nếu có nhiều hơn 1 item thì hiển thị MessBox chung cho các items được xóa
                if (MessageBox.Show("Are you sure you want to permanetly delete these " + listPath.Count + " items?", "Delete Multipe Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    && BLL.ClassBLL.Instances.deletePermanently(listPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs))
                {
                    foreach (ListViewItem item in lvMain.SelectedItems)
                        lvMain.Items.RemoveByKey(item.Name);
                }
            }
            else
            {
                //Nếu chỉ có một item thì hiển thị UI của nó
                if (BLL.ClassBLL.Instances.deletePermanently(listPath, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs))
                {
                    foreach (ListViewItem item in lvMain.SelectedItems)
                        lvMain.Items.RemoveByKey(item.Name);
                }
            }
        }

        // Recycle Click
        private void RecycleBin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gui1.LvMain.Focused)
            {
                this.gui1.menuItemDelete_Click(null, null);
            }
            else if (this.gui2.LvMain.Focused)
            {
                this.gui2.menuItemDelete_Click(null, null);
            }
            else
            {
                MessageBox.Show("You must select some items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Rename Click
        private void btnRename_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<string> listPath = new List<string>();

            ListView lvMain;

            if (this.gui1.LvMain.Focused)
            {
                lvMain = this.gui1.LvMain;
                if (lvMain.SelectedItems.Count > 0)
                {
                    ListViewItem item = lvMain.SelectedItems[0];//Lấy Item đang được chọn

                    this.gui1.oldNameItem = item.Text;

                    item.BeginEdit();
                }
            }
            else if (this.gui2.LvMain.Focused)
            {
                lvMain = this.gui2.LvMain;
                if (lvMain.SelectedItems.Count > 0)
                {
                    ListViewItem item = lvMain.SelectedItems[0];//Lấy Item đang được chọn

                    this.gui2.oldNameItem = item.Text;

                    item.BeginEdit();
                }
            }
            else
                MessageBox.Show("You must select some items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSelectAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gui1.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui1.LvMain.Items)
                    item.Selected = true;
            }
            else if (this.gui2.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui2.LvMain.Items)
                    item.Selected = true;
            }
            else
                MessageBox.Show("You must focus on one display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNoneSelect_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gui1.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui1.LvMain.Items)
                    item.Selected = false;
            }
            if (this.gui2.LvMain.Focused)
            {
                foreach (ListViewItem item in this.gui2.LvMain.Items)
                    item.Selected = false;
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
                    Process.Start("shutdown", "-s");

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
    }

}