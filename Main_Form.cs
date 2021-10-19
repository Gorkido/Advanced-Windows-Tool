/* "Advanced Windows Tool" Written by Gorkido aka Gorkido#8195 on Discord */

using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Advanced_Windows_Tool
{
    public partial class Cleaner : Form
    {
        public Cleaner()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MARGINS margins = new MARGINS
            {
                Top = Height,
                Left = Left
            };
            DllHelper.Blur2(Handle, margins);
            DllHelper.Blur1(Handle);
        }

        private bool mouseDown;
        private Point lastLocation;
        private bool DarkMode;

        public void wait(int milliseconds)
        {
            Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0)
            {
                return;
            }

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                    CleanLog.Items.Add("File deleted: " + fi.FullName);
                }
                catch (Exception) { } // Ignore all exceptions
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                try
                {
                    di.Delete();
                    CleanLog.Items.Add("Folder deleted: " + di.FullName);
                }
                catch (Exception) { } // Ignore all exceptions
            }
        }

        private void CacheDirClean(string FolderPath)
        {
            try
            {
                foreach (string dir in Directory.EnumerateDirectories(FolderPath))
                {
                    if (dir.Contains("Cache"))
                    {
                        Directory.Delete(dir, true);
                        wait(1000);
                        Directory.CreateDirectory(dir);
                    }
                    if (dir.Contains("cache"))
                    {
                        Directory.Delete(dir, true);
                        wait(1000);
                        Directory.CreateDirectory(dir);
                    }
                }
            }
            catch (Exception ex) { ErrorLog.Items.Add(ex.Message); }
        }

        private void Cleaner_Form_Load(object sender, EventArgs e)
        {
            DarkMode = true;
        }

        private void Clean_MouseDown(object sender, MouseEventArgs e)
        {
            CleanLog.Items.Clear();
            ErrorLog.Items.Clear();
            FilePaths FileLocation = new FilePaths();

            foreach (string dir in FileLocation.GraphicDrivers)
            {
                try
                {
                    Directory.Delete(dir, true);
                    CleanLog.Items.Add("Folder deleted: " + dir);
                }
                catch (Exception ex) { ErrorLog.Items.Add(ex.Message); } // Ignore all exceptions
            }

            foreach (string dir in FileLocation.Temporary)
            {
                try
                {
                    ClearFolder(dir);
                    CleanLog.Items.Add("Folder cleaned: " + dir);
                }
                catch (Exception ex) { ErrorLog.Items.Add(ex.Message); } // Ignore all exceptions
            }

            foreach (string dir in FileLocation.TemporaryCachePaths)
            {
                try
                {
                    CacheDirClean(dir);
                }
                catch (Exception ex) { ErrorLog.Items.Add(ex.Message); } // Ignore all exceptions
            }

            // Deleting "*.db"
            string NetCache = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Microsoft\Windows\Explorer\";
            DirectoryInfo d = new DirectoryInfo(NetCache);

            FileInfo[] Files = d.GetFiles("*.db"); //Getting db files

            foreach (FileInfo file in Files)
            {
                try
                {
                    string str = file.FullName;
                    File.Delete(str);
                }
                catch (Exception ex) { ErrorLog.Items.Add(ex.Message); }
            }
        }

        private void CleanLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { Clipboard.SetText(CleanLog.Text); }
            catch (Exception) { }
        }

        private void ErrorLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { Clipboard.SetText(ErrorLog.Text); }
            catch (Exception) { }
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopBar_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void TopBar_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AppName_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void AppName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NotYetHAX");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/mTmBR4yrC8");
        }

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            About_Panel.Visible = true;
            CleanerPanel.Visible = false;
            DebloaterPanel.Visible = false;
        }

        private void CleanerButton_MouseDown(object sender, MouseEventArgs e)
        {
            About_Panel.Visible = false;
            CleanerPanel.Visible = true;
            DebloaterPanel.Visible = false;
        }

        private void DebloaterButton_MouseDown(object sender, MouseEventArgs e)
        {
            About_Panel.Visible = false;
            CleanerPanel.Visible = false;
            DebloaterPanel.Visible = true;
        }
        private void ModeChanger_CheckedChanged(object sender, EventArgs e)
        {
            /* I'll fix this cursed feature later :D */

            if (DarkMode == true)
            {
                DarkMode = false;
                Opacity = 100;
                /* Border and Fore Colors */
                AboutButton.BorderColor = Color.Black;
                CleanerButton.BorderColor = Color.Black;
                DebloaterButton.BorderColor = Color.Black;
                CleanerButton.ForeColor = Color.Black;
                DebloaterButton.ForeColor = Color.Black;
                DebloaterPanel.BorderColor = Color.Black;
                Button1.ForeColor = Color.Black;
                Button2.ForeColor = Color.Black;
                Button3.ForeColor = Color.Black;
                Button4.ForeColor = Color.Black;
                Button1.BorderColor = Color.Black;
                Button2.BorderColor = Color.Black;
                Button3.BorderColor = Color.Black;
                Button4.BorderColor = Color.Black;
                CleanerPanel.BorderColor = Color.Black;
                Minimize.ForeColor = Color.Black;
                Exit.ForeColor = Color.Black;
                AppName.ForeColor = Color.Black;
                Desc.ForeColor = Color.Black;
                Desc2.ForeColor = Color.Black;
                TopBar.BorderColor = Color.Black;
                Clean.BorderColor = Color.Black;
                Clean.ForeColor = Color.Black;
                About_Panel.BorderColor = Color.Black;
                /* Border and Fore Colors */

                /* Back Colors */
                CleanLog.BackColor = Color.Black;
                ErrorLog.BackColor = Color.Black;
                CleanLog.BackColor = Color.FromArgb(23, 23, 23);
                ErrorLog.BackColor = Color.FromArgb(23, 23, 23);
                /* Back Colors */

                /* Dark Color */
                AboutButton.BorderColor = Color.Black;
                AboutButton.ForeColor = Color.FromArgb(23, 23, 23);
                CleanerButton.ForeColor = Color.FromArgb(23, 23, 23);
                DebloaterButton.ForeColor = Color.FromArgb(23, 23, 23);
                CleanerButton.ForeColor = Color.FromArgb(23, 23, 23);
                DebloaterButton.ForeColor = Color.FromArgb(23, 23, 23);
                Button1.ForeColor = Color.FromArgb(23, 23, 23);
                Button2.ForeColor = Color.FromArgb(23, 23, 23);
                Button3.ForeColor = Color.FromArgb(23, 23, 23);
                Button4.ForeColor = Color.FromArgb(23, 23, 23);
                Button1.ForeColor = Color.FromArgb(23, 23, 23);
                Button2.ForeColor = Color.FromArgb(23, 23, 23);
                Button3.ForeColor = Color.FromArgb(23, 23, 23);
                Button4.ForeColor = Color.FromArgb(23, 23, 23);
                CleanerPanel.ForeColor = Color.FromArgb(23, 23, 23);
                Minimize.ForeColor = Color.FromArgb(23, 23, 23);
                Exit.ForeColor = Color.FromArgb(23, 23, 23);
                AppName.ForeColor = Color.FromArgb(23, 23, 23);
                Desc.ForeColor = Color.FromArgb(23, 23, 23);
                Desc2.ForeColor = Color.FromArgb(23, 23, 23);
                TopBar.ForeColor = Color.FromArgb(23, 23, 23);
                Clean.ForeColor = Color.FromArgb(23, 23, 23);
                /* Dark Color */
            }
            else
            {
                DarkMode = true;
                Opacity = 90;

                /* Border and Fore Colors */
                About_Panel.BorderColor = Color.White;
                AboutButton.BorderColor = Color.White;
                CleanerButton.BorderColor = Color.White;
                DebloaterButton.BorderColor = Color.White;
                AboutButton.ForeColor = Color.White;
                CleanerButton.ForeColor = Color.White;
                DebloaterButton.ForeColor = Color.White;
                DebloaterPanel.BorderColor = Color.White;
                Button1.ForeColor = Color.White;
                Button2.ForeColor = Color.White;
                Button3.ForeColor = Color.White;
                Button4.ForeColor = Color.White;
                Button1.BorderColor = Color.White;
                Button2.BorderColor = Color.White;
                Button3.BorderColor = Color.White;
                Button4.BorderColor = Color.White;
                CleanerPanel.BorderColor = Color.White;
                Minimize.ForeColor = Color.White;
                Exit.ForeColor = Color.White;
                AppName.ForeColor = Color.White;
                Desc.ForeColor = Color.White;
                Desc2.ForeColor = Color.White;
                TopBar.BorderColor = Color.White;
                Clean.BorderColor = Color.White;
                Clean.ForeColor = Color.White;
                /* Border and Fore Colors */

                /* Back Colors */
                AboutButton.BackColor = Color.White;
                CleanLog.BackColor = Color.DarkGray;
                ErrorLog.BackColor = Color.DarkGray;
                AboutButton.BackColor = Color.Black;
                CleanerButton.BackColor = Color.Black;
                DebloaterButton.BackColor = Color.Black;
                CleanerButton.BackColor = Color.Black;
                DebloaterButton.BackColor = Color.Black;
                Button1.BackColor = Color.Black;
                Button2.BackColor = Color.Black;
                Button3.BackColor = Color.Black;
                Button4.BackColor = Color.Black;
                Button1.BackColor = Color.Black;
                Button2.BackColor = Color.Black;
                Button3.BackColor = Color.Black;
                Button4.BackColor = Color.Black;
                CleanerPanel.BackColor = Color.Black;
                Minimize.BackColor = Color.Black;
                Exit.BackColor = Color.Black;
                AppName.BackColor = Color.Black;
                Desc.BackColor = Color.Black;
                Desc2.BackColor = Color.Black;
                TopBar.BackColor = Color.Black;
                Clean.BackColor = Color.Black;
                /* Back Colors */

                /* I'll fix this cursed feature later :D */
            }
        }

        private void Website_MouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("www.NotYetHax.gq");
        }

        public static class DllHelper
        {
            [DllImport("user32.dll")]
            internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

            [DllImport("DwmApi.dll")]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

            public static int Blur1(IntPtr hwnd)
            {
                AccentPolicy accentPolicy = new AccentPolicy
                {
                    AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND,
                    AccentFlags = 0,
                    GradientColor = 0,
                    AnimationId = 0
                };
                WindowCompositionAttributeData data = new WindowCompositionAttributeData
                {
                    Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
                };
                int accentSize = Marshal.SizeOf(accentPolicy);
                IntPtr accentPtr = Marshal.AllocHGlobal(accentSize);
                Marshal.StructureToPtr(accentPolicy, accentPtr, false);
                data.Data = accentPtr;
                data.SizeOfData = accentSize;
                int result = SetWindowCompositionAttribute(hwnd, ref data);
                Marshal.FreeHGlobal(accentPtr);
                return result;
            }

            public static int Blur2(IntPtr mainWindowPtr, MARGINS margins)
            {
                return DwmExtendFrameIntoClientArea(mainWindowPtr, ref margins);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        internal enum WindowCompositionAttribute
        {
            WCA_UNDEFINED = 0,
            WCA_NCRENDERING_ENABLED = 1,
            WCA_NCRENDERING_POLICY = 2,
            WCA_TRANSITIONS_FORCEDISABLED = 3,
            WCA_ALLOW_NCPAINT = 4,
            WCA_CAPTION_BUTTON_BOUNDS = 5,
            WCA_NONCLIENT_RTL_LAYOUT = 6,
            WCA_FORCE_ICONIC_REPRESENTATION = 7,
            WCA_EXTENDED_FRAME_BOUNDS = 8,
            WCA_HAS_ICONIC_BITMAP = 9,
            WCA_THEME_ATTRIBUTES = 10,
            WCA_NCRENDERING_EXILED = 11,
            WCA_NCADORNMENTINFO = 12,
            WCA_EXCLUDED_FROM_LIVEPREVIEW = 13,
            WCA_VIDEO_OVERLAY_ACTIVE = 14,
            WCA_FORCE_ACTIVEWINDOW_APPEARANCE = 15,
            WCA_DISALLOW_PEEK = 16,
            WCA_CLOAK = 17,
            WCA_CLOAKED = 18,
            WCA_ACCENT_POLICY = 19,
            WCA_FREEZE_REPRESENTATION = 20,
            WCA_EVER_UNCLOAKED = 21,
            WCA_VISUAL_OWNER = 22,
            WCA_HOLOGRAPHIC = 23,
            WCA_EXCLUDED_FROM_DDA = 24,
            WCA_PASSIVEUPDATEMODE = 25,
            WCA_LAST = 26
        }

        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4, // RS4 1803
            ACCENT_ENABLE_HOSTBACKDROP = 5, // RS5 1809
            ACCENT_INVALID_STATE = 6
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }
    }
}
