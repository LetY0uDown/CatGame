namespace CatGame
{
    partial class Form1
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.bSleep = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.bFeed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGameName = new System.Windows.Forms.Label();
            this.bExit = new FontAwesome.Sharp.IconButton();
            this.iconCat = new FontAwesome.Sharp.IconPictureBox();
            this.labelHungryState = new System.Windows.Forms.Label();
            this.labelMoodState = new System.Windows.Forms.Label();
            this.labelSleepState = new System.Windows.Forms.Label();
            this.labelCatName = new System.Windows.Forms.Label();
            this.labelDeath = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.bSleep);
            this.panelButtons.Controls.Add(this.bPlay);
            this.panelButtons.Controls.Add(this.bFeed);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 428);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(418, 90);
            this.panelButtons.TabIndex = 0;
            // 
            // bSleep
            // 
            this.bSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.bSleep.Dock = System.Windows.Forms.DockStyle.Left;
            this.bSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSleep.Font = new System.Drawing.Font("Tahoma", 16F);
            this.bSleep.Location = new System.Drawing.Point(280, 0);
            this.bSleep.Name = "bSleep";
            this.bSleep.Size = new System.Drawing.Size(140, 90);
            this.bSleep.TabIndex = 2;
            this.bSleep.Text = "Поспать";
            this.bSleep.UseVisualStyleBackColor = false;
            this.bSleep.Click += new System.EventHandler(this.bSleep_Click);
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.bPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.bPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Font = new System.Drawing.Font("Tahoma", 16F);
            this.bPlay.Location = new System.Drawing.Point(140, 0);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(140, 90);
            this.bPlay.TabIndex = 1;
            this.bPlay.Text = "Поиграть";
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bFeed
            // 
            this.bFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.bFeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.bFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFeed.Font = new System.Drawing.Font("Tahoma", 16F);
            this.bFeed.Location = new System.Drawing.Point(0, 0);
            this.bFeed.Name = "bFeed";
            this.bFeed.Size = new System.Drawing.Size(140, 90);
            this.bFeed.TabIndex = 0;
            this.bFeed.Text = "Покормить";
            this.bFeed.UseVisualStyleBackColor = false;
            this.bFeed.Click += new System.EventHandler(this.bFeed_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.labelGameName);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 25);
            this.panel1.TabIndex = 1;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGameName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGameName.Location = new System.Drawing.Point(158, 1);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(97, 20);
            this.labelGameName.TabIndex = 1;
            this.labelGameName.Text = "Игра в кота";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bExit.IconColor = System.Drawing.Color.DarkRed;
            this.bExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bExit.IconSize = 25;
            this.bExit.Location = new System.Drawing.Point(393, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(25, 25);
            this.bExit.TabIndex = 0;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // iconCat
            // 
            this.iconCat.BackColor = System.Drawing.Color.Transparent;
            this.iconCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCat.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.iconCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCat.IconSize = 200;
            this.iconCat.Location = new System.Drawing.Point(110, 120);
            this.iconCat.Name = "iconCat";
            this.iconCat.Size = new System.Drawing.Size(200, 200);
            this.iconCat.TabIndex = 2;
            this.iconCat.TabStop = false;
            // 
            // labelHungryState
            // 
            this.labelHungryState.AutoSize = true;
            this.labelHungryState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelHungryState.Location = new System.Drawing.Point(3, 381);
            this.labelHungryState.Name = "labelHungryState";
            this.labelHungryState.Size = new System.Drawing.Size(0, 44);
            this.labelHungryState.TabIndex = 3;
            // 
            // labelMoodState
            // 
            this.labelMoodState.AutoSize = true;
            this.labelMoodState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelMoodState.Location = new System.Drawing.Point(154, 381);
            this.labelMoodState.Name = "labelMoodState";
            this.labelMoodState.Size = new System.Drawing.Size(0, 44);
            this.labelMoodState.TabIndex = 4;
            // 
            // labelSleepState
            // 
            this.labelSleepState.AutoSize = true;
            this.labelSleepState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSleepState.Location = new System.Drawing.Point(302, 381);
            this.labelSleepState.Name = "labelSleepState";
            this.labelSleepState.Size = new System.Drawing.Size(0, 44);
            this.labelSleepState.TabIndex = 5;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelCatName.Location = new System.Drawing.Point(122, 66);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(0, 51);
            this.labelCatName.TabIndex = 6;
            // 
            // labelDeath
            // 
            this.labelDeath.AutoSize = true;
            this.labelDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelDeath.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDeath.Location = new System.Drawing.Point(12, 199);
            this.labelDeath.Name = "labelDeath";
            this.labelDeath.Size = new System.Drawing.Size(0, 26);
            this.labelDeath.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(418, 518);
            this.ControlBox = false;
            this.Controls.Add(this.labelDeath);
            this.Controls.Add(this.labelCatName);
            this.Controls.Add(this.labelSleepState);
            this.Controls.Add(this.labelMoodState);
            this.Controls.Add(this.labelHungryState);
            this.Controls.Add(this.iconCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button bFeed;
        private System.Windows.Forms.Button bSleep;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton bExit;
        private System.Windows.Forms.Label labelGameName;
        private FontAwesome.Sharp.IconPictureBox iconCat;
        private System.Windows.Forms.Label labelHungryState;
        private System.Windows.Forms.Label labelMoodState;
        private System.Windows.Forms.Label labelSleepState;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.Label labelDeath;
    }
}

