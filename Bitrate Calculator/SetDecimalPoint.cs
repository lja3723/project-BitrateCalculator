using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class _Form_SetDecimalPoint : Form
    {
        _Form_Main formMain;
        
        public _Form_SetDecimalPoint(_Form_Main formMain)
        {
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
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
