using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SpiderAutomation
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        [DllImport("gdi32")]
        public static extern uint GetPixel(IntPtr hDC, int XPos, int YPos);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        // Keyboard actions
        private const int VK_ALT = 0x12;
        private const int FKey = 0x46;
        private const int JKey = 0x4A;
        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // Constants
        private const int minSleep = 200;
        private const int maxSleep = 235;

        private Color questInProgressColor;
        private bool doingProcedure = false;
        System.Windows.Media.MediaPlayer mediaPlayer;

        public List<Vector2> locations = new List<Vector2>();
        public List<Label> customLabels = new List<Label>();

        public struct Vector2
        {
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int x;
            public int y;
        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = GetScreenshot();

            mediaPlayer = new System.Windows.Media.MediaPlayer();

            RegisterHotKeys();
        }

        private void RegisterHotKeys()
        {
            int FirstHotkeyId = 1;
            int HotKeyCode = (int)Keys.F1;

            Boolean F1Registered = RegisterHotKey(this.Handle, FirstHotkeyId, 0x0000, HotKeyCode);

            if (!F1Registered)
            {
                MessageBox.Show("Error: Couldn't load F1 Hotkey");
            }


            int SecondHotkeyId = 2;
            int SecondHotKeyKey = (int)Keys.F2;
            Boolean F2Registered = RegisterHotKey(this.Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey);

            if (!F2Registered)
            {
                MessageBox.Show("Error: Couldn't load F2 Hotkey");
            }

            int ThirdHotkeyId = 3;
            int ThirdHotKeyKey = (int)Keys.F3;
            Boolean F3Registered = RegisterHotKey(this.Handle, ThirdHotkeyId, 0x0000, ThirdHotKeyKey);

            if (!F3Registered)
            {
                MessageBox.Show("Error: Couldn't load F3 Hotkey");
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Catch hotkey
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                switch (id)
                {
                    case 1:
                        GetQuest();
                        break;
                    case 2:
                        CompleteQuest();
                        GetQuest();
                        break;
                    case 3:
                        pictureBox1.Image = GetScreenshot();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (locations.Count < 5)
                locations.Add(new Vector2(e.X, e.Y));

            // Create visual for clicks
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Calibri", 16);
            label.ForeColor = Color.White;
            label.BackColor = Color.Black;
            label.BringToFront();
            label.Padding = new Padding(0);

            switch (locations.Count)
            {
                case 1:
                    label.Text = "1";
                    label.Location = new System.Drawing.Point(locations[0].x - 11, locations[0].y - 16);
                    toolStripMenuItem2.Checked = true;

                    Bitmap myBitmap = new Bitmap((Bitmap)pictureBox1.Image);
                    questInProgressColor = myBitmap.GetPixel(locations[0].x, locations[0].y);
                    break;

                case 2:
                    label.Text = "2";
                    label.Location = new System.Drawing.Point(locations[1].x - 11, locations[1].y - 16);
                    questCompletionLocationToolStripMenuItem.Checked = true;
                    break;

                case 3:
                    label.Text = "3";
                    label.Location = new System.Drawing.Point(locations[2].x - 11, locations[2].y - 16);
                    acceptQuestScrollLocationToolStripMenuItem.Checked = true;
                    break;
                    
                case 4:
                    label.Text = "4";
                    label.Location = new System.Drawing.Point(locations[3].x - 11, locations[3].y - 16);
                    bottomOfQuestLetterScrollbarToolStripMenuItem.Checked = true;
                    break;
                case 5:
                    label.Text = "5";
                    label.Location = new System.Drawing.Point(locations[4].x - 11, locations[4].y - 16);
                    acceptQuestScrollLocationToolStripMenuItem1.Checked = true;
                    break;

            }
            checklistToolStripMenuItem.Text = "Checklist " + locations.Count + "/5";
            pictureBox1.Controls.Add(label);
            customLabels.Add(label);
        }

        private void resetClickLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset checklist
            toolStripMenuItem2.Checked = false;
            questCompletionLocationToolStripMenuItem.Checked = false;
            bottomOfQuestLetterScrollbarToolStripMenuItem.Checked = false;
            acceptQuestScrollLocationToolStripMenuItem.Checked = false;
            acceptQuestScrollLocationToolStripMenuItem1.Checked = false;

            checklistToolStripMenuItem.Text = "Checklist 0/5";

            foreach(Label l in customLabels)
            {
                pictureBox1.Controls.Remove(l);
            }
            customLabels.Clear();

            locations.Clear();
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void CompleteQuest()
        {
            Random r = new Random();
            uint X = (uint)locations[1].x;
            uint Y = (uint)locations[1].y;

            // Open Completed Quest
            pressAlt();

            Thread.Sleep(r.Next(minSleep, maxSleep));
            SetCursorPos((int)X, (int)Y);   // Move mouse
            Thread.Sleep(r.Next(minSleep, maxSleep));
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); // LMB Click

            releaseAlt();

            Thread.Sleep(r.Next(minSleep + 300, maxSleep + 300)); // Wait for quest to open

            // Spam F
            for (int b = 0; b < 10; b++)
            {
                pressKey(FKey);
                Thread.Sleep(r.Next(minSleep, maxSleep));
                releaseKey(FKey);
            }

            doingProcedure = false;
        }

        private void GetQuest()
        {
            Random r = new Random();
            uint X = 0;
            uint Y = 0;

            pressKey(JKey);
            Thread.Sleep(r.Next(minSleep, maxSleep));
            releaseKey(JKey);

            // Iterate through last locations (1st is for quest completion)
            for (int i = 2; i < locations.Count; i++)
            {
                X = (uint)locations[i].x;
                Y = (uint)locations[i].y;

                SetCursorPos(locations[i].x, locations[i].y);   // Move mouse
                Thread.Sleep(r.Next(minSleep, maxSleep));
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); // LMB Click
                Thread.Sleep(r.Next(minSleep, maxSleep));
            }

            Thread.Sleep(r.Next(minSleep, maxSleep)); // Quest takes too long to open :(

            // Quest is open so spam F
            for (int i = 0; i < 10; i++)
            {
                pressKey(FKey);
                Thread.Sleep(r.Next(minSleep, maxSleep));
                releaseKey(FKey);
            }
        }

        private void runAutomationtripMenuItem_Click(object sender, EventArgs e)
        {
            if (locations.Count != 5)
            {
                MessageBox.Show("Please complete the checklist first.");
                return;
            }
            
            runAutomationtripMenuItem.Checked = !runAutomationtripMenuItem.Checked;

            if (runAutomationtripMenuItem.Checked)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        void pressKey(byte key)
        {
            keybd_event(key, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }

        void releaseKey(byte key)
        {
            keybd_event(key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        void pressAlt()
        {
            keybd_event(VK_ALT, 0xb8, 0, 0); // Key Press
        }

        Image GetScreenshot()
        {
            int screenWidth = Convert.ToInt32(System.Windows.SystemParameters.VirtualScreenWidth);
            int screenHeight = Convert.ToInt32(SystemParameters.VirtualScreenHeight);
            int screenLeft = Convert.ToInt32(SystemParameters.VirtualScreenLeft);
            int screenTop = Convert.ToInt32(SystemParameters.VirtualScreenTop);

            Image imgScreen = new Bitmap(screenWidth, screenHeight);
            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb))
            using (Graphics g = Graphics.FromImage(bmp))
            using (Graphics gr = Graphics.FromImage(imgScreen))
            {
                g.CopyFromScreen(screenLeft, screenTop, 0, 0, new System.Drawing.Size(screenWidth, screenHeight));
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(bmp, new Rectangle(0, 0, screenWidth, screenHeight));
            }

            return imgScreen;
        }

        void releaseAlt()
        {
            keybd_event(VK_ALT, 0xb8, KEYEVENTF_KEYUP, 0); // Key Release
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = GetScreenshot();
            Bitmap myBitmap = new Bitmap((Bitmap)img);
            //Color currentColor = myBitmap.GetPixel(locations[0].x, locations[0].y);

            //// Look for completion Symbol AKA automation section to be implemented
            //if (!doingProcedure && currentColor == colorToFind)
            //{
            //    doingProcedure = true;
            //}

            if (zavnarZealAlertToolStrip.Checked && !IsQuestInProgress(ref myBitmap))
            {
                mediaPlayer.Volume = (double)trackBar1.Value / 100;
                mediaPlayer.Open(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase) + "\\heylisten.wav"));
                mediaPlayer.Play();
                //this.Text = "Can't find quest";
            }
            //else
               // this.Text = "Found quest!";

            // Clean up memory
            img.Dispose();
            myBitmap.Dispose();
        }

        private bool IsQuestInProgress(ref Bitmap img)
        {
            Color color = Color.Empty;  // Our current pixel we're checking

            int searchWidth = 35;
            int searchHeight = 35;

            int x = locations[0].x;
            int y = locations[0].y;

            for(int i = x-searchWidth; i < x+searchWidth; i++)
            {
                for (int b = y-searchHeight; b < y+searchHeight; b++)
                {
                    if (i < img.Width && i > 0 &&
                        b < img.Height && b > 0)
                    {
                        color = img.GetPixel(i, b);
                    }
                    
                    // Colors within % similarity
                    if (ColorsAreClose(questInProgressColor, color, 2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool ColorsAreClose(Color a, Color z, int threshold = 10)
        {
            int r = (int)a.R - z.R,
                g = (int)a.G - z.G,
                b = (int)a.B - z.B;
            return (r * r + g * g + b * b) <= threshold * threshold;
        }

        private void refreshImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetScreenshot();
        }

        private void zavnarZealAlertToolStrip_Click(object sender, EventArgs e)
        {
            zavnarZealAlertToolStrip.Checked = !zavnarZealAlertToolStrip.Checked;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Volume: " + trackBar1.Value + "%";
        }
    }
}
