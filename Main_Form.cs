/* "Advanced Windows Tool" Written by Gorkido aka Gorkido#8195 on Discord */

using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Windows_Tool
{
    public partial class Cleaner : Form
    {
        private readonly Powershell_Files Debloater = new Powershell_Files();
        private readonly FilePaths FileLocation = new FilePaths();
        private readonly string TempFolder = Path.GetTempPath() + "\\Debloater Scripts";
        public Cleaner()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        private bool DarkMode;
        private readonly Timer t1 = new Timer();
        private async void ExitForm()
        {
            for (Opacity = 1; Opacity > .0; Opacity -= .1) { await Task.Delay(10); }
            if (Directory.Exists(TempFolder))
            {
                Directory.Delete(TempFolder, true);
            }
            Wait(1000);
            Application.Exit();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   //this stops the timer if the form is completely displayed
            }
            else
            {
                Opacity += 0.05;
            }
        }
        private void StartForm()
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity
            t1.Start();
        }
        public void Wait(int milliseconds)
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
                        Wait(1000);
                        Directory.CreateDirectory(dir);
                    }
                    if (dir.Contains("cache"))
                    {
                        Directory.Delete(dir, true);
                        Wait(1000);
                        Directory.CreateDirectory(dir);
                    }
                }
            }
            catch (Exception ex) { ErrorLog.Items.Add(ex.Message); }
        }

        private void Cleaner_Form_Load(object sender, EventArgs e)
        {
            MARGINS margins = new MARGINS
            {
                Top = Height,
                Left = Left
            };
            Blurred.Blur2(Handle, margins);
            Blurred.Blur1(Handle);
            DarkMode = true;
            StartForm();
        }

        private void Clean_MouseDown(object sender, MouseEventArgs e)
        {
            CleanLog.Items.Clear();
            ErrorLog.Items.Clear();

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
            string NetCache = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Microsoft\\Windows\\Explorer\\";
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
            ExitForm();
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
            Debloater.Startup();
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
                CustomizationButton.ForeColor = Color.Black;
                Button2.ForeColor = Color.Black;
                Button3.ForeColor = Color.Black;
                Button4.ForeColor = Color.Black;
                CustomizationButton.BorderColor = Color.Black;
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
                CustomizationButton.ForeColor = Color.FromArgb(23, 23, 23);
                Button2.ForeColor = Color.FromArgb(23, 23, 23);
                Button3.ForeColor = Color.FromArgb(23, 23, 23);
                Button4.ForeColor = Color.FromArgb(23, 23, 23);
                CustomizationButton.ForeColor = Color.FromArgb(23, 23, 23);
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
                CustomizationButton.ForeColor = Color.White;
                Button2.ForeColor = Color.White;
                Button3.ForeColor = Color.White;
                Button4.ForeColor = Color.White;
                CustomizationButton.BorderColor = Color.White;
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
                CustomizationButton.BackColor = Color.Black;
                Button2.BackColor = Color.Black;
                Button3.BackColor = Color.Black;
                Button4.BackColor = Color.Black;
                CustomizationButton.BackColor = Color.Black;
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

        private void Debloat_MouseDown(object sender, MouseEventArgs e)
        {
            if (Cortana.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[1]); // Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[2]);// Enable
            }
            Wait(3000);
            if (EdgePDF.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[5]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[4]);// Enable
            }
            Wait(3000);
            if (OneDrive.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[8]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[9]);// Enable
            }
            Wait(20000);
            if (BackgroundApps.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[20]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[21]);// Enable
            }
            Wait(3000);
            if (WindowsUpdate.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[16]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[17]);// Enable
            }
            Wait(3000);
            if (LocationTracking.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[22]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[23]);// Enable
            }
            Wait(3000);
            if (ActionCenter.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[15]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[14]);// Enable
            }
            Wait(3000);
            if (VisualFX.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[12]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[13]);// Enable
            }
            Wait(3000);
            if (Theme.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[25]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[24]);// Enable
            }
            Wait(3000);
            if (TrayIcon.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[11]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[10]);// Enable
            }
            Wait(3000);
            if (ClipboardHistory.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[27]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[26]);// Enable
            }
            Wait(3000);
            if (Hibernation.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[29]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[28]);// Enable
            }
            Wait(3000);
            if (ExplorerLaunchTo.BackColor == Color.Red)
            {
                Debloater.Powershell(Debloater.PSFiles[30]);// Disable
            }
            else
            {
                Debloater.Powershell(Debloater.PSFiles[19]);// Enable
            }
        }

        private void Cortana_MouseDown(object sender, MouseEventArgs e)
        {
            if (Cortana.BackColor == Color.Red)
            {
                Cortana.BackColor = Color.Lime;
                CortanaLabel.Text = "Cortana: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                Cortana.BackColor = Color.Red;
                CortanaLabel.Text = "Cortana: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void EdgePDF_MouseDown(object sender, MouseEventArgs e)
        {
            if (EdgePDF.BackColor == Color.Red)
            {
                EdgePDF.BackColor = Color.Lime;
                EdgePDFLabel.Text = "Edge PDF: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                EdgePDF.BackColor = Color.Red;
                EdgePDFLabel.Text = "Edge PDF: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void OneDrive_MouseDown(object sender, MouseEventArgs e)
        {
            if (OneDrive.BackColor == Color.Red)
            {
                OneDrive.BackColor = Color.Lime;
                OneDriveLabel.Text = "OneDrive: Installed";
                Debloater_Label.Focus();
            }
            else
            {
                OneDrive.BackColor = Color.Red;
                OneDriveLabel.Text = "OneDrive: Uninstalled";
                Debloater_Label.Focus();
            }
        }

        private void BackgroundApps_MouseDown(object sender, MouseEventArgs e)
        {
            if (BackgroundApps.BackColor == Color.Red)
            {
                BackgroundApps.BackColor = Color.Lime;
                BGAppsLabel.Text = "Background Apps: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                BackgroundApps.BackColor = Color.Red;
                BGAppsLabel.Text = "Background Apps: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void WindowsUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowsUpdate.BackColor == Color.Red)
            {
                WindowsUpdate.BackColor = Color.Lime;
                WindowsUpdateLabel.Text = "Win Update: Default Updates";
                Debloater_Label.Focus();
            }
            else
            {
                WindowsUpdate.BackColor = Color.Red;
                WindowsUpdateLabel.Text = "Win Update: Security Updates";
                Debloater_Label.Focus();
            }
        }

        private void ActionCenter_MouseDown(object sender, MouseEventArgs e)
        {
            if (ActionCenter.BackColor == Color.Red)
            {
                ActionCenter.BackColor = Color.Lime;
                ActionCenterLabel.Text = "Action Center: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                ActionCenter.BackColor = Color.Red;
                ActionCenterLabel.Text = "Action Center: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void VisualFX_MouseDown(object sender, MouseEventArgs e)
        {
            if (VisualFX.BackColor == Color.Red)
            {
                VisualFX.BackColor = Color.Lime;
                VisualFXLabel.Text = "Visual FX: Appearance";
                Debloater_Label.Focus();
            }
            else
            {
                VisualFX.BackColor = Color.Red;
                VisualFXLabel.Text = "Visual FX: Performance";
                Debloater_Label.Focus();
            }
        }

        private void Theme_MouseDown(object sender, MouseEventArgs e)
        {
            if (Theme.BackColor == Color.Red)
            {
                Theme.BackColor = Color.Lime;
                ThemeLabel.Text = "Theme: Dark Mode";
                Debloater_Label.Focus();
            }
            else
            {
                Theme.BackColor = Color.Red;
                ThemeLabel.Text = "Theme: Light Mode";
                Debloater_Label.Focus();
            }
        }

        private void TrayIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (TrayIcon.BackColor == Color.Red)
            {
                TrayIcon.BackColor = Color.Lime;
                TrayIconLabel.Text = "Tray Icons: Shown";
                Debloater_Label.Focus();
            }
            else
            {
                TrayIcon.BackColor = Color.Red;
                TrayIconLabel.Text = "Tray Icons: Hidden";
                Debloater_Label.Focus();
            }
        }

        private void ClipboardHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (ClipboardHistory.BackColor == Color.Red)
            {
                ClipboardHistory.BackColor = Color.Lime;
                ClipboardHistoryLabel.Text = "Clipboard History: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                ClipboardHistory.BackColor = Color.Red;
                ClipboardHistoryLabel.Text = "Clipboard History: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void ExplorerLaunchTo_MouseDown(object sender, MouseEventArgs e)
        {
            if (ExplorerLaunchTo.BackColor == Color.Red)
            {
                ExplorerLaunchTo.BackColor = Color.Lime;
                ExplorerLaunchToLabel.Text = "Explorer LaunchTo: Computer";
                Debloater_Label.Focus();
            }
            else
            {
                ExplorerLaunchTo.BackColor = Color.Red;
                ExplorerLaunchToLabel.Text = "Explorer LaunchTo: Fast Access";
                Debloater_Label.Focus();
            }
        }

        private void LocationTracking_MouseDown(object sender, MouseEventArgs e)
        {
            if (LocationTracking.BackColor == Color.Red)
            {
                LocationTracking.BackColor = Color.Lime;
                LocationTrackingLabel.Text = "Location Tracking: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                LocationTracking.BackColor = Color.Red;
                LocationTrackingLabel.Text = "Location Tracking: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void Hibernation_MouseDown(object sender, MouseEventArgs e)
        {
            if (Hibernation.BackColor == Color.Red)
            {
                Hibernation.BackColor = Color.Lime;
                HibernationLabel.Text = "Hibernation: Enabled";
                Debloater_Label.Focus();
            }
            else
            {
                Hibernation.BackColor = Color.Red;
                HibernationLabel.Text = "Hibernation: Disabled";
                Debloater_Label.Focus();
            }
        }

        private void FullyDebloat_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (string PSFiles in Debloater.FullyDebloat)
            {
                Debloater.Powershell(PSFiles + "-Sysprep -Debloat -Privacy");
                Wait(3000);
            }
        }

        private void Revert_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (string PSFiles in Debloater.Revert)
            {
                Debloater.Powershell(PSFiles);
                Wait(2000);
            }
        }

        private void ProtectPrivacy_MouseDown(object sender, MouseEventArgs e)
        {
            Debloater.Powershell(Debloater.PSFiles[6]);
        }

        private void FixWinUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            Debloater.Powershell(Debloater.PSFiles[31]);
        }

        private void RemoveBloatwareKeys_MouseDown(object sender, MouseEventArgs e)
        {
            Debloater.Powershell(Debloater.PSFiles[32]);
        }
    }
}
