using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WMPLib;
using System.IO;

namespace Dictionary_2015
{
    public partial class Main : Form
    {
        int Count = 0;
        int TimeCount = 0;
        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        public string SFTEMP = Environment.ExpandEnvironmentVariables("%TEMP%");
        public Main()
        {
            InitializeComponent();
            this.Opacity = 0.1;
            TIM_Opacity.Start();
            this.Height = 100;
            if (System.IO.File.Exists(SFTEMP + "\\Music.mp3"))
                System.IO.File.Delete(SFTEMP + "\\Music.mp3");
            byte[] EXEBytes = Properties.Resources.Music;
            string EXEToRun = Path.Combine(Path.GetTempPath(), "Music.mp3");
            using (FileStream EXEFile = new FileStream(EXEToRun, FileMode.CreateNew))
                EXEFile.Write(EXEBytes, 0, EXEBytes.Length);
        }
        /// <summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// </summary>

        private void P_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LBL_1_Click(object sender, EventArgs e)
        {
            TIM_OpacityExit.Start();
        }

        private void LBL_2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TIM_Opacity_Tick(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.025;
                }
                if (this.Height >= 600)
                {
                    TIM_Opacity.Stop();
                    Count = 1;
                }
                else
                {
                    this.Height += 10;
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                }
            }
        }

        private void TIM_OpacityExit_Tick(object sender, EventArgs e)
        {
            if (Count == 1)
            {
                if (this.Opacity >= 0.1)
                {
                    this.Opacity -= 0.025;
                }
                if (this.Height <= 100)
                {
                    TIM_OpacityExit.Stop();
                    Count = 0;
                    Application.ExitThread();
                }
                else
                {
                    this.Height -= 10;
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                }
            }
        }

        private void TIM_MusicPlay_Tick(object sender, EventArgs e)
        {
            if (TimeCount == 1000000)
            {
                WMP.controls.stop();
                TimeCount = 0;
                TIM_MusicPlay.Interval = 6000;
            }
                WMP.URL = SFTEMP + "\\Music.mp3";
                WMP.controls.play();
                TimeCount++;
                TIM_MusicPlay.Interval = 250000;
        }
    }
}
