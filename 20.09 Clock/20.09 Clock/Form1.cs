using System.Drawing;

namespace _20._09_Clock
{
    public partial class Form1 : Form
    {
        private Point center;
        private int radius;
        private int Length;

        public Form1()
        {
            InitializeComponent();
            center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            radius = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2 - 20;
            Length = radius - 20;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            DateTime date = DateTime.Now;
            int sec = date.Second;
            int min = date.Minute;
            int hours = date.Hour % 12;
            Graphics graph = e.Graphics;
            graph.Clear(Color.Beige);
            graph.DrawEllipse(Pens.Black, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            for (int i = 1; i <= 12; i++)
            {
                double hour = (i * 30 - 90) * Math.PI / 180;
                int numeralSize = 20;

                int x = center.X + (int)((radius - 30) * Math.Cos(hour)) - numeralSize / 2;
                int y = center.Y + (int)((radius - 30) * Math.Sin(hour)) - numeralSize / 2;

                graph.DrawString(i.ToString(), this.Font, Brushes.Black, x, y);
            }
            for (int i = 0; i < 60; i++)
            {
                double minute = (i * 6 - 90) * Math.PI / 180;
                int size = (i % 5 == 0) ? 8 : 4;

                int x = center.X + (int)((radius - size - 10) * Math.Cos(minute)) - size / 2;
                int y = center.Y + (int)((radius - size - 10) * Math.Sin(minute)) - size / 2;

                graph.FillEllipse(Brushes.Black, x, y, size, size);
            }

            Pen pen = Pens.Black;

            double hourAngle = (hours + min / 60.0) * 30;
            double angleRadians = hourAngle * Math.PI / 180.0;
            int x2 = center.X + (int)(Length * Math.Sin(angleRadians));
            int y2 = center.Y - (int)(Length * Math.Cos(angleRadians));
            graph.DrawLine(new Pen(pen.Color, 6), center, new Point(x2, y2));


            double minuteAngle = (min + sec / 60.0) * 6;
            angleRadians = minuteAngle * Math.PI / 180.0;
            x2 = center.X + (int)(Length * Math.Sin(angleRadians));
            y2 = center.Y - (int)(Length * Math.Cos(angleRadians));
            graph.DrawLine(new Pen(pen.Color, 4), center, new Point(x2, y2));

            double secondAngle = sec * 6;
            pen = Pens.Red;
            angleRadians = secondAngle * Math.PI / 180.0;
            x2 = center.X + (int)(Length * Math.Sin(angleRadians));
            y2 = center.Y - (int)(Length * Math.Cos(angleRadians));
            graph.DrawLine(new Pen(pen.Color, 2), center, new Point(x2, y2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}