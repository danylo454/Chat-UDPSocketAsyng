using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Client
{
    public partial class ClientForm : Form
    {
        ChatSend chatClient;
        public ClientForm()
        {
            InitializeComponent();
            Disconnect_Off_BTm();
        }
        private void ConnectEnable_On_BTm()
        {
            ipComboBox.Enabled = false;
            portNumericUpDown.Enabled = false;
            portLocalNumericUpDown.Enabled = false;
            nameTextBox.Enabled = false;
            connectBtm.Enabled = false;
            connectBtm.Visible = false;
            disconnectBtm.Enabled = true;
            disconnectBtm.Visible = true;
            sendBtm.Enabled = true;
            sendBtm.Visible = true;
            myMessegeTextBox.Visible = true;
            myMessegeTextBox.Enabled = true;
        }
        private void Disconnect_Off_BTm()
        {
            portLocalNumericUpDown.Enabled = true;
            ipComboBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            myMessegeTextBox.Text = string.Empty;
            generalChatTextBox.Text = string.Empty;
            ipComboBox.Enabled = true;
            portNumericUpDown.Enabled = true;
            nameTextBox.Enabled = true;
            disconnectBtm.Enabled = false;
            disconnectBtm.Visible = false;
            connectBtm.Enabled = true;
            connectBtm.Visible = true;
            sendBtm.Enabled = false;
            sendBtm.Visible = false;
            myMessegeTextBox.Visible = false;
            myMessegeTextBox.Enabled = false;
        }
        private void connectBtm_Click(object sender, EventArgs e)
        {
            string regex = @"\b(?:(?:2(?:[0-4][0-9]|5[0-5])|[0-1]?[0-9]?[0-9])\.){3}(?:(?:2([0-4][0-9]|5[0-5])|[0-1]?[0-9]?[0-9]))\b";
            if (Regex.IsMatch(ipComboBox.Text, regex) && !string.IsNullOrEmpty(nameTextBox.Text) && (int)portLocalNumericUpDown.Value != (int)portNumericUpDown.Value)
            {
                chatClient = new ChatSend((int)portNumericUpDown.Value, (int)portLocalNumericUpDown.Value, ipComboBox.Text, generalChatTextBox);
                if (chatClient.ConnectToServer() == true)
                {
                    ConnectEnable_On_BTm();
                    chatClient.Recive();
                }
                else
                {
                    connectBtm.BackColor = Color.IndianRed;
                    connectBtm.Update();
                    Thread.Sleep(300);
                    connectBtm.BackColor = Color.FromArgb(192, 255, 192);
                    connectBtm.Update();
                }
            }
            else
            {
                connectBtm.BackColor = Color.IndianRed;
                connectBtm.Update();
                Thread.Sleep(300);
                connectBtm.BackColor = Color.FromArgb(192, 255, 192);
                connectBtm.Update();
            }
        }
        private void disconnectBtm_Click(object sender, EventArgs e)
        {
            Disconnect_Off_BTm();
            chatClient.Disconect();
            this.Close();
        }
        private void sendBtm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(myMessegeTextBox.Text))
            {
                generalChatTextBox.Text += $"{nameTextBox.Text} :{myMessegeTextBox.Text}{Environment.NewLine}";
                chatClient.SendMessage(nameTextBox.Text + ": " + myMessegeTextBox.Text);
                myMessegeTextBox.Text = String.Empty;
            }
            else
            {
                sendBtm.BackColor = Color.IndianRed;
                sendBtm.Update();
                Thread.Sleep(300);
                sendBtm.BackColor = Color.FromArgb(224, 224, 224);
                sendBtm.Update();
            }
        }
    }
}