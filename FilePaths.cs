using System;
using System.IO;

namespace Advanced_Windows_Tool
{
    internal class FilePaths
    {
        /* Folder Locations*/
        public string[] Temporary =
        {
        // Windows Temporary Folders
            Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Temp", // Temp
            Path.GetTempPath(), // %Temp%
            Environment.GetFolderPath(Environment.SpecialFolder.Recent), // Recent
            Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Windows\Prefetch", // Prefetch
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Microsoft\Windows\WebCache",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Microsoft\FontCache",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\CrashDumps",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Microsoft\Windows\INetCache\IE",
        // Windows Temporary Folders

        // Discord
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Code Cache\js\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Code Cache\wasm\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\GPUCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\logs",
        // Discord

        // Spotify
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Spotify\Storage\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Spotify\Browser\GPUCache",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Spotify\Browser\Cache",
        // Spotify

        // Chromium apps
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\BraveSoftware\Brave-Browser\User Data\Default\Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Opera Software\Opera Stable\Default\Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Vivaldi\UserData\Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Microsoft\Edge\Default\Cache\",
        // Chromium apps

        // Adobe
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Adobe\Common\Media Cache Files\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Adobe\Common\Media Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Adobe\Common\Team Projects Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Adobe\Butler\",
        // Adobe

        // Minecraft
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\webcache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\logs\",
        // Minecraft

        // Blender
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Blender Foundation\Blender\*\cache\",
        // Blender

        // Mozilla
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\Crash Reports\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mozilla\Firefox\Profiles\*\cache2\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mozilla\Firefox\Profiles\*\OfflineCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mozilla\Firefox\Profiles\*\startupCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Thunderbird\Profiles\*\cache2\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Thunderbird\Profiles\*\startupCache\",
        // Mozilla

        // Steam
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Steam\htmlcache\",
        // Steam

        // NuGet
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NuGet\Cache\",
        //NuGet

        // AMD
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\AMD\DxCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\AMD\GLCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\AMD\VkCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\AMD\Radeonsoftware\cache\",
        // AMD

        // NVIDIA
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NVIDIA Corporation\GeForceNOW\CefCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NVIDIA Corporation\GeForceNOW\IconCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NVIDIA Corporation\NV_Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NVIDIA Corporation\Installer2\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\NVIDIA\GLCache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\NVIDIA Corporation\Downloader\",
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\NVIDIA Corporation\GeForceNOW\Logs\",
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\NVIDIA Corporation\NV_Cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\NVIDIA Corporation\Installer2\",
        // NVIDIA

        // Google
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Google\Chrome\User Data\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Google\DriveFS\cef_cache\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Google\CrashReports\",
            // Google
        };

        public string[] GraphicDrivers =
        {
            // Graphic Drivers
            Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\AMD",
            Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\NVIDIA",
            Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\INTEL"
            // Graphic Drivers
        };

        public string[] TemporaryCachePaths =
        {
            // Google
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Google\Chrome\User Data\",
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google\Chrome\User Data\Default\",
            // Google

            // Vortex
            Path.GetTempPath() + @"\Vortex\",
            // Vortex

            // Origin
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Origin\"
            // Origin
        };
    }
}