using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Client
{
    public class ChatSend
    {
        private Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private IPEndPoint localIP;
        private IPEndPoint localBroadcatst;
        private byte[] BUFFER = new byte[1024];
        private const int buffer = 1024;
        private TextBox texbox;
        private Timer Timer = new Timer();
        private static string MesTemp;
        // private SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();//
        public ChatSend(int portS, int portM, string ipConnect, TextBox a)
        {
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            texbox = a;
            localBroadcatst = new IPEndPoint(IPAddress.Parse(ipConnect), portS);
            localIP = new IPEndPoint(IPAddress.Any, portM);
            clientSocket.EnableBroadcast = true;
            Timer.Start();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (MesTemp != null)
            {
                texbox.Update();
                texbox.AppendText(MesTemp);
                texbox.AppendText(Environment.NewLine);
                texbox.Update();
                MesTemp = null;
            }
           
        }
        public bool ConnectToServer()
        {
            try
            {
                IPEndPoint iPE = localIP;
                UdpClient udpClient = new UdpClient();
                udpClient.Client = clientSocket;
                byte[] buffer = Encoding.ASCII.GetBytes("[CHATDISCOVER]");
                udpClient.Send(buffer, buffer.Length, localBroadcatst.Address.ToString(), localBroadcatst.Port);
                byte[] bu = udpClient.Receive(ref iPE);
                string mes = Encoding.ASCII.GetString(bu);
                if (mes == "[CHATDISCOVERConnect]")
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public void SendMessage(string mes)
        {
            try
            {
                if (!clientSocket.IsBound)
                {
                    clientSocket.Bind(localIP);
                }
                if (clientSocket == null)
                {
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    clientSocket.EnableBroadcast = true;
                    clientSocket.Bind(localIP);
                }
                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                BUFFER = Encoding.ASCII.GetBytes(mes.Trim());
                socketAsyncEvent.SetBuffer(BUFFER, 0, BUFFER.Length);
                socketAsyncEvent.RemoteEndPoint = localBroadcatst;
                clientSocket.SendToAsync(socketAsyncEvent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Recive()
        {
            try
            {
                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                socketAsyncEvent.SetBuffer(new byte[1024], 0, 1024);
                socketAsyncEvent.RemoteEndPoint = new IPEndPoint(IPAddress.Any, localIP.Port);//Приймаємо данні на любий порт
                if (!clientSocket.IsBound)
                {
                    clientSocket.Bind(localIP);
                }
                socketAsyncEvent.Completed += ChangeTexBox;
                clientSocket.ReceiveFromAsync(socketAsyncEvent);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // MessageBox.Show(ex.Message);
            }
        }
        private void ChangeTexBox(object? sender, SocketAsyncEventArgs e)
        {
            string mes = Encoding.ASCII.GetString(e.Buffer);
            MesTemp = mes;
            //if (texbox.InvokeRequired)
            //    texbox.Invoke(new Action<string>((s) => texbox.Text += s), mes);
            //else
            //    texbox.Text += mes;
            Recive();
        }
        public void Disconect()
        {
            Timer.Stop();
            try
            {

                clientSocket.Close();
                clientSocket.Dispose();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
