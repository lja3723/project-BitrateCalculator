using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    internal class StatusStripManager
    {
        private Timer timer;
        private ToolStripStatusLabel label;

        //statusStrip에 알림이 표시되는 static 시간(ms)
        private const int defaultInterval = 2755;

        public StatusStripManager(Timer timer, ToolStripStatusLabel label)
        {
            this.timer = timer;
            this.label = label;
        }

        public void ShowMessage(string msg, int msInterval = defaultInterval)
        {
            label.Text = msg;
            TimerStart(msInterval);
        }

        public void ShowErrorMessage(string msg, int msInterval = defaultInterval)
        {
            System.Media.SystemSounds.Asterisk.Play();
            ShowMessage(msg, msInterval);
        }

        private void TimerStart(int msInterval)
        {
            if (timer.Enabled == true)
                timer.Stop();
            timer.Interval = msInterval;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            label.Text = " ";
            timer.Stop();
        }
    }
}
