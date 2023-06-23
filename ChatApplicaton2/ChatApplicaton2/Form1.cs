using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatApplicaton2
{
    public partial class Form1 : Form
    {
        private static TcpListener server;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] buffer = new byte[1024];
        private System.Net.IPAddress MyIP;
        private int port_number = 1001;
        private String selectedListItem;
        private List<TcpClient> tcpClients;
        public Thread ConnectionListenerThread { get; private set; }

        public Form1()
        {
            InitializeComponent();
            connectedLV.SelectedIndexChanged += connectedLV_SelectedIndexChanged;
            tcpClients = new List<TcpClient>();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = tbIP.Text;
                int serverPort = int.Parse(tbPort.Text);

                if (!IsConnectedToIP(serverIP))
                {
                    client = new TcpClient();
                    client.Connect(serverIP, serverPort);

                    tcpClients.Add(client);

                    stream = client.GetStream();
                    connectedLV.Items.Add(serverIP+","+ serverPort);
                    DisplayMessage("Connected with " + serverIP + "." + serverPort);

                }
                else {
                    DisplayMessage("You are already connected with " + serverIP + "." + serverPort);
                }
                

                // Start a separate thread to receive messages from the server
                var receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                DisplayMessage("Error: " + ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    DisplayMessage("Received: " + message);
                    
                }
                catch (Exception ex)
                {
                    DisplayMessage("Error: " + ex.Message);
                    break;
                }
            }
        }

        private bool IsConnectedToIP(string ipAddress)
        {
            // Check if already connected to the specified IP
            // Iterate over the connectedLV ListView and compare the IP addresses
            foreach (ListViewItem item in connectedLV.Items)
            {
                string[] ipPort = item.Text.Split(',');
                string connectedIP = ipPort[0];
                if (connectedIP == ipAddress)
                {
                    return true;
                }
            }
            return false;
        }

        private void SendMessage(string message)
        {
            if (selectedListItem != null)
            {
                try
                {
                    if (connectedLV.SelectedIndices.Count > 0)
                    {
                        foreach (int selectedIndex in connectedLV.SelectedIndices)
                        {
                            //string ipAddress = selectedListItem.Split(',')[0];
                            // int port = int.Parse(selectedListItem.Split(',')[1]);

                            //int index = connectedLV.SelectedIndex;
                            //TcpClient selectedClient = new TcpClient();
                            //selectedClient.Connect(ipAddress, port);
                            NetworkStream selectedStream = tcpClients[selectedIndex].GetStream();

                            byte[] buffer = Encoding.ASCII.GetBytes(message);
                            selectedStream.Write(buffer, 0, buffer.Length);
                            DisplayMessage("Sent to selected client: " + message);

                            //selectedClient.Close();
                        }
                    }
                    else
                    {
                        // No item selected
                        DisplayMessage("No client selected. Please select a client from the list.");
                    }
                    
                }
                catch (Exception ex)
                {
                    DisplayMessage("Error sending message to selected client: " + ex.Message);
                }
            }
            else
            {
                DisplayMessage("No client selected. Please select a client from the list.");
            }
        }


        private void DisplayMessage(string msg)
        {
            if (message.InvokeRequired)
            {
                message.Invoke(new Action<string>(DisplayMessage), new object[] { msg });
            }
            else
            {
                message.AppendText(msg + Environment.NewLine);
            }
        }

        private void requestP_Click(object sender, EventArgs e)
        {
            
        }

        private void requestForConnection()
        {
            TcpClient tempClient = new TcpClient();

            while (true)
            {
                try
                {
                    tempClient = server.AcceptTcpClient();
                    if (tempClient != null)
                    {
                        // Retrieve the client IP address
                        IPAddress clientIP = ((IPEndPoint)tempClient.Client.RemoteEndPoint).Address;
                        int clientPort = ((IPEndPoint)tempClient.Client.RemoteEndPoint).Port;

                        string clientIPAddress = clientIP.ToString();

                        DialogResult result = MessageBox.Show("Accept connection request from IP: " + clientIPAddress + "?", "Connection Request", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            tcpClients.Add(tempClient);

                            // Create a separate thread to handle communication with the accepted client
                            var communicationThread = new Thread(() => HandleCommunication(tempClient, clientIPAddress, clientPort));
                            communicationThread.Start();

                            connectedLV.Invoke(new MethodInvoker(() => { connectedLV.Items.Add(clientIPAddress + "," + clientPort); }));
                            MessageBox.Show("Ok connected");
                        }
                        else
                        {
                            tempClient.Close();
                            tempClient.Dispose();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
        private void HandleCommunication(TcpClient acceptedClient,string clientPort,int clientIPAddress)
        {
            NetworkStream clientStream = acceptedClient.GetStream();
            byte[] clientBuffer = new byte[1024];

            while (true)
            {
                try
                {
                    int bytesRead = clientStream.Read(clientBuffer, 0, clientBuffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    string message = Encoding.ASCII.GetString(clientBuffer, 0, bytesRead);
                    DisplayMessage("Received from client: (" + clientPort+","+ clientIPAddress + ") " + message);
                }
                catch (Exception ex)
                {
                    DisplayMessage("Error receiving message from client: " + ex.Message);
                    break;
                }
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            // Add your code for accepting the connection request here
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            // Add your code for disconnecting from the current connection here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetMyIP();
            listen();
            
        }
        private void listen() {
            server = new TcpListener(MyIP, port_number);
            client = new TcpClient();

            
            MessageBox.Show("started listening for machine ip :- " + MyIP.ToString() + " on :- " + port_number);
            DisplayMessage("me:"+ "started listening for machine ip :- " + MyIP.ToString() + " on :- " + port_number);
            server.Start();

            
        }
        private void SetMyIP()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);
                MyIP = ipAddresses.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                // Create a separate thread for the requestForConnection method
                Thread requestThread = new Thread(requestForConnection);
                requestThread.Start();

            }
            catch (Exception error) { }
        }

        private void sendTxt_Click(object sender, EventArgs e)
        {
            string send = sendTb.Text;
            SendMessage(send);
        }

        private void connectedLV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (connectedLV.SelectedItems.Count > 0)
            {
                selectedListItem = connectedLV.SelectedItems[0].ToString();
            }
            else
            {
                selectedListItem = null;
            }
        }

        private void connectedLV_SelectedValueChanged(object sender, EventArgs e)
        {

        }
       

    }
}
