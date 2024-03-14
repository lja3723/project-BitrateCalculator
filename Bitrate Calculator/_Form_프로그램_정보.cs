using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class _Form_프로그램_정보 : Form
    {
        public _Form_프로그램_정보()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.iconfinder.com/icons/173168/calculator_icon");
        }
    }
}
