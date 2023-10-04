using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using static ChatBot_AI.Registration.Code.Var;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ChatBot_AI.MainChat.Forms.MainChat;

namespace ChatBot_AI.Registration.Forms
{
    public partial class Registration : Form
    {
        Point mouse_point;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Registration()
        {
            InitializeComponent();

            //округление углов формы
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //check if the text are only eng letters and numbers
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                txtUsername.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //simple checks on null text you can make it in one if with &&
            if (string.IsNullOrWhiteSpace(txtHost.Text))
            {
                MessageBox.Show("Enter the host name (website url).\nThat the server side give you.", "ChatSystemClient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter any username.", "ChatSystemClient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtKey.Text.Length < 16)
            {
                MessageBox.Show("Enter a key for your text encryption.\nThe minimum key size are 16 symbols or letters.", "ChatSystemClient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtServerKey.Text))
            {
                MessageBox.Show("Enter a server key.", "ChatSystemClient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //set the vars
            strHost = txtHost.Text;
            strUsername = txtUsername.Text;
            strKey = txtKey.Text;
            strServerKey = txtServerKey.Text;

            ////Simple Check if the host are full
            //if (GetUserOnline() == GetLimitConnection())
            //{
            //    MessageBox.Show("Host are full or down.", "ChatSystemClient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //open the chat (ChatControl)
            var myControl = new ChatBot_AI.MainChat.Forms.MainChat();

            pMain.Controls.Clear();
            pMain.Controls.Add(myControl);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //simple check to don't get - online user
            if (ConnectionWasSend == false)
            {
                return;
            }

            //sending request for disconnect
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strHost);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string message = "message=" + "DISCONNECT"; // The message that the client want to send //same as connect method in chatControl
            string postData = message + "&key=" + strServerKey; // Add the key to the request data
            byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);
            request.ContentLength = data.Length;
            System.IO.Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_point = new Point(e.X, e.Y);
        }

        private void pMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouse_point.X;
                this.Top += e.Y - mouse_point.Y;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(106, 70, 155);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }
    }
}
