using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrblPlotter;
using WatsonWebsocket;

using System.Configuration;

namespace GrblPlotter.GUI
{
    public partial class Connection_Form : Form
    {
        private readonly Timer _timer = new Timer();

        public Connection_Form()
        {
            

            InitializeComponent();

            _timer.Interval = 500;
            _timer.Tick += TimerTick;
            _timer.Enabled = true;

        }

        void TimerTick(object sender, EventArgs e)
        {
            txtConLog.Text = Properties.Settings.Default.textLog;
        }

       
        

        public string getIP()
        {
            string txt = txtIP.Text;
            return txt;
        }

        public string getPort()
        {
            string txt = txtPort.Text;
            return txt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadSettings();


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Properties.Settings.Default.Save();
        }
        

        private void btn_LogClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textLog = "";
            txtConLog.Clear();
        }

        public void LogUpdate()
        {
            txtConLog.Text += Properties.Settings.Default.textLog;
        }

        public void LogUpdate(string txt)
        {
            txtConLog.Text = txt;
        }

        public void LoadSettings()
        {
            txtIP.Text = Properties.Settings.Default.ip.ToString();
            txtPort.Text = Properties.Settings.Default.port.ToString();
            txtConLog.Text = Properties.Settings.Default.textLog;
            txtPythonPath.Text = Properties.Settings.Default.pythonPath;
            txtScriptPath.Text = Properties.Settings.Default.scriptPath;


        }
        public void SaveSettings()
        {
            Properties.Settings.Default.ip = txtIP.Text;
            Properties.Settings.Default.port = txtPort.Text;
            Properties.Settings.Default.textLog = txtConLog.Text;
            Properties.Settings.Default.pythonPath = txtPythonPath.Text;
            Properties.Settings.Default.scriptPath = txtScriptPath.Text;
            Properties.Settings.Default.Save();
        }

        private void btnConnectionSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            _timer.Dispose();
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textLog += "Server Listening..." + Environment.NewLine;
            Properties.Settings.Default.connectClicked = true;
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.connectClicked.ToString());
            DeactivateConnect();
        }

        

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textLog += "Server shutting down..." + Environment.NewLine;
            Properties.Settings.Default.connectClicked = false;
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.connectClicked.ToString());
            ActivateConnect();
        }

        public void DeactivateConnect()
        {
            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;
        }

        public void ActivateConnect()
        {
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.pythonPath = txtPythonPath.Text;
            Properties.Settings.Default.scriptPath = txtScriptPath.Text;
            Properties.Settings.Default.startClicked = true;
        }
        List<string> messages;
        double Xrelative;
        double Yrelative;
        ControlCameraForm _camForm;
        MainForm main;
        ControlSerialForm _serial_form;
        bool camOpen = false;

        public void sendinfo(List<string> str, double xrel, double yrel,ControlCameraForm ccf,MainForm mf, ControlSerialForm sf)
        {
            this.messages = str;
            this.Xrelative = xrel;
            this.Yrelative = yrel;
            this._camForm = ccf;
            this.main = mf;
            this._serial_form = sf;
            camOpen = true;
            Console.WriteLine("STR XREL YREL" + messages[0] + messages[1] + xrel +  yrel);
        }

        private void btnMove1_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            { 
                Console.WriteLine("INMOVE1");
                main.SendCommandFromServer(messages[0]);
            }
        }

        private void btnCenter1_Click(object sender, EventArgs e)
        {
            if (camOpen)
            {
                Console.WriteLine("INCENTER1");
                _camForm.AutoCenter();
            }
        }

        private void btnMark1_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            {
                _camForm.BtnCamCoordTool_Click_PBL();
                Console.WriteLine("INMARK1");
                main.SetPosMarkerLine_PBL(14, false);
                double Xrel = Grbl.posWork.X + Xrelative;
                double Yrel = Grbl.posWork.Y + Yrelative;
                String message1 = "X" + Xrel + " Y" + Yrel;
                Console.WriteLine("M1"+message1);
                //messages[1] = message1;
                _camForm.Teachpoint1_process_Click_PBL();
                _camForm.BtnCamCoordCam_Click_PBL();
            }
        }

        private void btnMove2_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            { 
                main.SendCommandFromServer(messages[1]);
                
                Console.WriteLine("INMOVE2 STR IS "+messages[1]);
            }
        }

        private void btnCenter2_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            { 
                Console.WriteLine("INCENTER2");
                _camForm.AutoCenter();
            }
        }

        private void btnMark2_Click(object sender, EventArgs e)
        {
            if (camOpen)
            {
                _camForm.BtnCamCoordTool_Click_PBL();
                Console.WriteLine("INMARK2");
                main.SetPosMarkerLine_PBL(20, false);
                _camForm.Teachpoint2_process_Click_PBL();
                _camForm.BtnCamCoordCam_Click_PBL();
            }
        }

        private void setTool_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            { 
                XyPoint a = new XyPoint(-116.016, -93.125);
                _camForm.OnRaiseXYEvent_PBL(new XYEventArgs(0, 1, a, "G10 L2 P6 "));   // move relative and fast
                a = new XyPoint(0, 0);
                _camForm.OnRaiseXYEvent_PBL(new XYEventArgs(0, 1, a, "G10 L2 P0 "));   // move relative and fast
            }
        }

        private void btnCamCrdManual_Click(object sender, EventArgs e)
        {
            if (camOpen) 
            {
                _camForm.BtnCamCoordCam_Click_PBL();
            }
        }

        private void btnRST_con_Click(object sender, EventArgs e)
        {
            if (camOpen)
            {
                this._serial_form.BtnGRBLHardReset_Click_PBL();
            }

        }
    }
}
