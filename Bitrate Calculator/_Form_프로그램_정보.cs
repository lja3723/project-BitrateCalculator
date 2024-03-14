using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class _Form_프로그램_정보 : Form
    {
        private static bool isCreated;
        public static bool IsCreated
        {
            get { return isCreated; }
        }

        public _Form_프로그램_정보()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            isCreated = false;
        }
    }
}
