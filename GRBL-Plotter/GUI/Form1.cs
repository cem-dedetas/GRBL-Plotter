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

namespace GrblPlotter.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtConLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtConLog.Text = text;
            }
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
            Waiter();


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        

        private void btn_LogClear_Click(object sender, EventArgs e)
        {
            txtConLog.Clear();
        }

        public void LogUpdate()
        {
            txtConLog.Text += Properties.Settings.Default.textLog;
        }

        public void LoadSettings()
        {
            txtIP.Text = Properties.Settings.Default.ip.ToString();
            txtPort.Text = Properties.Settings.Default.port.ToString();


        }
        public void SaveSettings()
        {
            Properties.Settings.Default.ip = txtIP.Text;
            Properties.Settings.Default.port = txtPort.Text;
        }

        private void btnConnectionSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textLog += "Server Listening..."+ Environment.NewLine; ;
            LogUpdate();
            Properties.Settings.Default.connectClicked = true;

        }

        

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textLog += "Server shutting down..." + Environment.NewLine; ;
            LogUpdate();
            Properties.Settings.Default.connectClicked = false;
        }


        

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private async Task Updater()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    SetText(Properties.Settings.Default.textLog);
                    Task.Delay(TimeSpan.FromSeconds(1));
                }
            }).ConfigureAwait(true);
        }

        private async void Waiter()
        {
            await Updater();
        }

    }
}
