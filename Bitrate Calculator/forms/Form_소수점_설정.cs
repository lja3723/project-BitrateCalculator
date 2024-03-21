using Bitrate_Calculator.src;
using System;
using System.Runtime.CompilerServices;
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

        private Action refreshProgram;
        private ResultPrecisionManager precision;

        public _Form_SetDecimalPoint(Action programRefresher, ResultPrecisionManager precision)
        {
            isCreated = true;
            InitializeComponent();
            this.refreshProgram = programRefresher;
            this.precision = precision;
            numericUpDown_영상_비트레이트_소수점.Value = precision.BitratePrecision;
            numericUpDown_용량_소수점.Value = precision.CapacityPrecision;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            precision.BitratePrecision = (uint)numericUpDown_영상_비트레이트_소수점.Value;
            precision.CapacityPrecision = (uint)numericUpDown_용량_소수점.Value;
            refreshProgram();
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
