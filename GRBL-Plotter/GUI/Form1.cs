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
        WatsonWsServer ws ;
        public Form1(WatsonWsServer server)
        {
            ws = server;
            InitializeComponent();
            
        }

        public void ClientConnected(object sender, ClientConnectedEventArgs args)
        {
            //txtConLog.Text += args.IpPort + Environment.NewLine;
            LogUpdate("Client connected: " + args.IpPort);
        }

        public void ClientDisconnected(object sender, ClientDisconnectedEventArgs args)
        {
            LogUpdate("Client disconnected: " + args.IpPort);
        }

        public void MessageReceived(object sender, MessageReceivedEventArgs args)
        {
            LogUpdate("Message received from " + args.IpPort + ": " + Encoding.UTF8.GetString(args.Data));
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

        }
        

        private void btn_LogClear_Click(object sender, EventArgs e)
        {
            txtConLog.Clear();
        }

        public void LogUpdate(string txt)
        {
            txtConLog.Text += txt + Environment.NewLine;
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

        public async void btnConnect_Click(object sender, EventArgs e)
        {

            await Connect();
            
        }

        public async Task Connect()
        {
            await Task.Run(() =>
            {
                ws.ClientConnected += ClientConnected;
                ws.ClientDisconnected += ClientDisconnected;
                ws.MessageReceived += MessageReceived;
                ws.Start();
            }).ConfigureAwait(true);
        }

    }
}
