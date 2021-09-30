
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
            this.FullCalib = new System.Windows.Forms.Button();
            this.ZeroXY = new System.Windows.Forms.Button();
            this.moveToZero = new System.Windows.Forms.Button();
            this.HomeXY = new System.Windows.Forms.Button();
            this.btnRST_con = new System.Windows.Forms.Button();
            this.btnCamCrdManual = new System.Windows.Forms.Button();
            this.setTool = new System.Windows.Forms.Button();
            this.btnMark2 = new System.Windows.Forms.Button();
            this.btnMark1 = new System.Windows.Forms.Button();
            this.btnCenter2 = new System.Windows.Forms.Button();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.btnCenter1 = new System.Windows.Forms.Button();
            this.btnMove1 = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.killalarmbtn = new System.Windows.Forms.Button();
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
            this.server_tab.Controls.Add(this.killalarmbtn);
            this.server_tab.Controls.Add(this.FullCalib);
            this.server_tab.Controls.Add(this.ZeroXY);
            this.server_tab.Controls.Add(this.moveToZero);
            this.server_tab.Controls.Add(this.HomeXY);
            this.server_tab.Controls.Add(this.btnRST_con);
            this.server_tab.Controls.Add(this.btnCamCrdManual);
            this.server_tab.Controls.Add(this.setTool);
            this.server_tab.Controls.Add(this.btnMark2);
            this.server_tab.Controls.Add(this.btnMark1);
            this.server_tab.Controls.Add(this.btnCenter2);
            this.server_tab.Controls.Add(this.btnMove2);
            this.server_tab.Controls.Add(this.btnCenter1);
            this.server_tab.Controls.Add(this.btnMove1);
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
            this.server_tab.Click += new System.EventHandler(this.server_tab_Click);
            // 
            // FullCalib
            // 
            this.FullCalib.Location = new System.Drawing.Point(54, 354);
            this.FullCalib.Name = "FullCalib";
            this.FullCalib.Size = new System.Drawing.Size(101, 23);
            this.FullCalib.TabIndex = 27;
            this.FullCalib.Text = "Full Calibration";
            this.FullCalib.UseVisualStyleBackColor = true;
            this.FullCalib.Click += new System.EventHandler(this.FullCalib_Click);
            // 
            // ZeroXY
            // 
            this.ZeroXY.Location = new System.Drawing.Point(267, 287);
            this.ZeroXY.Name = "ZeroXY";
            this.ZeroXY.Size = new System.Drawing.Size(100, 23);
            this.ZeroXY.TabIndex = 26;
            this.ZeroXY.Text = "ZeroXY";
            this.ZeroXY.UseVisualStyleBackColor = true;
            this.ZeroXY.Click += new System.EventHandler(this.ZeroXY_Click);
            // 
            // moveToZero
            // 
            this.moveToZero.Location = new System.Drawing.Point(161, 287);
            this.moveToZero.Name = "moveToZero";
            this.moveToZero.Size = new System.Drawing.Size(100, 23);
            this.moveToZero.TabIndex = 25;
            this.moveToZero.Text = "Move to 0,0";
            this.moveToZero.UseVisualStyleBackColor = true;
            this.moveToZero.Click += new System.EventHandler(this.moveToZero_Click);
            // 
            // HomeXY
            // 
            this.HomeXY.Location = new System.Drawing.Point(55, 287);
            this.HomeXY.Name = "HomeXY";
            this.HomeXY.Size = new System.Drawing.Size(100, 23);
            this.HomeXY.TabIndex = 24;
            this.HomeXY.Text = "HomeXY";
            this.HomeXY.UseVisualStyleBackColor = true;
            this.HomeXY.Click += new System.EventHandler(this.HomeXY_Click);
            // 
            // btnRST_con
            // 
            this.btnRST_con.Location = new System.Drawing.Point(267, 316);
            this.btnRST_con.Name = "btnRST_con";
            this.btnRST_con.Size = new System.Drawing.Size(46, 23);
            this.btnRST_con.TabIndex = 23;
            this.btnRST_con.Text = "RST";
            this.btnRST_con.UseVisualStyleBackColor = true;
            this.btnRST_con.Click += new System.EventHandler(this.btnRST_con_Click);
            // 
            // btnCamCrdManual
            // 
            this.btnCamCrdManual.Location = new System.Drawing.Point(161, 316);
            this.btnCamCrdManual.Name = "btnCamCrdManual";
            this.btnCamCrdManual.Size = new System.Drawing.Size(100, 23);
            this.btnCamCrdManual.TabIndex = 22;
            this.btnCamCrdManual.Text = "Swap Cam Coord";
            this.btnCamCrdManual.UseVisualStyleBackColor = true;
            this.btnCamCrdManual.Click += new System.EventHandler(this.btnCamCrdManual_Click);
            // 
            // setTool
            // 
            this.setTool.Location = new System.Drawing.Point(55, 316);
            this.setTool.Name = "setTool";
            this.setTool.Size = new System.Drawing.Size(100, 23);
            this.setTool.TabIndex = 21;
            this.setTool.Text = "Set Tool Distance ";
            this.setTool.UseVisualStyleBackColor = true;
            this.setTool.Click += new System.EventHandler(this.setTool_Click);
            // 
            // btnMark2
            // 
            this.btnMark2.Location = new System.Drawing.Point(216, 412);
            this.btnMark2.Name = "btnMark2";
            this.btnMark2.Size = new System.Drawing.Size(75, 23);
            this.btnMark2.TabIndex = 20;
            this.btnMark2.Text = "MARK2";
            this.btnMark2.UseVisualStyleBackColor = true;
            this.btnMark2.Click += new System.EventHandler(this.btnMark2_Click);
            // 
            // btnMark1
            // 
            this.btnMark1.Location = new System.Drawing.Point(54, 412);
            this.btnMark1.Name = "btnMark1";
            this.btnMark1.Size = new System.Drawing.Size(75, 23);
            this.btnMark1.TabIndex = 19;
            this.btnMark1.Text = "MARK1 ";
            this.btnMark1.UseVisualStyleBackColor = true;
            this.btnMark1.Click += new System.EventHandler(this.btnMark1_Click);
            // 
            // btnCenter2
            // 
            this.btnCenter2.Location = new System.Drawing.Point(297, 383);
            this.btnCenter2.Name = "btnCenter2";
            this.btnCenter2.Size = new System.Drawing.Size(75, 23);
            this.btnCenter2.TabIndex = 18;
            this.btnCenter2.Text = "CENTER2";
            this.btnCenter2.UseVisualStyleBackColor = true;
            this.btnCenter2.Click += new System.EventHandler(this.btnCenter2_Click);
            // 
            // btnMove2
            // 
            this.btnMove2.Location = new System.Drawing.Point(216, 383);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(75, 23);
            this.btnMove2.TabIndex = 17;
            this.btnMove2.Text = "MOVE2";
            this.btnMove2.UseVisualStyleBackColor = true;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // btnCenter1
            // 
            this.btnCenter1.Location = new System.Drawing.Point(135, 383);
            this.btnCenter1.Name = "btnCenter1";
            this.btnCenter1.Size = new System.Drawing.Size(75, 23);
            this.btnCenter1.TabIndex = 16;
            this.btnCenter1.Text = "CENTER1";
            this.btnCenter1.UseVisualStyleBackColor = true;
            this.btnCenter1.Click += new System.EventHandler(this.btnCenter1_Click);
            // 
            // btnMove1
            // 
            this.btnMove1.Location = new System.Drawing.Point(54, 383);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(75, 23);
            this.btnMove1.TabIndex = 15;
            this.btnMove1.Text = "MOVE1 ";
            this.btnMove1.UseVisualStyleBackColor = true;
            this.btnMove1.Click += new System.EventHandler(this.btnMove1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Script Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Python Path";
            // 
            // txtPythonPath
            // 
            this.txtPythonPath.Location = new System.Drawing.Point(121, 235);
            this.txtPythonPath.Name = "txtPythonPath";
            this.txtPythonPath.Size = new System.Drawing.Size(278, 20);
            this.txtPythonPath.TabIndex = 12;
            this.txtPythonPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScriptPath
            // 
            this.txtScriptPath.Location = new System.Drawing.Point(121, 261);
            this.txtScriptPath.Name = "txtScriptPath";
            this.txtScriptPath.Size = new System.Drawing.Size(278, 20);
            this.txtScriptPath.TabIndex = 11;
            this.txtScriptPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(318, 203);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_LogClear
            // 
            this.btn_LogClear.Location = new System.Drawing.Point(237, 203);
            this.btn_LogClear.Name = "btn_LogClear";
            this.btn_LogClear.Size = new System.Drawing.Size(75, 23);
            this.btn_LogClear.TabIndex = 9;
            this.btn_LogClear.Text = "Clear";
            this.btn_LogClear.UseVisualStyleBackColor = true;
            this.btn_LogClear.Click += new System.EventHandler(this.btn_LogClear_Click);
            // 
            // txtConLog
            // 
            this.txtConLog.Location = new System.Drawing.Point(53, 113);
            this.txtConLog.Multiline = true;
            this.txtConLog.Name = "txtConLog";
            this.txtConLog.ReadOnly = true;
            this.txtConLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConLog.Size = new System.Drawing.Size(346, 84);
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // killalarmbtn
            // 
            this.killalarmbtn.Location = new System.Drawing.Point(326, 316);
            this.killalarmbtn.Name = "killalarmbtn";
            this.killalarmbtn.Size = new System.Drawing.Size(97, 23);
            this.killalarmbtn.TabIndex = 28;
            this.killalarmbtn.Text = "Kill Alarm";
            this.killalarmbtn.UseVisualStyleBackColor = true;
            this.killalarmbtn.Click += new System.EventHandler(this.killalarmbtn_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 552);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnectionSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connection_Form";
            this.Text = "Connection Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.server_tab.ResumeLayout(false);
            this.server_tab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnCenter2;
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.Button btnCenter1;
        private System.Windows.Forms.Button btnMove1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnMark2;
        private System.Windows.Forms.Button btnMark1;
        private System.Windows.Forms.Button setTool;
        private System.Windows.Forms.Button btnCamCrdManual;
        private System.Windows.Forms.Button btnRST_con;
        private System.Windows.Forms.Button moveToZero;
        private System.Windows.Forms.Button HomeXY;
        private System.Windows.Forms.Button ZeroXY;
        private System.Windows.Forms.Button FullCalib;
        private System.Windows.Forms.Button killalarmbtn;
    }
}