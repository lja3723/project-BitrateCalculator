using Bitrate_Calculator.src;
using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class Form_소수점_설정 : Form
    {
        private static bool isCreated;
        public static bool IsCreated
        {
            get { return isCreated; }
        }

        private readonly Action refreshProgram;
        private readonly ResultPrecision precision;

        public Form_소수점_설정(Action programRefresher, ResultPrecision precision)
        {
            InitializeComponent();

            isCreated = true;
            refreshProgram = programRefresher;
            this.precision = precision;

            numericUpDown_영상_비트레이트_소수점.Value = precision.BitrateField;
            numericUpDown_용량_소수점.Value = precision.CapacityField;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            precision.BitrateField = (uint)numericUpDown_영상_비트레이트_소수점.Value;
            precision.CapacityField = (uint)numericUpDown_용량_소수점.Value;

            refreshProgram();
            isCreated = false;
            Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            isCreated = false;
            Close();
        }
    }
}
