
namespace pass_delegates
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.btnFrmAddDevice = new System.Windows.Forms.Button();
            this.btnFrmEditDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(53, 31);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(353, 289);
            this.textBoxConsole.TabIndex = 0;
            // 
            // btnFrmAddDevice
            // 
            this.btnFrmAddDevice.Location = new System.Drawing.Point(53, 339);
            this.btnFrmAddDevice.Name = "btnFrmAddDevice";
            this.btnFrmAddDevice.Size = new System.Drawing.Size(158, 34);
            this.btnFrmAddDevice.TabIndex = 1;
            this.btnFrmAddDevice.Text = "+ frmAddDevice";
            this.btnFrmAddDevice.UseVisualStyleBackColor = true;
            this.btnFrmAddDevice.Click += new System.EventHandler(this.btnFrmAddDevice_Click);
            // 
            // btnFrmEditDB
            // 
            this.btnFrmEditDB.Location = new System.Drawing.Point(248, 339);
            this.btnFrmEditDB.Name = "btnFrmEditDB";
            this.btnFrmEditDB.Size = new System.Drawing.Size(158, 34);
            this.btnFrmEditDB.TabIndex = 1;
            this.btnFrmEditDB.Text = "+ frmEditDB";
            this.btnFrmEditDB.UseVisualStyleBackColor = true;
            this.btnFrmEditDB.Click += new System.EventHandler(this.btnFrmEditDB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 394);
            this.Controls.Add(this.btnFrmEditDB);
            this.Controls.Add(this.btnFrmAddDevice);
            this.Controls.Add(this.textBoxConsole);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button btnFrmAddDevice;
        private System.Windows.Forms.Button btnFrmEditDB;
    }
}

