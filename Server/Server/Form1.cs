using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public partial class ServerForm : Form
    {
        private ChatServer chatServer;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Ñheck();
        }
        private void Ñheck()
        {
            if ((int)portNumericUpDown.Value > 65535)
            {
                startButton.BackColor = Color.IndianRed;
                startButton.Update();
                Thread.Sleep(300);
                startButton.BackColor = Color.FromArgb(128, 255, 128);
                startButton.Update();
            }
            else
            {
                startButton.Enabled = false;
                stopButton.Enabled = true;
                chatServer = new ChatServer((int)portNumericUpDown.Value,chatTexBox);
                chatServer.Recive();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            chatServer.DisableServer();

        }

    }
}