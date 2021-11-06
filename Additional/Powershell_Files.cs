using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Advanced_Windows_Tool
{
    internal class Powershell_Files
    {
        private static readonly string TempFolder = Path.GetTempPath() + "\\Debloater Scripts\\";

        public void Wait(int milliseconds)
        {
            Timer timer1 = new Timer();
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

        public void Powershell(string FilePath)
        {
            ProcessStartInfo File = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{FilePath}\"",
                UseShellExecute = false
            };
            Process.Start(File);
        }

        private static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }

        public void Startup()
        {
            if (!Directory.Exists(TempFolder))
            {
                Directory.CreateDirectory(TempFolder);
            }
            Wait(500);
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Appearance-FX.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Dark-Mode.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Default-Windows-Update.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Action-Center.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-BackgroundApps.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Cortana.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Edge-PDF.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Hibernation.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Last-Used-Files-And-Folders-View.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Disable-Location-Tracking.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Action-Center.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-BackgroundApps.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Clipboard-History.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Cortana.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Edge-PDF.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Hibernation.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Enable-Location-Tracking.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Fix-Windows-Update.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Fully-Debloat-Windows.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Hide-Tray-Icons.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Install-OneDrive.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Light-Mode.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Performance-FX.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Protect-Privacy.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Remove-Bloatware-RegKeys.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Revert-Changes.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Security-Windows-Update.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Set-Explorer-LaunchTo-Fast-Access.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Set-Explorers-LaunchTo-Computer.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Show-Tray-Icons.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Uninstall-OneDrive.ps1");
            Extract("Advanced_Windows_Tool", TempFolder, "Powershell_Files", "Unpin-Start.ps1");
        }

        public string[] PSFiles =
        {
            TempFolder + "\\Fully-Debloat-Windows.ps1", //0
            TempFolder + "\\Disable-Cortana.ps1", //1
            TempFolder + "\\Enable-Cortana.ps1", //2
            TempFolder + "\\Disable-Last-Used-Files-And-Folders-View.ps1", //3
            TempFolder + "\\Enable-Edge-PDF.ps1", //4
            TempFolder + "\\Disable-Edge-PDF.ps1", //5
            TempFolder + "\\Protect-Privacy.ps1", //6
            TempFolder + "\\Revert-Changes.ps1", //7
            TempFolder + "\\Uninstall-OneDrive.ps1", //8
            TempFolder + "\\Install-OneDrive.ps1", //9
            TempFolder + "\\Show-Tray-Icon", //10
            TempFolder + "\\Hide-Tray-Icon", //11
            TempFolder + "\\Performance-FX.ps1", //12
            TempFolder + "\\Appearance-FX.ps1", //13
            TempFolder + "\\Enable-Action-Center.ps1", //14
            TempFolder + "\\Disable-Action-Center.ps1", //15
            TempFolder + "\\Security-Windows-Update.ps1", //16
            TempFolder + "\\Default-Windows-Update.ps1", //17
            TempFolder + "\\Unpin-Start.ps1", //18
            TempFolder + "\\Set-Explorers-LaunchTo-Computer.ps1", //19
            TempFolder + "\\Disable-BackgroundApps.ps1", //20
            TempFolder + "\\Enable-BackgroundApps.ps1", //21
            TempFolder + "\\Disable-Location-Tracking.ps1", //22
            TempFolder + "\\Enable-Location-Tracking.ps1", //23
            TempFolder + "\\Dark-Mode.ps1", //24
            TempFolder + "\\Light-Mode.ps1", //25
            TempFolder + "\\Enable-Clipboard-History.ps1", //26
            TempFolder + "\\Disable-Clipboard-History.ps1", //27
            TempFolder + "\\Enable-Hibernation.ps1", //28
            TempFolder + "\\Disable-Hibernation.ps1", //29
            TempFolder + "\\Set-Explorer-LaunchTo-Fast-Access.ps1", //30
            TempFolder + "\\Fix-Windows-Update.ps1", //31
            TempFolder + "\\Remove-Bloatware-RegKeys.ps1", //32
        };

        public string[] FullyDebloat =
        {
            TempFolder + "\\Fully-Debloat-Windows.ps1",
            TempFolder + "\\Disable-Cortana.ps1",
            TempFolder + "\\Disable-Last-Used-Files-And-Folders-View.ps1",
            TempFolder + "\\Disable-Edge-PDF.ps1",
            TempFolder + "\\Protect-Privacy.ps1",
            TempFolder + "\\Uninstall-OneDrive.ps1",
            TempFolder + "\\Disable-Action-Center.ps1",
            TempFolder + "\\Security-Windows-Update.ps1",
            TempFolder + "\\Unpin-Start.ps1",
            TempFolder + "\\Set Explorers LaunchTo Computer.ps1",
            TempFolder + "\\Disable-BackgroundApps.ps1",
            TempFolder + "\\Disable-Location-Tracking.ps1",
            TempFolder + "\\Dark-Mode.ps1",
            TempFolder + "\\Disable-Clipboard-History.ps1",
            TempFolder + "\\Disable-Hibernation.ps1",
            TempFolder + "\\Remove-Bloatware-RegKeys.ps1",
        };

        public string[] Revert =
        {
            TempFolder + "\\Revert-Changes.ps1",
            TempFolder + "\\Enable-Cortana.ps1",
            TempFolder + "\\Enable-Edge-PDF.ps1",
            TempFolder + "\\Enable-Action-Center.ps1",
            TempFolder + "\\Appearance-FX.ps1",
            TempFolder + "\\Hide-Tray-Icon",
            TempFolder + "\\Install-OneDrive.ps1",
            TempFolder + "\\Default-Windows-Update.ps1",
            TempFolder + "\\Enable-BackgroundApps.ps1",
            TempFolder + "\\Enable-Location-Tracking.ps1",
            TempFolder + "\\Light-Mode.ps1",
            TempFolder + "\\Enable-Clipboard-History.ps1",
            TempFolder + "\\Enable-Hibernation.ps1",
            TempFolder + "\\Set-Explorer-LaunchTo-Fast-Access.ps1",
        };
    }
}
