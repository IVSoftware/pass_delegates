﻿
namespace pass_delegates
{
    partial class frmAddDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendTestMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendTestMessage
            // 
            this.btnSendTestMessage.Location = new System.Drawing.Point(43, 68);
            this.btnSendTestMessage.Name = "btnSendTestMessage";
            this.btnSendTestMessage.Size = new System.Drawing.Size(379, 34);
            this.btnSendTestMessage.TabIndex = 0;
            this.btnSendTestMessage.Text = "Send Test Message";
            this.btnSendTestMessage.UseVisualStyleBackColor = true;
            this.btnSendTestMessage.Click += new System.EventHandler(this.btnSendTestMessage_Click);
            // 
            // frmAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 394);
            this.Controls.Add(this.btnSendTestMessage);
            this.Name = "frmAddDevice";
            this.Text = "frmAddDevice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendTestMessage;
    }
}