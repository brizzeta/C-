using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChatBot_AI.Registration.Code.Var;
using static ChatBot_AI.Registration.Code.Encryption;
using System.Net.Http;

namespace ChatBot_AI.MainChat.Forms
{
    public partial class MainChat : UserControl
    {

        public MainChat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //настройка цветов кнопок
        

        private void ChatControl_Load(object sender, EventArgs e)
        {

            //Try to send a connect message
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strHost);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string message = "message=" + "CONNECT"; //dont encrypt this the server don't have the key of decryption
            string postData = message + "&key=" + strServerKey;
            byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);
            request.ContentLength = data.Length;
            System.IO.Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            ConnectionWasSend = true;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
            Task.Run(() => GetLatestMessage());
        }

        private async void GetLatestMessage()
        {
            while (true)
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(strHost);
                    if (response.IsSuccessStatusCode)
                    {
                        string html = await response.Content.ReadAsStringAsync();

                        //finding the message without the html code
                        int startIndex = html.LastIndexOf("<p id='Message'") + 15;
                        int endIndex = html.LastIndexOf("</p></div>");
                        LastMessgae = html.Substring(startIndex + 1, endIndex - startIndex - 1);

                        //don't get spam messages
                        if (LastMessgae != CurrentMessage)
                        {
                            CurrentMessage = LastMessgae;

                            switch (CurrentMessage)
                            {
                                case "CONNECT":
                                    textBox2.AppendText("Someone is connect" + Environment.NewLine);
                                    break;
                                case "DISCONNECT":
                                    textBox2.AppendText("Someone is disconnect" + Environment.NewLine);
                                    break;
                                default:
                                    textBox2.AppendText(Decrypt(CurrentMessage, strKey) + Environment.NewLine);
                                    break;
                            }
                        }
                    }
                }

                //1sec delay
                await Task.Delay(1000);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //simple check for null messages
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                return;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strHost);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string message = "message=" + Encrypt(strUsername + ": " + textBox1.Text, strKey); // The message that the client wants to send
            string postData = message + "&key=" + strServerKey; // Add the key to the request data
            byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);
            request.ContentLength = data.Length;
            System.IO.Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

            textBox1.Clear();
            textBox1.Refresh();
        }

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            //check if user press enter in rtbmessage
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
