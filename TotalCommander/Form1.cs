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

namespace TotalCommander
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private GUI.uc_DirectoryList gui1;

        private GUI.uc_DirectoryList gui2;

        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Can't open notepad now!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gui1 = new GUI.uc_DirectoryList(contextMenu);
            gui1.Dock = DockStyle.Fill;
            gui1.getCopyAction = new GUI.uc_DirectoryList.DgetCopyAction(copyAction);
            gui1.getCopyPath = new GUI.uc_DirectoryList.DgetCopyPath(pushCopyPath);
            gui1.getPasteAction = new GUI.uc_DirectoryList.DgetPasteAction(pasteAction);
            gui1.getRefreshAll = new GUI.uc_DirectoryList.DgetRefreshAll(refreshAll);
            gui1.getContextMenu = new GUI.uc_DirectoryList.DgetContextMenu(pushContextMenu);
            gui1.pushContextMenuForParent = new GUI.uc_DirectoryList.DpushContextMenuForParent(setContextMenu);
            gui1.setEnabledButton = new GUI.uc_DirectoryList.DsetEnabledButton(setEnabledForSelectItem);
            splitMain.Panel1.Controls.Add(gui1);
            //------------------------------------------------------------------------------------
            this.gui2 = new GUI.uc_DirectoryList(contextMenu);
            gui2.Dock = DockStyle.Fill;
            gui2.getCopyAction = new GUI.uc_DirectoryList.DgetCopyAction(copyAction);
            gui2.getCopyPath = new GUI.uc_DirectoryList.DgetCopyPath(pushCopyPath);
            gui2.getPasteAction = new GUI.uc_DirectoryList.DgetPasteAction(pasteAction);
            gui2.getRefreshAll = new GUI.uc_DirectoryList.DgetRefreshAll(refreshAll);

            gui2.getContextMenu = new GUI.uc_DirectoryList.DgetContextMenu(pushContextMenu);
            gui2.pushContextMenuForParent = new GUI.uc_DirectoryList.DpushContextMenuForParent(setContextMenu);
            gui2.setEnabledButton = new GUI.uc_DirectoryList.DsetEnabledButton(setEnabledForSelectItem);
            splitMain.Panel2.Controls.Add(gui2);
        }

        public void refreshAll()
        {
            this.gui1.showDirectoryAndFiles(this.gui1.ListBack.Peek());
            this.gui2.showDirectoryAndFiles(this.gui2.ListBack.Peek());
        }

        public void setEnabledForSelectItem(bool isSelected)
        {
            btnCopy.Enabled = btnCut.Enabled = btnDelete.Enabled = btnRename.Enabled = isSelected;
        }

        #region ContextMenu

        private void setContextMenu()//Thay đổi giá trị item của contextMenu tương ứng với các item bên ngoài
        {
            this.contextMenu.Items[0].Enabled = menuItemOpen.Enabled;
            this.contextMenu.Items[1].Enabled = menuItemCopy.Enabled;
            this.contextMenu.Items[2].Enabled = menuItemCut.Enabled;
            this.contextMenu.Items[3].Enabled = menuItemPaste.Enabled;
        }

        //Đẩy contextMenu cho giao diện con
        public ContextMenuStrip pushContextMenu()
        {
            setContextMenu();
            return this.contextMenu;
        }

        //Lấy contextMenu từ giao diện con
        public void setContextMenu(ContextMenuStrip contextMenu)
        {
            this.contextMenu = contextMenu;
        }

        #endregion

        #region Thao Tác với file

        private List<string> listCopyPath { get; set; }

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


        private void btnPack_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.PackingForm packingForm = new GUI.PackingForm();
            packingForm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.Mail mail = new GUI.Mail();
            mail.ShowDialog();
        }
    }
}