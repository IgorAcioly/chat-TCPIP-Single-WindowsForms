using System.Net;
using System.Net.Sockets;
using System.IO;


namespace TCPChat2
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtBox_ServerIP.Text = address.ToString();
                }



            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, int.Parse(txtBox_ServerPort.Text));
                listener.Start();
                client = listener.AcceptTcpClient();

                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;

                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;

                txtBox_ChatScreen.AppendText("Servidor iniciado e cliente conectado.\n");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("A porta selecionada já está em uso.");
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtBox_ClientIP.Text), int.Parse(txtBox_ClientPort.Text));

            try
            {

                txtBox_ChatScreen.AppendText("Connected to server\n");

                client.Connect(IpEnd);

                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    recieve = STR.ReadLine();
                    if (recieve == null) break; //Fecha a conexão de forma segura

                    this.txtBox_ChatScreen.Invoke(new MethodInvoker(delegate ()
                    {
                        txtBox_ChatScreen.AppendText("Guest: " + recieve + "\n");
                    }));

                }
            }
            catch (IOException)
            {
                this.txtBox_ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    txtBox_ChatScreen.AppendText("Cliente desconectado do servidor.\n");
                }));

            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.txtBox_ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    txtBox_ChatScreen.AppendText("Host: " + recieve + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }

            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtBox_Message.Text != "")
            {
                TextToSend = txtBox_Message.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtBox_Message.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    STR.Close();
                    STW.Close();
                    client.Close();

                    txtBox_ChatScreen.AppendText("Cliente desconectado.\n");
                }
                if (listener != null)
                {
                    listener.Stop();
                    txtBox_ChatScreen.AppendText("Servidor parado.\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao parar o servidor: " + ex.Message);
            }
        }



        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                client.Close();
                STR.Close();
                STW.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
