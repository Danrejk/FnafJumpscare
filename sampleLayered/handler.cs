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

namespace fnafJumpscare
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

        private jumpscare currentJumpscare;
        ResourceManager resourceManager = Properties.Resources.ResourceManager;
        // LIST OF ADDED JUMPSCARES
        public string[] jumpscareList = Properties.Settings.Default.fnafMonsterList.Split(new[] {';'}); // add new jumpscares using settings.settings with ; as a separator

        public handler()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
        }

        // ANIMATION
        public List<string> FrameList(int jsNum)
        {
            string[] resources = resourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true)
                .OfType<System.Collections.DictionaryEntry>()
                .Select(entry => entry.Key.ToString())
                .ToArray();

            List<string> animlist = new List<string>();
            foreach (string r in resources)
            {
                if (r.Contains(jumpscareList[jsNum]) && !r.Contains("Audio"))
                {
                    animlist.Add(r);
                }
            }
            animlist.Sort(CompareNum); // sort list
            return animlist;
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
                timers[index] = waitTime-time;
                TimersChanged?.Invoke(timers);
            }
            timers[index] = -1;
            TimersChanged?.Invoke(timers);
        }

        bool jumpscareInProgress;
        public async void Animation(int jsNum = 0, int waitTime = 0) // use negative values to get a randomly generated ones
        {
            if (jsNum <= 0) jsNum = new Random(Guid.NewGuid().GetHashCode()).Next(1, jumpscareList.Length);
            if (waitTime <= 0) waitTime = new Random(Guid.NewGuid().GetHashCode()).Next((int)(Properties.Settings.Default.timerMin * 60), (int)(Properties.Settings.Default.timerMax * 60));
            timers.Add(waitTime);
            TimersChanged?.Invoke(timers);
            await CountTimer(waitTime);

            if ( jumpscareInProgress == true )
            {
                await Task.Delay(5000);
            }

            jumpscareInProgress = true;

            SoundPlayer jssound = new SoundPlayer(Properties.Resources.jumpscareAudio2);
            switch (jsNum) // add custom sounds for specific jumpscares
            {
                case 3:
                    jssound = new SoundPlayer(Properties.Resources.jumpscareAudio1);
                    break;
                case 5:
                    jssound = new SoundPlayer(Properties.Resources.jumpscareAudio1deep);
                    break;

            }
            

            List<string> animlist = FrameList(jsNum);
            string resourceName = $"{jumpscareList[jsNum]}1";
            object resource = resourceManager.GetObject(resourceName);

            // play jumpscare animation
            if (resource is Bitmap iniframe) { currentJumpscare = new jumpscare(iniframe); }
            await Task.Delay(200);

            jssound.Play();
            for (int i = 0; i < animlist.Count; i++)
            {
                resourceName = jumpscareList[jsNum] + i;
                resource = resourceManager.GetObject(resourceName);

                if (resource is Bitmap frame)
                {
                    currentJumpscare.ggGoNext(frame);
                }
            }
            await Task.Delay(300);

            // play static
            List<string> staticlist = FrameList(0);

            SoundPlayer stsound = new SoundPlayer(Properties.Resources.staticAudio);
            jssound.Stop();
            stsound.Play();

            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < staticlist.Count; i++)
                {
                    resourceName = "static" + i;
                    resource = resourceManager.GetObject(resourceName);
                    if (resource is Bitmap frame)
                    {
                        currentJumpscare.ggGoNext(frame);
                    }
                }
            }
            await Task.Delay(300);
            stsound.Stop();
            currentJumpscare.Close();  
            this.Close();
            jumpscareInProgress = false;
        }

        // SORTING FUNCTIONS
        static int CompareNum(string a, string b)
        {
            int aNumSuffix = NumSuffix(a);
            int bNumSuffix = NumSuffix(b);
            return aNumSuffix.CompareTo(bNumSuffix);
        }
        static int NumSuffix(string s)
        {
            string numericPart = new string(s.Reverse().TakeWhile(char.IsDigit).Reverse().ToArray());

            if (int.TryParse(numericPart, out int result)) { return result; }
            else { return 0; }
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
