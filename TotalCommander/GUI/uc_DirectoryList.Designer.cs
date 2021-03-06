﻿namespace TotalCommander.GUI
{
    partial class uc_DirectoryList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DirectoryList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnForward = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpTo = new DevExpress.XtraBars.BarButtonItem();
            this.chkNavigationPane = new DevExpress.XtraBars.BarCheckItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnView = new DevExpress.XtraBars.BarSubItem();
            this.btnViewLarge = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewSmall = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewList = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewDetail = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewTiles = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cbPath = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splitUserControl = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.imListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.lvMain = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUnpack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuItemNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subMenuItemNewTextDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.imList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitUserControl)).BeginInit();
            this.splitUserControl.Panel1.SuspendLayout();
            this.splitUserControl.Panel2.SuspendLayout();
            this.splitUserControl.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnBack,
            this.btnForward,
            this.btnUpTo,
            this.chkNavigationPane,
            this.btnRefresh,
            this.btnView,
            this.btnViewDetail,
            this.btnViewTiles,
            this.btnViewList,
            this.btnViewSmall,
            this.btnViewLarge});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 28;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(876, 31);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBack.Glyph")));
            this.btnBack.Id = 1;
            this.btnBack.Name = "btnBack";
            this.btnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBack_ItemClick);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Glyph = ((System.Drawing.Image)(resources.GetObject("btnForward.Glyph")));
            this.btnForward.Id = 2;
            this.btnForward.Name = "btnForward";
            this.btnForward.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnForward_ItemClick);
            // 
            // btnUpTo
            // 
            this.btnUpTo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUpTo.Glyph")));
            this.btnUpTo.Id = 3;
            this.btnUpTo.Name = "btnUpTo";
            this.btnUpTo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpTo_ItemClick);
            // 
            // chkNavigationPane
            // 
            this.chkNavigationPane.BindableChecked = true;
            this.chkNavigationPane.Caption = "Navigation Pane";
            this.chkNavigationPane.Checked = true;
            this.chkNavigationPane.Glyph = ((System.Drawing.Image)(resources.GetObject("chkNavigationPane.Glyph")));
            this.chkNavigationPane.Id = 5;
            this.chkNavigationPane.Name = "chkNavigationPane";
            this.chkNavigationPane.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chkNavigationPane_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 9;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnView
            // 
            this.btnView.Caption = "View";
            this.btnView.Id = 19;
            this.btnView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewLarge),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewSmall),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewDetail),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewTiles)});
            this.btnView.Name = "btnView";
            // 
            // btnViewLarge
            // 
            this.btnViewLarge.Caption = "Large Icons";
            this.btnViewLarge.Id = 27;
            this.btnViewLarge.Name = "btnViewLarge";
            this.btnViewLarge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewLarge_ItemClick);
            // 
            // btnViewSmall
            // 
            this.btnViewSmall.Caption = "Small Icons";
            this.btnViewSmall.Id = 25;
            this.btnViewSmall.Name = "btnViewSmall";
            this.btnViewSmall.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewSmall_ItemClick);
            // 
            // btnViewList
            // 
            this.btnViewList.Caption = "List";
            this.btnViewList.Id = 24;
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewList_ItemClick);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BindableChecked = true;
            this.btnViewDetail.Caption = "Detail";
            this.btnViewDetail.Checked = true;
            this.btnViewDetail.Id = 21;
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewDetail_ItemClick);
            // 
            // btnViewTiles
            // 
            this.btnViewTiles.Caption = "Tiles";
            this.btnViewTiles.Id = 22;
            this.btnViewTiles.Name = "btnViewTiles";
            this.btnViewTiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTiles_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBack);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnForward);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.chkNavigationPane);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnView);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // cbPath
            // 
            this.cbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPath.Location = new System.Drawing.Point(0, 31);
            this.cbPath.Margin = new System.Windows.Forms.Padding(2);
            this.cbPath.MenuManager = this.ribbonControl1;
            this.cbPath.Name = "cbPath";
            this.cbPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbPath.Properties.Appearance.Options.UseFont = true;
            this.cbPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPath.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPath_Properties_KeyPress);
            this.cbPath.Size = new System.Drawing.Size(876, 20);
            this.cbPath.TabIndex = 0;
            this.cbPath.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.cbPath_Properties_QueryCloseUp);
            this.cbPath.TextChanged += new System.EventHandler(this.cbPath_TextChanged);
            // 
            // splitUserControl
            // 
            this.splitUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitUserControl.Location = new System.Drawing.Point(0, 51);
            this.splitUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.splitUserControl.Name = "splitUserControl";
            // 
            // splitUserControl.Panel1
            // 
            this.splitUserControl.Panel1.Controls.Add(this.tvMain);
            // 
            // splitUserControl.Panel2
            // 
            this.splitUserControl.Panel2.Controls.Add(this.lvMain);
            this.splitUserControl.Size = new System.Drawing.Size(876, 493);
            this.splitUserControl.SplitterDistance = 238;
            this.splitUserControl.SplitterWidth = 3;
            this.splitUserControl.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMain.FullRowSelect = true;
            this.tvMain.HideSelection = false;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.imListTreeView;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Margin = new System.Windows.Forms.Padding(2);
            this.tvMain.Name = "tvMain";
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(238, 493);
            this.tvMain.StateImageList = this.imListTreeView;
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterExpand);
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect);
            // 
            // imListTreeView
            // 
            this.imListTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imListTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.imListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvMain
            // 
            this.lvMain.AllowDrop = true;
            this.lvMain.ContextMenuStrip = this.contextMenu;
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMain.LabelEdit = true;
            this.lvMain.LargeImageList = this.imList;
            this.lvMain.Location = new System.Drawing.Point(0, 0);
            this.lvMain.Margin = new System.Windows.Forms.Padding(2);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(635, 493);
            this.lvMain.SmallImageList = this.imList;
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvMain_AfterLabelEdit);
            this.lvMain.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvMain_BeforeLabelEdit);
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
//            this.lvMain.Click += new System.EventHandler(this.lvMain_Click);
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            this.lvMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvMain_KeyDown);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemRefresh,
            this.menuItemPack,
            this.menuItemUnpack,
            this.menuItemCopy,
            this.menuItemCut,
            this.menuItemPaste,
            this.menuItemDelete,
            this.menuItemNew});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(149, 238);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Enabled = false;
            this.menuItemOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuItemOpen.Image")));
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(148, 26);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Image = global::TotalCommander.Properties.Resources.refresh;
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(148, 26);
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItemRefresh_Click);
            // 
            // menuItemPack
            // 
            this.menuItemPack.Image = global::TotalCommander.Properties.Resources.packIcon;
            this.menuItemPack.Name = "menuItemPack";
            this.menuItemPack.Size = new System.Drawing.Size(148, 26);
            this.menuItemPack.Text = "Pack";
            this.menuItemPack.Click += new System.EventHandler(this.menuItemPack_Click);
            // 
            // menuItemUnpack
            // 
            this.menuItemUnpack.Image = global::TotalCommander.Properties.Resources.unpackIcon;
            this.menuItemUnpack.Name = "menuItemUnpack";
            this.menuItemUnpack.Size = new System.Drawing.Size(148, 26);
            this.menuItemUnpack.Text = "Unpack";
            this.menuItemUnpack.Click += new System.EventHandler(this.menuItemUnpack_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Enabled = false;
            this.menuItemCopy.Image = global::TotalCommander.Properties.Resources.copyIcon;
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItemCopy.Size = new System.Drawing.Size(148, 26);
            this.menuItemCopy.Text = "Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Enabled = false;
            this.menuItemCut.Image = global::TotalCommander.Properties.Resources.cutIcon;
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemCut.Size = new System.Drawing.Size(148, 26);
            this.menuItemCut.Text = "Cut";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Enabled = false;
            this.menuItemPaste.Image = global::TotalCommander.Properties.Resources.paste_32x321;
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemPaste.Size = new System.Drawing.Size(148, 26);
            this.menuItemPaste.Text = "Paste";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Enabled = false;
            this.menuItemDelete.Image = global::TotalCommander.Properties.Resources.delete_32x32;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDelete.Size = new System.Drawing.Size(148, 26);
            this.menuItemDelete.Text = "Delete";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemNew
            // 
            this.menuItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuItemNewFolder,
            this.toolStripSeparator1,
            this.subMenuItemNewTextDocument});
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(148, 26);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // subMenuItemNewFolder
            // 
            this.subMenuItemNewFolder.Image = global::TotalCommander.Properties.Resources.folder;
            this.subMenuItemNewFolder.Name = "subMenuItemNewFolder";
            this.subMenuItemNewFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.subMenuItemNewFolder.Size = new System.Drawing.Size(154, 22);
            this.subMenuItemNewFolder.Text = "Folder";
            this.subMenuItemNewFolder.Click += new System.EventHandler(this.subMenuItemNewFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // subMenuItemNewTextDocument
            // 
            this.subMenuItemNewTextDocument.Image = global::TotalCommander.Properties.Resources.notepadIcon;
            this.subMenuItemNewTextDocument.Name = "subMenuItemNewTextDocument";
            this.subMenuItemNewTextDocument.Size = new System.Drawing.Size(154, 22);
            this.subMenuItemNewTextDocument.Text = "Text Document";
            this.subMenuItemNewTextDocument.Click += new System.EventHandler(this.subMenuItemNewTextDocument_Click);
            // 
            // imList
            // 
            this.imList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imList.ImageSize = new System.Drawing.Size(32, 32);
            this.imList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_DirectoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitUserControl);
            this.Controls.Add(this.cbPath);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_DirectoryList";
            this.Size = new System.Drawing.Size(876, 544);
            this.Load += new System.EventHandler(this.uc_DirectoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPath.Properties)).EndInit();
            this.splitUserControl.Panel1.ResumeLayout(false);
            this.splitUserControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitUserControl)).EndInit();
            this.splitUserControl.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraEditors.ComboBoxEdit cbPath;

        public DevExpress.XtraEditors.ComboBoxEdit CbPath
        {
            get { return cbPath; }
            set { cbPath = value; }
        }
        private System.Windows.Forms.SplitContainer splitUserControl;
        private System.Windows.Forms.TreeView tvMain;

        public System.Windows.Forms.ListView LvMain
        {
            get { return lvMain; }
            set { lvMain = value; }
        }
        private System.Windows.Forms.ImageList imList;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ImageList imListTreeView;
        private DevExpress.XtraBars.BarButtonItem btnForward;
        private DevExpress.XtraBars.BarButtonItem btnUpTo;
        private System.Windows.Forms.ToolStripMenuItem menuItemPack;
        private System.Windows.Forms.ToolStripMenuItem menuItemUnpack;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemNewFolder;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemNewTextDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraBars.BarCheckItem chkNavigationPane;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private System.Windows.Forms.ListView lvMain;
        private DevExpress.XtraBars.BarSubItem btnView;
        private DevExpress.XtraBars.BarCheckItem btnViewLarge;
        private DevExpress.XtraBars.BarCheckItem btnViewSmall;
        private DevExpress.XtraBars.BarCheckItem btnViewList;
        private DevExpress.XtraBars.BarCheckItem btnViewDetail;
        private DevExpress.XtraBars.BarCheckItem btnViewTiles;
    }
}