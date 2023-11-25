using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Media;

namespace OldMan
{
    public partial class handler : Form
    {
        public event Action<List<int>> TimersChanged;

        private List<int> timers = new List<int>();
        public List<int> Timers
        {
            get => timers;
            set
            {
                timers = value;
                // Raise the event when the timers list changes
                TimersChanged?.Invoke(timers);
            }
        }

        public handler()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
        }

        public async void SpawnOldMan(int minTime, int maxTime)
        {
            int waitTime = new Random(Guid.NewGuid().GetHashCode()).Next(minTime, maxTime);
            timers.Add(waitTime);
            TimersChanged?.Invoke(timers);
            await CountTimer(waitTime);

            Application.Run(new Gimp());
        }

        private async Task CountTimer(int waitTime)
        {
            int index = timers.Count - 1; //problem ejst taki ze index sie zmienia ogar to
            int time = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
            waitTime += time;
            while (time < waitTime)
            {
                await Task.Delay(1000);
                time = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
                timers[index] = waitTime - time;
                TimersChanged?.Invoke(timers);
            }
            timers[index] = -1;
            TimersChanged?.Invoke(timers);
        }

        // HIDE FROM TASK MANAGER (a bit)
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

    }
}