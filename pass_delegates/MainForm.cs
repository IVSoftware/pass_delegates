using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_delegates
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmAddDevice?.Dispose();
            frmEditDBs?.Dispose();
            base.OnFormClosing(e);
        }

        public event SendMessageToConsoleEventHandler SendMessageToConsole;
        protected virtual void OnSendMessageToConsole(SendMessageToConsoleEventArgs e)
        {
            SendMessageToConsole?.Invoke(this, e);
        }

        private void btnFrmAddDevice_Click(object sender, EventArgs e)
        {
            if (frmAddDevice == null)
            {
                frmAddDevice = new frmAddDevice(devicesDBpath: "Some path");
                frmAddDevice.SendMessageToConsole += outputMessageToConsole;
                frmAddDevice.FormClosing += (sender, e) => {e.Cancel = true; Hide(); };
            }
            frmAddDevice.Show();
            frmAddDevice.Location = new Point(Location.X + 510, Location.Y);
        }
        frmAddDevice frmAddDevice = null;

        private void btnFrmEditDB_Click(object sender, EventArgs e)
        {
            if (frmEditDBs == null)
            {
                frmEditDBs = new frmEditDBs(devicesDBpath: "Some path", current_device: "Some Device");
                frmEditDBs.SendMessageToConsole += outputMessageToConsole;
                frmEditDBs.FormClosing += (sender, e) => { e.Cancel = true; Hide(); };
            }
            frmEditDBs.Show();
            frmEditDBs.Location = new Point(Location.X + 1010, Location.Y);
        }
        frmEditDBs frmEditDBs = null;

        private void outputMessageToConsole(object sender, SendMessageToConsoleEventArgs e)
        {
            textBoxConsole.AppendText(e.Message + Environment.NewLine);
        }
    }

    // Make sure these are outside of any other class.
    public delegate void SendMessageToConsoleEventHandler(Object sender, SendMessageToConsoleEventArgs e);
    public class SendMessageToConsoleEventArgs : EventArgs
    {
        public string Message { get; }
        public SendMessageToConsoleEventArgs(string message)
        {
            Message = message;
        }
    }
}
