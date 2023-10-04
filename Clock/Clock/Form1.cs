using System;
using System.Drawing;
using System.Windows.Forms;

namespace MechanicalClockApp
{
    public class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            // ������� ������ ��� ���������� ������� ������ �������
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // ��������� ������� ���������� ����� �� ������ �������� �������
            DateTime now = DateTime.Now;

            int seconds = now.Second;
            int minutes = now.Minute;
            int hours = now.Hour % 12; // ���� � 12-������� �������

            // ������������� ���� �������� ���������� �����
            int secondsAngle = seconds * 6; // 360 �������� / 60 ������ = 6 �������� � �������
            int minutesAngle = (minutes * 6) + (seconds / 10); // 360 �������� / 60 ����� = 6 �������� � ������
            int hoursAngle = (hours * 30) + (minutes / 2); // 360 �������� / 12 ����� = 30 �������� � ���

            // ��������� ����������� ����� (PictureBox)
            UpdateClockImage(secondsAngle, minutesAngle, hoursAngle);
        }

        private void UpdateClockImage(int secondsAngle, int minutesAngle, int hoursAngle)
        {
            // ��������� ����������� ������������ ����� �� �������� ��� �����
            // � ���������� ��� ��� ����������� � PictureBox.
            // ��������� ������� ��� ���������� ����� � ������� GDI+.

            // ������:
            //pictureBoxClock.Image = Properties.Resources.clock; // �������� �� ��� ������
            //using (Graphics g = Graphics.FromImage(pictureBoxClock.Image))
            //{
            //    // ��������� �������� ����������
            //    g.TranslateTransform(pictureBoxClock.Width / 2, pictureBoxClock.Height / 2);
            //    g.RotateTransform(secondsAngle);
            //    // ��������� ��������� �������
            //    g.DrawLine(Pens.Red, 0, 0, 0, -pictureBoxClock.Height / 2);
            //    // ��������� ��� �������� � ������� �������
            //}

            //// ��������� PictureBox
            //pictureBoxClock.Invalidate();
        }
    }
}