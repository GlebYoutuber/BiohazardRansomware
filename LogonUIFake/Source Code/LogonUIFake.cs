using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiohazardLogOnUIFake
{
    public partial class LogonUIFake : Form
    {
        public LogonUIFake()
        {
            InitializeComponent();
            this.pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            pictureBox1.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            pictureBox1.Top = Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();
        }

        private void LogonUIFake_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
