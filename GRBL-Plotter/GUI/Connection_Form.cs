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
                //_camForm.BtnCamCoordTool_Click_PBL();
                Console.WriteLine("INMARK1");
                main.SetPosMarkerLine_PBL(Grbl.fiduc0, false);
                _camForm.Teachpoint1_process_Click_PBL();
                double Xrel = Grbl.posWork.X + Xrelative;
                double Yrel = Grbl.posWork.Y + Yrelative;
                String message1 = "X" + Xrel + " Y" + Yrel;
                Console.WriteLine("M1"+message1);
                messages[1] = message1;
                Console.WriteLine("MESSAGE 1 IS : " + messages[1]);
                //_camForm.BtnCamCoordCam_Click_PBL();
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
                //_camForm.BtnCamCoordTool_Click_PBL();
                Console.WriteLine("INMARK2");
                main.SetPosMarkerLine_PBL(Grbl.fiduc1, false);
                _camForm.Teachpoint2_process_Click_PBL();
                //_camForm.BtnCamCoordCam_Click_PBL();
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

        private void server_tab_Click(object sender, EventArgs e)
        {

        }

        private void HomeXY_Click(object sender, EventArgs e)
        {
            main.SendCommandFromServer("$HX");
            main.SendCommandFromServer("$HY");
        }

        private void moveToZero_Click(object sender, EventArgs e)
        {
            main.SendCommandFromServer("X8 Y40");
        }

        private void ZeroXY_Click(object sender, EventArgs e)
        {
            main.SendCommandFromServer((Grbl.isMarlin ? "G92" : "G10 L20 P0") + " X0.000 Y0.000");
        }

        private void FullCalib_Click(object sender, EventArgs e)
        {
            if (camOpen)
            {
                main.SendCommandFromServer(messages[0]);

                int pFrom;
                int pTo;

                pFrom = messages[0].IndexOf("X") + 1;
                pTo = messages[0].IndexOf(" Y");
                double resultX0 = Convert.ToDouble(messages[0].Substring(pFrom, pTo - pFrom));

                pFrom = messages[0].IndexOf("Y") + 1;
                pTo = messages[0].Length;
                double resultY0 = Convert.ToDouble(messages[0].Substring(pFrom, pTo - pFrom));
                double xabs, yabs;
                bool stay = true;
                while (stay)
                {
                    this._serial_form.ProcessGrblPositionUpdate_PBL();
                    xabs = Math.Abs(resultX0 - Grbl.posWork.X);
                    yabs = Math.Abs(resultY0 - Grbl.posWork.Y);
                    Console.Write(xabs + "-");
                    Console.WriteLine(yabs);
                    if (xabs + yabs < 0.001)
                    {
                        stay = false;
                    }
                }
                Console.WriteLine("Got Out");

                _camForm.AutoCenter();

                main.SetPosMarkerLine_PBL(Grbl.fiduc0, false);



                _camForm.Teachpoint1_process_Click_PBL();
                double Xrel = Grbl.posWork.X + Xrelative;
                double Yrel = Grbl.posWork.Y + Yrelative;
                String message1 = "X" + Xrel + " Y" + Yrel;
                Console.WriteLine("M1" + message1);
                messages[1] = message1;
                Console.WriteLine("MESSAGE 1 IS : " + messages[1]);



                main.SendCommandFromServer(messages[1]);

                pFrom = messages[1].IndexOf("X") + 1;
                pTo = messages[1].IndexOf(" Y");
                resultX0 = Convert.ToDouble(messages[1].Substring(pFrom, pTo - pFrom));

                pFrom = messages[1].IndexOf("Y") + 1;
                pTo = messages[1].Length;
                resultY0 = Convert.ToDouble(messages[1].Substring(pFrom, pTo - pFrom));
                stay = true;
                while (stay)
                {
                    this._serial_form.ProcessGrblPositionUpdate_PBL();
                    xabs = Math.Abs(resultX0 - Grbl.posWork.X);
                    yabs = Math.Abs(resultY0 - Grbl.posWork.Y);
                    if (xabs + yabs < 0.001)
                    {
                        stay = false;
                    }
                }

                _camForm.AutoCenter();

                Console.WriteLine("INMARK2");
                main.SetPosMarkerLine_PBL(Grbl.fiduc1, false);
                _camForm.Teachpoint2_process_Click_PBL();


            }
        }

        private void killalarmbtn_Click(object sender, EventArgs e)
        {
            main.SendCommandFromServer("$X");
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            main.SendCommandFromServer(commandBox.Text);
            commandBox.Text = "";
            
        }

        private void commandBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void commandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendBTN_Click(this, new EventArgs());
            }

        }
    }
}
