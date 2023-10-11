﻿namespace fnafJumpscarePanel
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
            this.handlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // jumpscareMe
            // 
            this.jumpscareMe.Location = new System.Drawing.Point(154, 308);
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
            this.pickFnafMonster.Location = new System.Drawing.Point(154, 234);
            this.pickFnafMonster.Name = "pickFnafMonster";
            this.pickFnafMonster.Size = new System.Drawing.Size(121, 21);
            this.pickFnafMonster.TabIndex = 3;
            // 
            // handlerBindingSource
            // 
            this.handlerBindingSource.DataSource = typeof(fnafJumpscare.handler);
            // 
            // handlerBindingSource1
            // 
            this.handlerBindingSource1.DataSource = typeof(fnafJumpscare.handler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose your Jumpscare:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay in Seconds:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(154, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickFnafMonster);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.jumpscareMe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

