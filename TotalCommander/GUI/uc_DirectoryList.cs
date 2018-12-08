using System;
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

        #region Show

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
            catch (Exception ex) { }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.showDirectoryAndFiles(this.listBack.Peek());
        }

        #endregion

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        internal void btnBack_ItemClick(object p1, object p2)
        {
            throw new NotImplementedException();
        }
    }

}
