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
            
        }

        private void btnPack_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.PackingForm packingForm = new GUI.PackingForm();
            packingForm.ShowDialog();
        }
    }
}