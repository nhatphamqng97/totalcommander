using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.Net;

namespace TotalCommander.BLL
{
    class ClassBLL
    {
        private static ClassBLL instances;
        public static ClassBLL Instances
        {
            get
            {
                if (instances == null)
                    instances = new ClassBLL();
                return ClassBLL.instances;
            }
            set { ClassBLL.instances = value; }
        }

        #region File Processing

        public void showDrive(DriveInfo drive, ListView lvMain)
        {
            string text = ((string.IsNullOrEmpty(drive.VolumeLabel)) ? "Local Drive" : drive.VolumeLabel) + " (" + drive.Name + ")";

            lvMain.LargeImageList.Images.Add(BLL.ShellIcon.GetLargeIcon(drive.Name).ToBitmap());
            lvMain.SmallImageList.Images.Add(BLL.ShellIcon.GetLargeIcon(drive.Name).ToBitmap());

            ListViewItem item;

            if (lvMain.View == View.Tile)
            {
                item = new ListViewItem();
            }
            else
            {
                string[] strItem = new string[4];
                strItem[0] = drive.Name;
                strItem[1] = drive.GetType().Name;
                strItem[2] = Math.Round(drive.TotalSize / (Math.Pow(2, 30))).ToString() + " GB";
                strItem[3] = Math.Round(drive.TotalFreeSpace / (Math.Pow(2, 30))).ToString() + " GB";

                item = new ListViewItem(strItem);
            }

            item.Text = text;

            item.Name = drive.Name;

            item.ImageIndex = lvMain.LargeImageList.Images.Count - 1;

            item.Tag = drive.Name;

            lvMain.Items.Add(item);
        }

        public void showDirectory(DirectoryInfo directoryInfo, ListView lvMain)
        {
            lvMain.LargeImageList.Images.Add(BLL.ShellIcon.GetLargeFolderIcon().ToBitmap());
            lvMain.SmallImageList.Images.Add(BLL.ShellIcon.GetLargeFolderIcon().ToBitmap());

            ListViewItem item = new ListViewItem(directoryInfo.Name);

            item.Name = directoryInfo.Name;

            item.ImageIndex = lvMain.LargeImageList.Images.Count - 1;

            item.Tag = directoryInfo.FullName;

            if (lvMain.View == View.Details)
            {
                string[] strItem = new string[2];
                strItem[0] = directoryInfo.CreationTime.ToShortDateString() + " " + directoryInfo.CreationTime.ToLongTimeString();
                strItem[1] = directoryInfo.GetType().Name;

                item.SubItems.AddRange(strItem);
            }


            lvMain.Items.Add(item);
        }

        #region Show File
        private Bitmap readImage(string path, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);

            Image image = Image.FromFile(path);

            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(image, new Rectangle(0, 0, width, height));

            image.Dispose();

            return bmp;
        }

        public void showFile(FileInfo fileInfo, ListView lvMain)
        {
            string[] ImageExtension = new string[] { ".bmp", ".ico", ".gif", ".jpeg", ".jpg", ".jfif", ".png", ".tif", ".tiff", ".wmf", ".emf" };


            ListViewItem item = new ListViewItem();

            item.Name = fileInfo.Name;

            if (fileInfo.Name.Contains('.'))
                item.Text = fileInfo.Name.Remove(fileInfo.Name.LastIndexOf('.'));
            else
                item.Text = fileInfo.Name;

            item.Tag = fileInfo.FullName;

            if (lvMain.View == View.Tile || lvMain.View == View.LargeIcon)
            {
                if (ImageExtension.Contains(fileInfo.Extension.ToLower()))
                {
                    lvMain.LargeImageList.Images.Add(readImage(fileInfo.FullName, lvMain.LargeImageList.ImageSize.Width, lvMain.LargeImageList.ImageSize.Height));
                }
                else
                    lvMain.LargeImageList.Images.Add(BLL.ShellIcon.GetLargeIconFromExtension(fileInfo.FullName).ToBitmap());

            }
            else
            {
                lvMain.SmallImageList.Images.Add(BLL.ShellIcon.GetLargeIconFromExtension(fileInfo.FullName).ToBitmap());

                lvMain.LargeImageList.Images.Add(BLL.ShellIcon.GetLargeIconFromExtension(fileInfo.FullName).ToBitmap());
            }

            if (lvMain.View == View.Details)
            {
                double fileSize = fileInfo.Length;

                string[] Unit = new string[] { " KB", " MB", " GB", " TB" };
                int u = 0;
                do
                {
                    fileSize = fileSize / (Math.Pow(2, 10 * (u + 1)));
                } while (fileSize > 1000 && u < 4);

                fileSize = Math.Round(fileSize, 2);

                string[] strItem = new string[3];
                strItem[0] = fileInfo.CreationTime.ToShortDateString() + " " + fileInfo.CreationTime.ToLongTimeString();
                strItem[1] = fileInfo.GetType().Name;
                strItem[2] = fileSize.ToString() + Unit[u];

                item.SubItems.AddRange(strItem);

            }

            item.ImageIndex = lvMain.LargeImageList.Images.Count - 1;

            lvMain.Items.Add(item);
        }
        #endregion

        public void showDirectoryAndFiles(List<string> listPath, ListView lvMain)//Hiển thị các thư mục và các file hiện tại, hàm trả về đường dẫn mới
        {
            try
            {
                lvMain.LargeImageList.Images.Clear();
                lvMain.SmallImageList.Images.Clear();
                lvMain.Clear();

                if (lvMain.View == View.Details)
                {
                    lvMain.Columns.Add("Name", 200);
                    lvMain.Columns.Add("Date modified", 150);
                    lvMain.Columns.Add("Type", 150);
                    lvMain.Columns.Add("Size", 150);
                }

                foreach (string item in listPath)
                {
                    if (Directory.Exists(item))
                        showDirectory(Microsoft.VisualBasic.FileIO.FileSystem.GetDirectoryInfo(item), lvMain);
                    else
                        showFile(Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo(item), lvMain);
                }

            }
            catch (Exception ex) { }
        }

        #endregion
    }
}
