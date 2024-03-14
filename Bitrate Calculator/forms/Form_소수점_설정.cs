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

        Main_Form formMain;

        public _Form_SetDecimalPoint(Main_Form formMain)
        {
            isCreated = true;
            InitializeComponent();
            this.formMain = formMain;
            numericUpDown_영상_비트레이트_소수점.Value = formMain.GetBitrateDecimalPoint();
            numericUpDown_용량_소수점.Value = formMain.GetCapacityDecimalPoint();
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
