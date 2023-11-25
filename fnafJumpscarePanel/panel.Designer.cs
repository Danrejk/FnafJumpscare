namespace fnafJumpscarePanel
{
    partial class panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel));
            this.jumpscareMe = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.Label();
            this.pickFnafMonster = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.spawnOldMan = new System.Windows.Forms.Button();
            this.maxTimeOldMan = new System.Windows.Forms.NumericUpDown();
            this.minTimeOldMan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoRepeat = new System.Windows.Forms.CheckBox();
            this.oldWithJumpscare = new System.Windows.Forms.CheckBox();
            this.handlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.keepAfterFail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeOldMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeOldMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // jumpscareMe
            // 
            this.jumpscareMe.Location = new System.Drawing.Point(141, 135);
            this.jumpscareMe.Name = "jumpscareMe";
            this.jumpscareMe.Size = new System.Drawing.Size(181, 65);
            this.jumpscareMe.TabIndex = 0;
            this.jumpscareMe.Text = "Jumpscare me!";
            this.jumpscareMe.UseVisualStyleBackColor = true;
            this.jumpscareMe.Click += new System.EventHandler(this.jumpscareMe_Click);
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Location = new System.Drawing.Point(12, 39);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(121, 13);
            this.timerText.TabIndex = 1;
            this.timerText.Text = "No pending Jumpscares";
            // 
            // pickFnafMonster
            // 
            this.pickFnafMonster.FormattingEnabled = true;
            this.pickFnafMonster.Location = new System.Drawing.Point(141, 78);
            this.pickFnafMonster.Name = "pickFnafMonster";
            this.pickFnafMonster.Size = new System.Drawing.Size(121, 21);
            this.pickFnafMonster.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose your Jumpscare:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay in Seconds:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(141, 105);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // spawnOldMan
            // 
            this.spawnOldMan.Location = new System.Drawing.Point(98, 331);
            this.spawnOldMan.Name = "spawnOldMan";
            this.spawnOldMan.Size = new System.Drawing.Size(147, 69);
            this.spawnOldMan.TabIndex = 8;
            this.spawnOldMan.Text = "Turn on the Old Man";
            this.spawnOldMan.UseVisualStyleBackColor = true;
            this.spawnOldMan.Click += new System.EventHandler(this.spawnOldMan_Click);
            // 
            // maxTimeOldMan
            // 
            this.maxTimeOldMan.Location = new System.Drawing.Point(98, 299);
            this.maxTimeOldMan.Name = "maxTimeOldMan";
            this.maxTimeOldMan.Size = new System.Drawing.Size(120, 20);
            this.maxTimeOldMan.TabIndex = 9;
            // 
            // minTimeOldMan
            // 
            this.minTimeOldMan.Location = new System.Drawing.Point(98, 273);
            this.minTimeOldMan.Name = "minTimeOldMan";
            this.minTimeOldMan.Size = new System.Drawing.Size(120, 20);
            this.minTimeOldMan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max Delay";
            // 
            // autoRepeat
            // 
            this.autoRepeat.AutoSize = true;
            this.autoRepeat.Location = new System.Drawing.Point(251, 331);
            this.autoRepeat.Name = "autoRepeat";
            this.autoRepeat.Size = new System.Drawing.Size(86, 17);
            this.autoRepeat.TabIndex = 13;
            this.autoRepeat.Text = "Auto Repeat";
            this.autoRepeat.UseVisualStyleBackColor = true;
            // 
            // oldWithJumpscare
            // 
            this.oldWithJumpscare.AutoSize = true;
            this.oldWithJumpscare.Checked = true;
            this.oldWithJumpscare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oldWithJumpscare.Location = new System.Drawing.Point(251, 354);
            this.oldWithJumpscare.Name = "oldWithJumpscare";
            this.oldWithJumpscare.Size = new System.Drawing.Size(102, 17);
            this.oldWithJumpscare.TabIndex = 14;
            this.oldWithJumpscare.Text = "With Jumpscare";
            this.oldWithJumpscare.UseVisualStyleBackColor = true;
            // 
            // handlerBindingSource
            // 
            this.handlerBindingSource.DataSource = typeof(fnafJumpscare.handler);
            // 
            // handlerBindingSource1
            // 
            this.handlerBindingSource1.DataSource = typeof(fnafJumpscare.handler);
            // 
            // keepAfterFail
            // 
            this.keepAfterFail.AutoSize = true;
            this.keepAfterFail.Location = new System.Drawing.Point(251, 377);
            this.keepAfterFail.Name = "keepAfterFail";
            this.keepAfterFail.Size = new System.Drawing.Size(123, 17);
            this.keepAfterFail.TabIndex = 15;
            this.keepAfterFail.Text = "Keep going after Fail";
            this.keepAfterFail.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.keepAfterFail);
            this.Controls.Add(this.oldWithJumpscare);
            this.Controls.Add(this.autoRepeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minTimeOldMan);
            this.Controls.Add(this.maxTimeOldMan);
            this.Controls.Add(this.spawnOldMan);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickFnafMonster);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.jumpscareMe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTimeOldMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeOldMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jumpscareMe;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.BindingSource handlerBindingSource;
        private System.Windows.Forms.ComboBox pickFnafMonster;
        private System.Windows.Forms.BindingSource handlerBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button spawnOldMan;
        private System.Windows.Forms.NumericUpDown maxTimeOldMan;
        private System.Windows.Forms.NumericUpDown minTimeOldMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox autoRepeat;
        private System.Windows.Forms.CheckBox oldWithJumpscare;
        private System.Windows.Forms.CheckBox keepAfterFail;
    }
}

