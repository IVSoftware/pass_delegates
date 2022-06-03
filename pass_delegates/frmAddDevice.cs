using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pass_delegates
{
    public partial class frmAddDevice : Form
    {

        public frmAddDevice(string devicesDBpath)
        {
            InitializeComponent();
        }

        public event SendMessageToConsoleEventHandler SendMessageToConsole;
        protected virtual void OnSendMessageToConsole(SendMessageToConsoleEventArgs e)
        {
            SendMessageToConsole?.Invoke(this, e);
        }

        private void btnSendTestMessage_Click(object sender, EventArgs e)
        {
            OnSendMessageToConsole(new SendMessageToConsoleEventArgs("Hello from Add Device Form"));
        }
    }
}
