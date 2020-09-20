namespace SpiderAutomation
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetClickLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAutomationtripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavnarZealAlertToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.checklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.questCompletionLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptQuestScrollLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomOfQuestLetterScrollbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptQuestScrollLocationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.openConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.checklistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetClickLocationsToolStripMenuItem,
            this.refreshImageToolStripMenuItem,
            this.runAutomationtripMenuItem,
            this.openConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "System";
            // 
            // resetClickLocationsToolStripMenuItem
            // 
            this.resetClickLocationsToolStripMenuItem.Name = "resetClickLocationsToolStripMenuItem";
            this.resetClickLocationsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.resetClickLocationsToolStripMenuItem.Text = "Reset Click Locations";
            this.resetClickLocationsToolStripMenuItem.Click += new System.EventHandler(this.resetClickLocationsToolStripMenuItem_Click);
            // 
            // refreshImageToolStripMenuItem
            // 
            this.refreshImageToolStripMenuItem.Name = "refreshImageToolStripMenuItem";
            this.refreshImageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.refreshImageToolStripMenuItem.Text = "Refresh Image";
            this.refreshImageToolStripMenuItem.Click += new System.EventHandler(this.refreshImageToolStripMenuItem_Click);
            // 
            // runAutomationtripMenuItem
            // 
            this.runAutomationtripMenuItem.Name = "runAutomationtripMenuItem";
            this.runAutomationtripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.runAutomationtripMenuItem.Text = "Run Automation";
            this.runAutomationtripMenuItem.Click += new System.EventHandler(this.runAutomationtripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zavnarZealAlertToolStrip});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // zavnarZealAlertToolStrip
            // 
            this.zavnarZealAlertToolStrip.Checked = true;
            this.zavnarZealAlertToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zavnarZealAlertToolStrip.Name = "zavnarZealAlertToolStrip";
            this.zavnarZealAlertToolStrip.Size = new System.Drawing.Size(171, 22);
            this.zavnarZealAlertToolStrip.Text = "Zavnar\'s Zeal Alert";
            this.zavnarZealAlertToolStrip.Click += new System.EventHandler(this.zavnarZealAlertToolStrip_Click);
            // 
            // checklistToolStripMenuItem
            // 
            this.checklistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.questCompletionLocationToolStripMenuItem,
            this.acceptQuestScrollLocationToolStripMenuItem,
            this.bottomOfQuestLetterScrollbarToolStripMenuItem,
            this.acceptQuestScrollLocationToolStripMenuItem1});
            this.checklistToolStripMenuItem.Name = "checklistToolStripMenuItem";
            this.checklistToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.checklistToolStripMenuItem.Text = "Checklist 0/5";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem2.Text = "1. Click on Zavnar\'s Zeal Option 1";
            // 
            // questCompletionLocationToolStripMenuItem
            // 
            this.questCompletionLocationToolStripMenuItem.Enabled = false;
            this.questCompletionLocationToolStripMenuItem.Name = "questCompletionLocationToolStripMenuItem";
            this.questCompletionLocationToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.questCompletionLocationToolStripMenuItem.Text = "1. Quest Completion Location";
            // 
            // acceptQuestScrollLocationToolStripMenuItem
            // 
            this.acceptQuestScrollLocationToolStripMenuItem.Enabled = false;
            this.acceptQuestScrollLocationToolStripMenuItem.Name = "acceptQuestScrollLocationToolStripMenuItem";
            this.acceptQuestScrollLocationToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.acceptQuestScrollLocationToolStripMenuItem.Text = "2. Click on Quest Letters Tab";
            // 
            // bottomOfQuestLetterScrollbarToolStripMenuItem
            // 
            this.bottomOfQuestLetterScrollbarToolStripMenuItem.Enabled = false;
            this.bottomOfQuestLetterScrollbarToolStripMenuItem.Name = "bottomOfQuestLetterScrollbarToolStripMenuItem";
            this.bottomOfQuestLetterScrollbarToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.bottomOfQuestLetterScrollbarToolStripMenuItem.Text = "3. Bottom of Quest Letter Scrollbar Location";
            // 
            // acceptQuestScrollLocationToolStripMenuItem1
            // 
            this.acceptQuestScrollLocationToolStripMenuItem1.Enabled = false;
            this.acceptQuestScrollLocationToolStripMenuItem1.Name = "acceptQuestScrollLocationToolStripMenuItem1";
            this.acceptQuestScrollLocationToolStripMenuItem1.Size = new System.Drawing.Size(305, 22);
            this.acceptQuestScrollLocationToolStripMenuItem1.Text = "4. Accept Quest Scroll Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(544, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(256, 24);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volume: 50%";
            // 
            // openConfigurationToolStripMenuItem
            // 
            this.openConfigurationToolStripMenuItem.Name = "openConfigurationToolStripMenuItem";
            this.openConfigurationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openConfigurationToolStripMenuItem.Text = "Open Configuration";
            this.openConfigurationToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationToolStripMenuItem_Click);
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SpiderQuest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem checklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questCompletionLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomOfQuestLetterScrollbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptQuestScrollLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetClickLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAutomationtripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem refreshImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptQuestScrollLocationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavnarZealAlertToolStrip;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

