using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ChatServer
    {
        private Socket serverSocket;
        private IPEndPoint localIP;
        private const int BUFFER = 1024;
        private List<IPEndPoint> listOFClients = new List<IPEndPoint>();
        TextBox chatTexBox;
        private List<string> messages = new List<string>();
        public ChatServer(int port, TextBox textBox)
        {
            this.chatTexBox = textBox;
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            localIP = new IPEndPoint(IPAddress.Any, port);//Будем слухати
            serverSocket.EnableBroadcast = true;
        }
        private void Test(string mes)
        {
            mes += Environment.NewLine;
            if (chatTexBox.InvokeRequired)
                chatTexBox.Invoke(new Action<string>((s) => chatTexBox.Text += s), mes);
            else
                chatTexBox.Text += mes;
        }
        public void Recive()
        {
            try
            {
                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                socketAsyncEvent.SetBuffer(new byte[BUFFER], 0, BUFFER);
                socketAsyncEvent.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);//Приймаємо данні на любий порт
                if (!serverSocket.IsBound)
                {
                    serverSocket.Bind(localIP);
                }
                socketAsyncEvent.Completed += ReciveCallBack;
                serverSocket.ReceiveFromAsync(socketAsyncEvent);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.Message);
            }

        }
        private void ReciveCallBack(object? sender, SocketAsyncEventArgs e)
        {
            string mes = Encoding.ASCII.GetString(e.Buffer, 0, e.BytesTransferred);
            Debug.WriteLine($"Client ip: {e.RemoteEndPoint}\nMes: {mes}");
            if (mes.Equals("[CHATDISCOVER]"))
            {
                SendToClient("[CHATDISCOVERConnect]", e.RemoteEndPoint);
                if (!listOFClients.Contains(e.RemoteEndPoint))
                {
                    listOFClients.Add((IPEndPoint)e.RemoteEndPoint);
                    Debug.WriteLine($"Client count: {listOFClients.Count}\nRemote address: {e.RemoteEndPoint}");
                    //Sand back massage
                }
            }
            else if (listOFClients.Contains(e.RemoteEndPoint))
            {
                Test(mes);
                foreach (IPEndPoint client in listOFClients)
                {
                    if (!client.Equals(e.RemoteEndPoint)) // якщо це не я 
                    {
                        Debug.WriteLine($"Server send: ip{client} mes: {mes}");
                        SendToClient(mes, client);
                    }
                }
            }
            Recive();

        }
        private void SendToClient(string mes, EndPoint removeEndPoint)
        {
            SocketAsyncEventArgs socketAsync = new SocketAsyncEventArgs();
            socketAsync.RemoteEndPoint = removeEndPoint;
            byte[] message = Encoding.ASCII.GetBytes(mes);
            socketAsync.SetBuffer(message, 0, message.Length);
            socketAsync.Completed += SendToAllClientInfo;
            serverSocket.SendToAsync(socketAsync);
        }
        private void SendToAllClientInfo(object? sender, SocketAsyncEventArgs e)
        {
            Debug.WriteLine($"Send data to {e.RemoteEndPoint}");
            MessageBox.Show($"Send data to {e.RemoteEndPoint}");

        }
        private void ClouseServer()
        {
            foreach (IPEndPoint client in listOFClients)
            {
                SendToClient("Server Is Closed ", client);
            }
        }
        public void DisableServer()
        {
            try
            {
                ClouseServer();
                serverSocket.Close();
                serverSocket.Dispose();

            }
            catch (Exception)
            {

            }
        }
    }
}
