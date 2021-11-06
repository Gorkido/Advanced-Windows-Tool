/* "Advanced Windows Tool" Written by Gorkido aka Gorkido#8195 on Discord */

using System;
using System.IO;

namespace Advanced_Windows_Tool
{
    internal class FilePaths
    {
        private static readonly string UsrProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private static readonly string MyComp = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        private static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string Recent = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
        private static readonly string Temp = Path.GetTempPath();
        private static readonly string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        private static readonly string PF = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        /* Folder Locations*/
        public string[] Temporary =
        {
        // Windows Temporary Folders
            WinDir + "\\Temp", // Temp
            Temp, // %Temp%
            Recent, // Recent
            MyComp + "\\Windows\\Prefetch", // Prefetch
            UsrProfile + "\\AppData\\Local\\Microsoft\\Windows\\WebCache",
            UsrProfile + "\\AppData\\Local\\Microsoft\\FontCache",
            UsrProfile + "\\AppData\\Local\\CrashDumps",
            UsrProfile + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
        // Windows Temporary Folders

        // Discord
            AppData + "\\discord\\Cache\\",
            AppData + "\\discord\\Code Cache\\js\\",
            AppData + "\\discord\\Code Cache\\wasm\\",
            AppData + "\\discord\\GPUCache\\",
            AppData + "\\discord\\logs",
        // Discord

        // Spotify
            UsrProfile + "\\AppData\\Local\\Spotify\\Storage\\",
            UsrProfile + "\\Spotify\\Browser\\GPUCache",
            UsrProfile + "\\Spotify\\Browser\\Cache",
        // Spotify

        // Chromium apps
            UsrProfile + "\\AppData\\Local\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Cache\\",
            UsrProfile + "\\AppData\\Local\\Opera Software\\Opera Stable\\Default\\Cache\\",
            UsrProfile + "\\AppData\\Local\\Vivaldi\\UserData\\Cache\\",
            UsrProfile + "\\AppData\\Local\\Microsoft\\Edge\\Default\\Cache\\",
        // Chromium apps

        // Adobe
            AppData + "\\Adobe\\Common\\Media Cache Files\\",
            AppData + "\\Adobe\\Common\\Media Cache\\",
            AppData + "\\Adobe\\Common\\Team Projects Cache\\",
            AppData + "\\Adobe\\Butler\\",
        // Adobe

        // Minecraft
            AppData + "\\.minecraft\\webcache\\",
            AppData + "\\.minecraft\\logs\\",
        // Minecraft

        // Blender
            AppData + "\\Blender Foundation\\Blender\\*\\cache\\",
        // Blender

        // Mozilla
            AppData + "\\Mozilla\\Firefox\\Crash Reports\\",
            UsrProfile + "\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\*\\cache2\\",
            UsrProfile + "\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\*\\OfflineCache\\",
            UsrProfile + "\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\*\\startupCache\\",
            UsrProfile + "\\AppData\\Local\\Thunderbird\\Profiles\\*\\cache2\\",
            UsrProfile + "\\AppData\\Local\\Thunderbird\\Profiles\\*\\startupCache\\",
        // Mozilla

        // Steam
            UsrProfile + "\\AppData\\Local\\Steam\\htmlcache\\",
        // Steam

        // NuGet
            UsrProfile + "\\AppData\\Local\\NuGet\\Cache\\",
        //NuGet

        // AMD
            UsrProfile + "\\AppData\\Local\\AMD\\DxCache\\",
            UsrProfile + "\\AppData\\Local\\AMD\\GLCache\\",
            UsrProfile + "\\AppData\\Local\\AMD\\VkCache\\",
            UsrProfile + "\\AppData\\Local\\AMD\\Radeonsoftware\\cache\\",
        // AMD

        // NVIDIA
            UsrProfile + "\\AppData\\Local\\NVIDIA Corporation\\GeForceNOW\\CefCache\\",
            UsrProfile + "\\AppData\\Local\\NVIDIA Corporation\\GeForceNOW\\IconCache\\",
            UsrProfile + "\\AppData\\Local\\NVIDIA Corporation\\NV_Cache\\",
            UsrProfile + "\\AppData\\Local\\NVIDIA Corporation\\Installer2\\",
            UsrProfile + "\\AppData\\Local\\NVIDIA\\GLCache\\",
            PF + "\\NVIDIA Corporation\\Downloader\\",
            PF + "\\NVIDIA Corporation\\GeForceNOW\\Logs\\",
            PF + "\\NVIDIA Corporation\\NV_Cache\\",
            PF + "\\NVIDIA Corporation\\Installer2\\",
        // NVIDIA

        // Google
            UsrProfile + "\\AppData\\Local\\Google\\DriveFS\\cef_cache\\",
            UsrProfile + "\\AppData\\Local\\Google\\CrashReports\\",
        // Google
        };

        public string[] GraphicDrivers =
        {
            // Graphic Drivers
            MyComp + "\\AMD",
            MyComp + "\\NVIDIA",
            MyComp + "\\INTEL"
            // Graphic Drivers
        };

        public string[] TemporaryCachePaths =
        {
            // Google
            UsrProfile + "\\AppData\\Local\\Google\\Chrome\\User Data\\",
            UsrProfile + "\\Google\\Chrome\\User Data\\Default\\",
            // Google

            // Vortex
            Temp + "\\Vortex\\",
            // Vortex

            // Origin
            UsrProfile + "\\Origin\\"
            // Origin
        };
    }
}

/* "Advanced Windows Tool" Written by Gorkido aka Gorkido#8195 on Discord */