using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    public class StatusStripManager
    {
        private readonly Timer timer;
        private readonly ToolStripStatusLabel label;

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
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            label.Text = " ";
            timer.Stop();
        }
    }
}
