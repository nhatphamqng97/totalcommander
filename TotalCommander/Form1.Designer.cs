﻿using System;

namespace TotalCommander
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPack = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnPack = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.chkOneScreen = new DevExpress.XtraBars.BarCheckItem();
            this.chkTwoScreen = new DevExpress.XtraBars.BarCheckItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnCut = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnRename = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnNoneSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarSubItem();
            this.btnPermanentlyDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRecycleDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotepad = new DevExpress.XtraBars.BarButtonItem();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.btnReviewFind = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Group2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnPack,
            this.btnUnPack,
            this.skinRibbonGalleryBarItem1,
            this.chkOneScreen,
            this.chkTwoScreen,
            this.btnCopy,
            this.btnCut,
            this.btnPaste,
            this.btnRename,
            this.btnSelectAll,
            this.btnNoneSelect,
            this.btnDelete,
            this.btnRecycleDelete,
            this.btnPermanentlyDelete,
            this.btnNotepad,
            this.btnFind,
            this.btnReviewFind,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 29;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1179, 123);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnPack
            // 
            this.btnPack.Caption = "Packing";
            this.btnPack.Id = 1;
            this.btnPack.LargeGlyph = global::TotalCommander.Properties.Resources.packIcon;
            this.btnPack.Name = "btnPack";
            // 
            // btnUnPack
            // 
            this.btnUnPack.Caption = "UnPacking";
            this.btnUnPack.Id = 2;
            this.btnUnPack.LargeGlyph = global::TotalCommander.Properties.Resources.unpackIcon;
            this.btnUnPack.Name = "btnUnPack";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // chkOneScreen
            // 
            this.chkOneScreen.Caption = "One Screen";
            this.chkOneScreen.Id = 7;
            this.chkOneScreen.LargeGlyph = global::TotalCommander.Properties.Resources.oneScreenIcon;
            this.chkOneScreen.Name = "chkOneScreen";
            // 
            // chkTwoScreen
            // 
            this.chkTwoScreen.BindableChecked = true;
            this.chkTwoScreen.Caption = "Two Screen";
            this.chkTwoScreen.Checked = true;
            this.chkTwoScreen.Id = 8;
            this.chkTwoScreen.LargeGlyph = global::TotalCommander.Properties.Resources.twoScreenIcon;
            this.chkTwoScreen.Name = "chkTwoScreen";
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Copy";
            this.btnCopy.Enabled = false;
            this.btnCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.Glyph")));
            this.btnCopy.Id = 1;
            this.btnCopy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.LargeGlyph")));
            this.btnCopy.Name = "btnCopy";
            // 
            // btnCut
            // 
            this.btnCut.Caption = "Cut";
            this.btnCut.Enabled = false;
            this.btnCut.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCut.Glyph")));
            this.btnCut.Id = 2;
            this.btnCut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCut.LargeGlyph")));
            this.btnCut.Name = "btnCut";
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Paste";
            this.btnPaste.Enabled = false;
            this.btnPaste.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPaste.Glyph")));
            this.btnPaste.Id = 3;
            this.btnPaste.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPaste.LargeGlyph")));
            this.btnPaste.Name = "btnPaste";
            // 
            // btnRename
            // 
            this.btnRename.Caption = "Rename";
            this.btnRename.Enabled = false;
            this.btnRename.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRename.Glyph")));
            this.btnRename.Id = 5;
            this.btnRename.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRename.LargeGlyph")));
            this.btnRename.Name = "btnRename";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Caption = "Select All";
            this.btnSelectAll.Glyph = global::TotalCommander.Properties.Resources.selecttable_32x32;
            this.btnSelectAll.Id = 6;
            this.btnSelectAll.Name = "btnSelectAll";
            // 
            // btnNoneSelect
            // 
            this.btnNoneSelect.Caption = "None Select";
            this.btnNoneSelect.Glyph = global::TotalCommander.Properties.Resources.no_border_32x321;
            this.btnNoneSelect.Id = 7;
            this.btnNoneSelect.Name = "btnNoneSelect";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btnDelete.GlyphDisabled")));
            this.btnDelete.Id = 13;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPermanentlyDelete),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.btnDelete.Name = "btnDelete";
            // 
            // btnPermanentlyDelete
            // 
            this.btnPermanentlyDelete.Caption = "Permanently Delete";
            this.btnPermanentlyDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPermanentlyDelete.Glyph")));
            this.btnPermanentlyDelete.Id = 15;
            this.btnPermanentlyDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPermanentlyDelete.LargeGlyph")));
            this.btnPermanentlyDelete.Name = "btnPermanentlyDelete";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Recycle Bin";
            this.barButtonItem1.Glyph = global::TotalCommander.Properties.Resources.recycleBinIcon;
            this.barButtonItem1.Id = 28;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnRecycleDelete
            // 
            this.btnRecycleDelete.Caption = "Recycle";
            this.btnRecycleDelete.Id = 14;
            this.btnRecycleDelete.ImageUri.Uri = "ExportToRTF";
            this.btnRecycleDelete.Name = "btnRecycleDelete";
            // 
            // btnNotepad
            // 
            this.btnNotepad.Caption = "Notepad";
            this.btnNotepad.Id = 16;
            this.btnNotepad.Name = "btnNotepad";
            // 
            // btnFind
            // 
            this.btnFind.Caption = "Find";
            this.btnFind.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFind.Glyph")));
            this.btnFind.Id = 23;
            this.btnFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFind.LargeGlyph")));
            this.btnFind.Name = "btnFind";
            // 
            // btnReviewFind
            // 
            this.btnReviewFind.Caption = "Review Find";
            this.btnReviewFind.Enabled = false;
            this.btnReviewFind.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReviewFind.Glyph")));
            this.btnReviewFind.Id = 24;
            this.btnReviewFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReviewFind.LargeGlyph")));
            this.btnReviewFind.Name = "btnReviewFind";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Notepad";
            this.barButtonItem2.Id = 26;
            this.barButtonItem2.LargeGlyph = global::TotalCommander.Properties.Resources.notepadIcon;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Mail";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 27;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Group2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // Group2
            // 
            this.Group2.ItemLinks.Add(this.chkOneScreen);
            this.Group2.ItemLinks.Add(this.chkTwoScreen);
            this.Group2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.Group2.ItemLinks.Add(this.btnCopy, true);
            this.Group2.ItemLinks.Add(this.btnCut);
            this.Group2.ItemLinks.Add(this.btnPaste);
            this.Group2.ItemLinks.Add(this.btnDelete, true);
            this.Group2.ItemLinks.Add(this.btnRename);
            this.Group2.ItemLinks.Add(this.btnFind, true);
            this.Group2.ItemLinks.Add(this.btnReviewFind);
            this.Group2.ItemLinks.Add(this.btnPack, true);
            this.Group2.ItemLinks.Add(this.btnUnPack);
            this.Group2.ItemLinks.Add(this.btnSelectAll, true);
            this.Group2.ItemLinks.Add(this.btnNoneSelect);
            this.Group2.Name = "Group2";
            this.Group2.ShowCaptionButton = false;
            this.Group2.Text = "View";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Application";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemCopy,
            this.menuItemCut,
            this.menuItemPaste,
            this.menuItemDelete,
            this.menuItemNewFolder});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(178, 136);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Enabled = false;
            this.menuItemOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(177, 22);
            this.menuItemOpen.Text = "Open";
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Enabled = false;
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItemCopy.Size = new System.Drawing.Size(177, 22);
            this.menuItemCopy.Text = "Copy";
            // 
            // menuItemCut
            // 
            this.menuItemCut.Enabled = false;
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemCut.Size = new System.Drawing.Size(177, 22);
            this.menuItemCut.Text = "Cut";
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Enabled = false;
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemPaste.Size = new System.Drawing.Size(177, 22);
            this.menuItemPaste.Text = "Paste";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Enabled = false;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDelete.Size = new System.Drawing.Size(177, 22);
            this.menuItemDelete.Text = "Delete";
            // 
            // menuItemNewFolder
            // 
            this.menuItemNewFolder.Name = "menuItemNewFolder";
            this.menuItemNewFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNewFolder.Size = new System.Drawing.Size(177, 22);
            this.menuItemNewFolder.Text = "New Folder";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1179, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel6.Text = "Enter Open";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "F2 Rename";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel2.Text = "Ctrl+C Copy";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel3.Text = "Ctrl+X Cut";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel4.Text = "Ctrl+V Paste";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel5.Text = "Ctrl+N New Folder";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 123);
            this.splitMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMain.Name = "splitMain";
            this.splitMain.Size = new System.Drawing.Size(1179, 483);
            this.splitMain.SplitterDistance = 589;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 628);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Commander";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewFolder;
        private DevExpress.XtraBars.BarButtonItem btnPack;
        private DevExpress.XtraBars.BarButtonItem btnUnPack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.SplitContainer splitMain;
        private DevExpress.XtraBars.BarCheckItem chkOneScreen;
        private DevExpress.XtraBars.BarCheckItem chkTwoScreen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnCut;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.BarButtonItem btnRename;
        private DevExpress.XtraBars.BarButtonItem btnSelectAll;
        private DevExpress.XtraBars.BarButtonItem btnNoneSelect;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarSubItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRecycleDelete;
        private DevExpress.XtraBars.BarButtonItem btnPermanentlyDelete;
        private DevExpress.XtraBars.BarButtonItem btnNotepad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Group2;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.BarButtonItem btnReviewFind;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

