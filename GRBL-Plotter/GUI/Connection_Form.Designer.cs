
namespace GrblPlotter.GUI
{
    partial class Connection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection_Form));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnectionSave = new System.Windows.Forms.Button();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.server_tab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPythonPath = new System.Windows.Forms.TextBox();
            this.txtScriptPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn_LogClear = new System.Windows.Forms.Button();
            this.txtConLog = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.port_label = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.server_tab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnectionSave
            // 
            this.btnConnectionSave.Location = new System.Drawing.Point(290, 517);
            this.btnConnectionSave.Name = "btnConnectionSave";
            this.btnConnectionSave.Size = new System.Drawing.Size(84, 23);
            this.btnConnectionSave.TabIndex = 11;
            this.btnConnectionSave.Text = "Save";
            this.btnConnectionSave.UseVisualStyleBackColor = true;
            this.btnConnectionSave.Click += new System.EventHandler(this.btnConnectionSave_Click);
            // 
            // tabVideo
            // 
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(448, 473);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Video Feed";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // server_tab
            // 
            this.server_tab.Controls.Add(this.label2);
            this.server_tab.Controls.Add(this.label1);
            this.server_tab.Controls.Add(this.txtPythonPath);
            this.server_tab.Controls.Add(this.txtScriptPath);
            this.server_tab.Controls.Add(this.btnStart);
            this.server_tab.Controls.Add(this.btn_LogClear);
            this.server_tab.Controls.Add(this.txtConLog);
            this.server_tab.Controls.Add(this.txtPort);
            this.server_tab.Controls.Add(this.txtIP);
            this.server_tab.Controls.Add(this.btnConnect);
            this.server_tab.Controls.Add(this.btnDisconnect);
            this.server_tab.Controls.Add(this.port_label);
            this.server_tab.Controls.Add(this.label_IP);
            this.server_tab.Location = new System.Drawing.Point(4, 22);
            this.server_tab.Name = "server_tab";
            this.server_tab.Padding = new System.Windows.Forms.Padding(3);
            this.server_tab.Size = new System.Drawing.Size(448, 473);
            this.server_tab.TabIndex = 0;
            this.server_tab.Text = "Server";
            this.server_tab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Script Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Python Path";
            // 
            // txtPythonPath
            // 
            this.txtPythonPath.Location = new System.Drawing.Point(115, 385);
            this.txtPythonPath.Name = "txtPythonPath";
            this.txtPythonPath.Size = new System.Drawing.Size(278, 20);
            this.txtPythonPath.TabIndex = 12;
            this.txtPythonPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScriptPath
            // 
            this.txtScriptPath.Location = new System.Drawing.Point(115, 411);
            this.txtScriptPath.Name = "txtScriptPath";
            this.txtScriptPath.Size = new System.Drawing.Size(278, 20);
            this.txtScriptPath.TabIndex = 11;
            this.txtScriptPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(318, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_LogClear
            // 
            this.btn_LogClear.Location = new System.Drawing.Point(318, 325);
            this.btn_LogClear.Name = "btn_LogClear";
            this.btn_LogClear.Size = new System.Drawing.Size(75, 23);
            this.btn_LogClear.TabIndex = 9;
            this.btn_LogClear.Text = "Clear";
            this.btn_LogClear.UseVisualStyleBackColor = true;
            this.btn_LogClear.Click += new System.EventHandler(this.btn_LogClear_Click);
            // 
            // txtConLog
            // 
            this.txtConLog.Location = new System.Drawing.Point(47, 137);
            this.txtConLog.Multiline = true;
            this.txtConLog.Name = "txtConLog";
            this.txtConLog.ReadOnly = true;
            this.txtConLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConLog.Size = new System.Drawing.Size(346, 182);
            this.txtConLog.TabIndex = 7;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(318, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(318, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(75, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(237, 84);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(318, 84);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(44, 61);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(26, 13);
            this.port_label.TabIndex = 3;
            this.port_label.Text = "Port";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(44, 35);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(58, 13);
            this.label_IP.TabIndex = 1;
            this.label_IP.Text = "IP Address";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.server_tab);
            this.tabControl1.Controls.Add(this.tabVideo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 552);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnectionSave);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection_Form";
            this.Text = "Connection Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.server_tab.ResumeLayout(false);
            this.server_tab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnectionSave;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage server_tab;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_LogClear;
        public System.Windows.Forms.TextBox txtConLog;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox txtPythonPath;
        public System.Windows.Forms.TextBox txtScriptPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}