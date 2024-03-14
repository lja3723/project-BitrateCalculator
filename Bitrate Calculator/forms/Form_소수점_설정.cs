using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class _Form_SetDecimalPoint : Form
    {
        private static bool isCreated;
        public static bool IsCreated
        {
            get { return isCreated; }
        }

        Form_Main formMain;

        public _Form_SetDecimalPoint(Form_Main formMain)
        {
            isCreated = true;
            InitializeComponent();
            this.formMain = formMain;
            numericUpDown_영상_비트레이트_소수점.Value = formMain.GetVBDecimalPoint();
            numericUpDown_용량_소수점.Value = formMain.GetCpctDecimalPoint();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            formMain.SetDecimalPoint((int)numericUpDown_영상_비트레이트_소수점.Value, (int)numericUpDown_용량_소수점.Value);
            formMain.UpdateFormMainState();
            Close();
            isCreated = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
            isCreated = false;
        }
    }
}
