using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pass_delegates
{
    public partial class frmEditDBs : Form
    {
        public frmEditDBs(string devicesDBpath, string current_device)
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
            OnSendMessageToConsole(new SendMessageToConsoleEventArgs("Edit DBs Device Form says HELLO"));
        }
    }
}
