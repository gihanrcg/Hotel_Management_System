using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;

namespace AttendanceRecorder
{
    public partial class ChatRoom : Form
    {

        String employeeNo;

        Socket sck;
        EndPoint epLocal, epRemote;
        String myIpAddress;
        String myPort;
        String friendsIP;
        String friendsPort;

        public ChatRoom(String employeeNo)
        {
            this.employeeNo = employeeNo;
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.myIpAddress = getLocalIP();
            this.myPort = getLocalPort();
        }

        private String getLocalPort()
        {
            using (DBConnect db = new DBConnect())
            {
                String q = "select port from userip where employeeNo = '" + employeeNo + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    return r[0].ToString();
                }
            }
            return "80";
        }
        private void ChatRoom_Load(object sender, EventArgs e)
        {
            txtSearch.AutoCompleteCustomSource = loadNames();
        }
        public AutoCompleteStringCollection loadNames()
        {
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            using (DBConnect db = new DBConnect())
            {
                String q = "select name from employee";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    names.Add(r[0].ToString());
                }
                return names;
            }
        }
        public String getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void messageCallBack(IAsyncResult result)
        {
            try
            {
                int size = sck.EndReceiveFrom(result, ref epRemote);
                if (size > 0)
                {
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])result.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    String recievedMessage = eEncoding.GetString(recievedData);

                    msgBox.Items.Add(txtfriendName + " : "+ recievedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(myIpAddress), Convert.ToInt32(myPort));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(friendsIP), Convert.ToInt32(friendsPort));
                sck.Bind(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                btnConnect.Text = "Connected";
                txtMsg.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMsg.Text);
                sck.Send(msg);
                msgBox.Items.Add("You : " + txtMsg.Text);
                txtMsg.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DBConnect db = new DBConnect())
            {
                String q = "select u.ip, u.port,e.name,e.employeeNo from userip u, employee e where e.name = '" + txtSearch.Text + "' and e.employeeNo = u.employeeNo";
 try
                {
                     MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        this.friendsIP = r[0].ToString();
                        this.friendsPort = r[1].ToString();
                        txtfriendName.Text = r[2].ToString();
                        txtFriendIP.Text = friendsIP;
                    } 
                }
                else
                {

                    txtfriendName.Text = txtSearch.Text;
                    txtFriendIP.Text = "Not available right now..";
                }
                }
                catch (Exception ex)
                {
                   txtfriendName.Text = txtSearch.Text;
                    txtFriendIP.Text = "Not available right now..";
                }
            }
        }
    }
}
