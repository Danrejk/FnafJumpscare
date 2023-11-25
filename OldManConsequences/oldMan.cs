using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace OldManConsequences
{
    public partial class Gimp : Form
    {
        //variables you can adjust
        public int speed = 10; //how much pixels fish travels in 0.025 seconds
        public int timeLimit = 200; //time limit (40 = 1 second)

        //DO NOT MODIFY variables needed for correct work of program 
        bool click = false;
        int timer = 0;
        public Gimp()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.Show();
            Ruszanie(true);
            var thread = new Thread(LoopClick) { };
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Ruszanie(true);
            //thread cos SoundPlayer.PlayLoop does not have delay
            //var thread = new Thread(LoopClick) { };
            //thread.Start();
        }

        bool ongoing = true;
        public async void Ruszanie(bool goesRight)
        {
            //i basicly copied same code twice with difference beeing incrementation/decramentation and image (could be more efficient)
            if (goesRight)
            {
                pictureBox1.Image = Properties.Resources._167;
                for (int i = 100; i < 350; i = i + 10)
                {

                    pictureBox1.Location = new Point(i, 215);
                    await Task.Delay(25);
                    //checking of player click (could be more efficient)
                    if (click == true)
                    {
                        if (pictureBox1.Location.X > 200 && pictureBox1.Location.X < 250)
                        {
                            new SoundPlayer(Properties.Resources.fish4).PlaySync();
                            click = false;
                            this.Close();
                            ongoing = false;

                        }
                        else
                        {
                            playerMissed();
                            click = false;
                            ongoing = false;
                        }
                    }
                    timer++;
                    if (timer >= timeLimit)
                    {
                        click = true;
                        playerMissed();
                        click = false;
                        ongoing = false;
                    }
                }
                if (timer < timeLimit && ongoing == true)
                {
                    Ruszanie(false);
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources._164;
                for (int i = 350; i > 100; i = i - 10)
                {
                    pictureBox1.Location = new Point(i, 215);
                    await Task.Delay(25);
                    if (click == true)
                    {
                        //the same as above
                        if (pictureBox1.Location.X > 200 && pictureBox1.Location.X < 250)
                        {
                            new SoundPlayer(Properties.Resources.fish4).PlaySync();
                            click = false;
                            this.Close();
                            ongoing = false;

                        }
                        else
                        {
                            playerMissed();
                            click = false;
                            ongoing = false;
                        }
                    }
                    timer++;

                    if (timer >= timeLimit)
                    {
                        click = true;
                        playerMissed();
                        click = false;
                        ongoing = false;
                    }
                }
                if (timer < timeLimit && ongoing == true)
                {
                    Ruszanie(true);
                }
            }

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('c'))
            {
                //yes I use global variable, if true it ends the game and determisnes if player win or lose
                click = true;
            }
        }

        private void LoopClick()
        {
            while (!click)
            {
                new SoundPlayer(Properties.Resources.fish1).Play();
                Thread.Sleep(250);
            }
        }

        public void playerMissed()
        {
            for (int i = 0; i < 3; i++)
            {
                new SoundPlayer(Properties.Resources.fish3).PlaySync();
            }
            this.Close();
            //insert function that will activate after player loosing
        }
    }
}
