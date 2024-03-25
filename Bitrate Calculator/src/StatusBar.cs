using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    /// <summary>
    ///     프로그램 하단의 상태바를 관리한다.
    /// </summary>
    public class StatusBar
    {
        private readonly Timer timer;
        private readonly ToolStripStatusLabel label;

        //statusStrip에 알림이 표시되는 static 시간(ms)
        private const int defaultInterval = 2755;

        public StatusBar(Timer timer, ToolStripStatusLabel label)
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
