﻿using System;
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

    }
}