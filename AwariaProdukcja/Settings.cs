using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwariaProdukcja
{
    public partial class Settings : Form
    {
        FileOperations ops = new FileOperations();
        public string LogFormat { get; set; }

        public Settings()
        {
            InitializeComponent();
            tboxPath.Text = FileOperations.ReadSetting("PathToMonitor");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tboxPath.Text.Length != 0)
            {
                if (ops.CheckIfFolderExists(tboxPath.Text))
                {
                    FileOperations.AddUpdateAppSetting("PathToMonitor", tboxPath.Text);
                    FileOperations.AddUpdateAppSetting("LogFormat", LogFormat);
                    Close();
                }
            }
        }

        private void rbtnXML_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnXML.Checked)
            {
                LogFormat = "XML";
            }
        }

        private void rbtnTXT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTXT.Checked)
            {
                LogFormat = "TXT";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
