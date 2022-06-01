using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;




namespace web_server
{
    public partial class Form1 : Form
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopserver.Enabled = false;

        }

        private void connectionThreadMethod()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endPoint);
                httpServer.Listen(1);
                startListeningForConnection();

            }
            catch(Exception ex)
            {
                Console.WriteLine(" i could not start");
            }
        }

        private void startListeningForConnection()
        {
            while (true)
            {
                DateTime time = DateTime.Now;

                string data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept();//blocking statement


                //reading the inbound connection data

                while (true)
                {
                    int numbytes = client.Receive(bytes);

                    data += Encoding.ASCII.GetString(bytes, 0, numbytes);
                    if (data.IndexOf("\r\n") > -1)
                        break;
                }
                //data read

                serverlogstext.Invoke((MethodInvoker)delegate {
                    // run inside the ui thread
                    serverlogstext.Text += "\r\n\r\n";
                    serverlogstext.Text += data;
                    serverlogstext.Text += "\n\n------End Of Request------";


                });
                //send back the response
                string restHeader = "Http/1.1 200 Everything is fine\nServer: my_c#_Server\nContent-Type: text/html; charset:UTF-8\n\n";
                string restBody = "<!DOCTYPE html>" +
                  "<html>" +
                  "<head><title>My Server</title></head>" +
                  "<body><h4>Server Time is: "+ time.ToString() +"</h4></body>" +
                  "</html>";
                string restStr=restHeader+ restBody;
                byte[] restData=Encoding.ASCII.GetBytes(restStr);
                client.SendTo(restData,client.RemoteEndPoint);
                client.Close();


            }
        }

        private void startserverBtn_Click(object sender, EventArgs e)
        {
            serverlogstext.Text = "";
            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort= int.Parse(serverporttext.Text.ToString());
                    if(serverPort > 65535 || serverPort <= 0)
                    {
                       throw new Exception("server port not within the range");
                    }
                }
                catch(Exception ex)
                {
                    serverPort = 80;
                    serverlogstext.Text = "Server Failed to start on specified port ...";

                }

                thread = new Thread(new ThreadStart(this.connectionThreadMethod));
                thread.Start();
                //disable and enable buttons
                startserverBtn.Enabled = false;
                stopserver.Enabled=true;
          



            }
            catch(Exception ex)
            {
                Console.WriteLine("Error While Starting Server");
                serverlogstext.Text = "Server Starting Failed";
            }
            serverlogstext.Text = "Server Started";

        }

        private void stopserver_Click(object sender, EventArgs e)
        {
            try
            {
                //close the socket
                httpServer.Close();

                //kill the thread
                thread.Abort();

                //disable and enable buttons
                startserverBtn.Enabled = true;
                stopserver.Enabled = false;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Stopping Failed");
            }
        }
    }
}