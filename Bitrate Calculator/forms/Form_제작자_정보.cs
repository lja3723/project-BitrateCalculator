using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class Form_제작자_정보 : Form
    {
        private static bool isCreated;
        public static bool IsCreated
        {
            get { return isCreated; }
        }

        public Form_제작자_정보()
        {
            isCreated = true;
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                isCreated = false;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            isCreated = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://lja3723.github.io");
        }
    }
}
