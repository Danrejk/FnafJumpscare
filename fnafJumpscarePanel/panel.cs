using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using fnafJumpscare;
using OldManConsequences;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fnafJumpscarePanel
{    
    public partial class panel : Form
    {
        private handler fnafHandler;
        List<int> jumpscareList = new List<int>();

        private handlerOldMan oldManHandler;

        public panel()
        {
            InitializeComponent();

            fnafHandler = new handler();
            fnafHandler.TimersChanged += UpdateTextBox;

            oldManHandler = new handlerOldMan();

            string[] pickFMlist = fnafHandler.jumpscareList;
            pickFnafMonster.Items.AddRange(pickFMlist);
            pickFnafMonster.Items[0] = "RANDOM";
            pickFnafMonster.SelectedIndex = 0;
            pickFnafMonster.DropDownStyle = ComboBoxStyle.DropDownList;

            jumpscareTimerList();
        }
        private void UpdateTextBox(List<int> newTimers)
        {
            List<int> newTimersSorted = newTimers.Where(t => t > 0).ToList();
            if (newTimersSorted.Count > 0)
            {
                int minTimer = newTimersSorted.Min();
                timerText.Text = $"Next Jumpscare in: {minTimer}s\nAll pending Jumpscares: {string.Join("s, ", newTimersSorted)}s";
            }
            else { timerText.Text = "No pending Jumpscares"; }
        }

        private void jumpscareMe_Click(object sender, EventArgs e)
        {
            fnafHandler.Animation(pickFnafMonster.SelectedIndex, (int)jumpscareDelay.Value, keepAfterFail.Checked);
            Console.WriteLine(pickFnafMonster.SelectedIndex.ToString());
        }

        private async void jumpscareTimerList()
        {
            while (jumpscareList != null)
            {
                await Task.Delay(100);

                for (int i = 0; i < jumpscareList.Count; i++)
                {
                    int currentTimer = jumpscareList[i];
                    jumpscareList[i] = currentTimer - 1;


                    timerText.Text = jumpscareList.Min().ToString().Insert(jumpscareList.Min().ToString().Length-1,".");

                    if (currentTimer <= 1)
                    {
                        jumpscareList.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spawnOldMan_Click(object sender, EventArgs e)
        {
            oldManHandler.SpawnOldMan((int)minTimeOldMan.Value, (int)maxTimeOldMan.Value, autoRepeat.Checked, keepAfterFail.Checked);
        }
    }
}
