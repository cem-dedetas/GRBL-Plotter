
namespace GrblPlotter.GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.server_tab = new System.Windows.Forms.TabPage();
            this.log_tab = new System.Windows.Forms.TabPage();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btn_LogClear = new System.Windows.Forms.Button();
            this.btnLogSave = new System.Windows.Forms.Button();
            this.txtConLog = new System.Windows.Forms.TextBox();
            this.label_ConLog = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.server_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.server_tab);
            this.tabControl1.Controls.Add(this.log_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // server_tab
            // 
            this.server_tab.Controls.Add(this.label_ConLog);
            this.server_tab.Controls.Add(this.btn_LogClear);
            this.server_tab.Controls.Add(this.btnLogSave);
            this.server_tab.Controls.Add(this.txtConLog);
            this.server_tab.Controls.Add(this.btnConnect);
            this.server_tab.Controls.Add(this.btnDisconnect);
            this.server_tab.Controls.Add(this.port_label);
            this.server_tab.Controls.Add(this.txtPort);
            this.server_tab.Controls.Add(this.label_IP);
            this.server_tab.Controls.Add(this.txtIP);
            this.server_tab.Location = new System.Drawing.Point(4, 22);
            this.server_tab.Name = "server_tab";
            this.server_tab.Padding = new System.Windows.Forms.Padding(3);
            this.server_tab.Size = new System.Drawing.Size(448, 502);
            this.server_tab.TabIndex = 0;
            this.server_tab.Text = "Server";
            this.server_tab.UseVisualStyleBackColor = true;
            // 
            // log_tab
            // 
            this.log_tab.Location = new System.Drawing.Point(4, 22);
            this.log_tab.Name = "log_tab";
            this.log_tab.Padding = new System.Windows.Forms.Padding(3);
            this.log_tab.Size = new System.Drawing.Size(448, 502);
            this.log_tab.TabIndex = 1;
            this.log_tab.Text = "Connection Log";
            this.log_tab.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(318, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(75, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(44, 61);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(26, 13);
            this.port_label.TabIndex = 3;
            this.port_label.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(318, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8080";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(318, 108);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(237, 108);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btn_LogClear
            // 
            this.btn_LogClear.Location = new System.Drawing.Point(47, 455);
            this.btn_LogClear.Name = "btn_LogClear";
            this.btn_LogClear.Size = new System.Drawing.Size(84, 23);
            this.btn_LogClear.TabIndex = 9;
            this.btn_LogClear.Text = "Clear";
            this.btn_LogClear.UseVisualStyleBackColor = true;
            // 
            // btnLogSave
            // 
            this.btnLogSave.Location = new System.Drawing.Point(309, 455);
            this.btnLogSave.Name = "btnLogSave";
            this.btnLogSave.Size = new System.Drawing.Size(84, 23);
            this.btnLogSave.TabIndex = 8;
            this.btnLogSave.Text = "Save";
            this.btnLogSave.UseVisualStyleBackColor = true;
            // 
            // txtConLog
            // 
            this.txtConLog.Location = new System.Drawing.Point(47, 181);
            this.txtConLog.Multiline = true;
            this.txtConLog.Name = "txtConLog";
            this.txtConLog.ReadOnly = true;
            this.txtConLog.Size = new System.Drawing.Size(346, 255);
            this.txtConLog.TabIndex = 7;
            // 
            // label_ConLog
            // 
            this.label_ConLog.AutoSize = true;
            this.label_ConLog.Location = new System.Drawing.Point(44, 155);
            this.label_ConLog.Name = "label_ConLog";
            this.label_ConLog.Size = new System.Drawing.Size(82, 13);
            this.label_ConLog.TabIndex = 10;
            this.label_ConLog.Text = "Connection Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 552);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.server_tab.ResumeLayout(false);
            this.server_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage server_tab;
        private System.Windows.Forms.TabPage log_tab;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btn_LogClear;
        private System.Windows.Forms.Button btnLogSave;
        private System.Windows.Forms.TextBox txtConLog;
        private System.Windows.Forms.Label label_ConLog;
    }
}