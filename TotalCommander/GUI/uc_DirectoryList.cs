﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TotalCommander.GUI
{
    public partial class uc_DirectoryList : UserControl
    {
        Stack<string> listBack;

        public Stack<string> ListBack
        {
            get { return listBack; }
            set { listBack = value; }
        }

        Stack<string> listForward;

        #region Delegate

        //Delegate lấy danh sách các đường dẫn copy ở form1
        public delegate List<string> DgetCopyPath();

        public DgetCopyPath getCopyPath;

        //Delegate kích hoạt sự kiện khi copy
        public delegate void DgetCopyAction(List<string> listPath, bool isCopy);

        public DgetCopyAction getCopyAction;

        //Delegate kích hoạt sự kiện khi paste
        public delegate void DgetPasteAction(string path);

        public DgetPasteAction getPasteAction;

        //delegate lấy contextMenu từ hàm form cha
        public delegate ContextMenuStrip DgetContextMenu();

        public DgetContextMenu getContextMenu;

        //delegate đẩy contextMenu về cho hàm form1 cha
        public delegate void DpushContextMenuForParent(ContextMenuStrip contextMenu);

        public DpushContextMenuForParent pushContextMenuForParent;

        //Delegate để gọi hàm bên form1 refresh lại tất cả các giao diện
        public delegate void DgetRefreshAll();

        public DgetRefreshAll getRefreshAll;

        //Delegate set Enabled cho các button Copy Cut Paste... ở form1 
        public delegate void DsetEnabledButton(bool isChecked);

        public DsetEnabledButton setEnabledButton;

        #endregion

        //Biến lưu lại tên cũ khi thay đổi tên item
        public string oldNameItem { get; set; }

        //Biến lưu lại tiến trình khi kích hoạt đa tiến trình
        private Task task;

        #region Show TreeView And ListView

        private void uc_DirectoryList_Load(object sender, EventArgs e)
        {
            cbPath.Text = "This PC";
            cbPath.Properties.Items.Add("This PC");
            listBack.Push(cbPath.Text);
            showDirectoryAndFiles(listBack.Peek());
            tvMain.PathSeparator = "C:\\";
        }

        public uc_DirectoryList(ContextMenuStrip contextMenu)
        {
            InitializeComponent();
            this.listBack = new Stack<string>();

            this.listForward = new Stack<string>();

            this.contextMenu = contextMenu;

            BLL.MyTreeView.Instances.initTreeView(tvMain);
        }

        private void showDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
                BLL.ClassBLL.Instances.showDrive(drive, lvMain);
        }

        private void showDirectories(string path)
        {
            DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
            foreach (DirectoryInfo direc in directories)
            {
                if ((direc.Attributes | FileAttributes.Hidden) != direc.Attributes)//Chỉ hiển thị những file không ẩn
                    BLL.ClassBLL.Instances.showDirectory(direc, lvMain);
            }
        }

        private void showFiles(string path)
        {
            FileInfo[] files = new DirectoryInfo(path).GetFiles();

            foreach (FileInfo file in files)
            {
                if ((file.Attributes | FileAttributes.Hidden) != file.Attributes)//Chỉ hiển thị những file không ẩn
                    BLL.ClassBLL.Instances.showFile(file, lvMain);
            }
        }

        public void showDirectoryAndFiles(string path)//Hiển thị các thư mục và các file hiện tại, hàm trả về đường dẫn mới
        {
            if (setEnabledButton != null)
            {
                setEnabledButton(false);
            }

            try
            {
                lvMain.LargeImageList.Images.Clear();
                lvMain.SmallImageList.Images.Clear();
                lvMain.Clear();

                if (path.Equals("This PC"))
                {
                    if (lvMain.View == View.Details)
                    {
                        lvMain.Columns.Add("Name", 200);
                        lvMain.Columns.Add("Type", 100);
                        lvMain.Columns.Add("Total Size", 100);
                        lvMain.Columns.Add("Free Space", 100);
                    }
                    showDrives();
                    return;
                }

                if (lvMain.View == View.Details)
                {
                    lvMain.Columns.Add("Name", 200);
                    lvMain.Columns.Add("Date modified", 150);
                    lvMain.Columns.Add("Type", 150);
                    lvMain.Columns.Add("Size", 150);
                }

                showDirectories(path);

                showFiles(path);
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region TreeView Event

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string path = e.Node.Tag.ToString();

                this.listBack.Push(path);

                lvMain.Clear();

                this.Cursor = Cursors.AppStarting;

                showDirectoryAndFiles(this.listBack.Peek());

                this.Cursor = Cursors.Arrow;

                cbPath.Text = path;

                cbPath.Properties.Items.Add(path);

                btnBack.Enabled = true;

                e.Node.Expand();
            }
            catch (Exception ex)
            { }
        }

        private void tvMain_AfterExpand(object sender, TreeViewEventArgs e)
        {
            string nameNode = e.Node.Name;

            if (!nameNode.Equals("MyComputer"))
            {
                e.Node.Nodes.Clear();
                BLL.MyTreeView.Instances.AddDirectory(e.Node, tvMain);
            }
        }
        #endregion

        #region Listview Event
        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string path = lvMain.SelectedItems[0].Tag.ToString();

                if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start(path);
                    return;
                }

                this.listBack.Push(path);

                this.Cursor = Cursors.AppStarting;

                showDirectoryAndFiles(listBack.Peek());

                this.Cursor = Cursors.Arrow;

                cbPath.Text = path;

                cbPath.Properties.Items.Add(path);

                btnBack.Enabled = true;//Bật back

                btnForward.Enabled = false;//Tắt forward

                this.listForward.Clear();//Xóa ngăn xếp forward
            }
            catch (Exception ex)
            { }
        }
        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.listBack.Peek().Equals("This PC") && setEnabledButton != null)
            {
                if (lvMain.SelectedItems.Count > 0)
                    setEnabledButton(true);
                else
                    setEnabledButton(false);
            }

            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected)
                {
                    menuItemOpen.Enabled = true;
                    menuItemCopy.Enabled = true;
                    menuItemCut.Enabled = true;
                    menuItemDelete.Enabled = true;
                    return;
                }
            menuItemOpen.Enabled = false;
            menuItemCopy.Enabled = false;
            menuItemCut.Enabled = false;
            menuItemDelete.Enabled = false;
        }
        private void lvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.lvMain.SelectedItems.Count > 0)
                    lvMain_DoubleClick(null, null);
            }
            else if (e.KeyCode == Keys.Back)
                btnBack_ItemClick(null, null);

            else if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Delete && !cbPath.Text.Equals("This PC"))//Nếu người dùng nhấn Shift + Delete và không phải ở This PC thì cho phép xóa
            {
                List<string> listPath = new List<string>();

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
            else if (e.KeyCode == Keys.F2)
            {
                if (lvMain.SelectedItems.Count > 0)
                {
                    ListViewItem item = lvMain.SelectedItems[0];//Lấy Item đang được chọn

                    this.oldNameItem = item.Name;

                    item.BeginEdit();
                }
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in lvMain.Items)
                    item.Selected = true;
            }
        }

        #endregion

        #region Button Click

        public void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (this.listBack.Count == 1)//Nếu trong stack chỉ có một phần tử đó là This PC thì không cho back nữa
                    return;

                this.listForward.Push(listBack.Pop());//Xóa đi thư mục vừa mới thoát ra đồng thời lưu hoạt động đó vào Forward

                if (cbPath.SelectedIndex >= 0)
                    cbPath.Properties.Items.RemoveAt(cbPath.SelectedIndex);//Xóa đường dẫn vừa mới thoát ra khỏi combobox

                lvMain.Clear();

                this.Cursor = Cursors.AppStarting;

                string path = this.listBack.Peek();

                showDirectoryAndFiles(listBack.Peek());

                this.Cursor = Cursors.Arrow;

                if (string.IsNullOrEmpty(path))
                {
                    cbPath.Properties.Items.Clear();
                    cbPath.Text = "This PC";
                    cbPath.Properties.Items.Add("This PC");
                }
                else
                    cbPath.Text = path;

                if (this.listBack.Count == 1)//Nếu stack chỉ còn phần tử This PC thì không cho back nữa
                    btnBack.Enabled = false;

                btnForward.Enabled = true;//Bật forward
            }
            catch (Exception ex)
            { }
        }

        private void btnForward_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //Xóa đi thư mục vừa mới thoát ra trong Forward đồng thời lưu vào combobox
            string pathForward = listForward.Pop();

            this.listBack.Push(pathForward);

            lvMain.Clear();

            this.Cursor = Cursors.AppStarting;

            showDirectoryAndFiles(pathForward);

            this.Cursor = Cursors.Arrow;

            cbPath.Text = pathForward;

            cbPath.Properties.Items.Add(pathForward);

            if (this.listForward.Count == 0)//Nếu hết phần tử trong forward thì tắt forward
                btnForward.Enabled = false;

            btnBack.Enabled = true;//Bật back
        }

        private void btnUpTo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string path;

                if (cbPath.Text.Equals("This PC"))
                    path = tvMain.TopNode.Tag.ToString();
                else
                {
                    DirectoryInfo direc = new DirectoryInfo(cbPath.Text).Parent;
                    path = (direc != null) ? direc.FullName : "This PC";
                }

                this.listBack.Push(path);

                lvMain.Clear();

                this.Cursor = Cursors.AppStarting;

                showDirectoryAndFiles(this.listBack.Peek());

                this.Cursor = Cursors.Arrow;

                cbPath.Text = path;

                cbPath.Properties.Items.Add(path);

                btnBack.Enabled = true;

                btnForward.Enabled = false;

                this.listForward.Clear();
            }
            catch (Exception ex)
            { }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.showDirectoryAndFiles(this.listBack.Peek());
        }

        #endregion

        #region View Click

        private void chkNavigationPane_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitUserControl.Panel1Collapsed = (chkNavigationPane.Checked) ? false : true;
        }

        private void btnViewLarge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnViewLarge.Checked)
            {
                this.lvMain.View = View.LargeIcon;
                showDirectoryAndFiles(this.listBack.Peek());
                btnViewDetail.Checked = btnViewSmall.Checked = btnViewList.Checked = btnViewTiles.Checked = false;
            }
            else
                btnViewLarge.Checked = true;
        }

        private void btnViewSmall_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnViewSmall.Checked)
            {
                this.lvMain.View = View.SmallIcon;
                showDirectoryAndFiles(this.listBack.Peek());
                btnViewDetail.Checked = btnViewLarge.Checked = btnViewList.Checked = btnViewTiles.Checked = false;
            }
            else
                btnViewSmall.Checked = true;
        }

        private void btnViewList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnViewList.Checked)
            {
                this.lvMain.View = View.List;
                showDirectoryAndFiles(this.listBack.Peek());
                btnViewDetail.Checked = btnViewLarge.Checked = btnViewSmall.Checked = btnViewTiles.Checked = false;
            }
            else
                btnViewList.Checked = true;
        }

        private void btnViewDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnViewDetail.Checked)
            {
                this.lvMain.View = View.Details;
                showDirectoryAndFiles(this.listBack.Peek());
                btnViewList.Checked = btnViewLarge.Checked = btnViewSmall.Checked = btnViewTiles.Checked = false;
            }
            else
                btnViewDetail.Checked = true;
        }

        private void btnViewTiles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnViewTiles.Checked)
            {
                this.lvMain.View = View.Tile;
                showDirectoryAndFiles(this.listBack.Peek());
                btnViewList.Checked = btnViewLarge.Checked = btnViewSmall.Checked = btnViewDetail.Checked = false;
            }
            else
                btnViewTiles.Checked = true;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.task.IsCompleted)
            {
                //Gọi hàm refresh lại tất cả các giao diện ở form1
                if (getRefreshAll != null)
                    getRefreshAll();

                //Dừng bộ đếm khi đã kết thúc tiến trình
                this.timer.Stop();
            }
        }

    }

}
