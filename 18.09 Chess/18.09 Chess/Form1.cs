namespace _18._09_Chess
{
    public partial class Form1 : Form
    {
        bool color;

        public Form1()
        {
            InitializeComponent();
            color = false;
            Height = 679;
            Width = 656;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics graph = e.Graphics)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Brush brush = color ? Brushes.Wheat : Brushes.Peru;
                        graph.FillRectangle(brush, j * 80, i * 80, 80, 80);
                        color = !color;
                    }
                    color = !color;
                }
                for (int i = 0; i < 8; i++)
                {
                    graph.DrawImage(Image.FromFile("PawnWhite.png"), i * 83, 95);
                    graph.DrawImage(Image.FromFile("PawnBlack.png"), i * 83, 500);
                }
                graph.DrawImage(Image.FromFile("RookBlack.png"), 0, 570);
                graph.DrawImage(Image.FromFile("RookBlack.png"), 565, 570);
                graph.DrawImage(Image.FromFile("RookWhite.png"), 570, 10);
                graph.DrawImage(Image.FromFile("RookWhite.png"), 0, 10);
                graph.DrawImage(Image.FromFile("HorseBlack.png"), 485, 570);
                graph.DrawImage(Image.FromFile("HorseBlack.png"), 85, 570);
                graph.DrawImage(Image.FromFile("HorseWhite.png"), 490, 10);
                graph.DrawImage(Image.FromFile("HorseWhite.png"), 90, 10);
                graph.DrawImage(Image.FromFile("BishopBlack.png"), 410, 570);
                graph.DrawImage(Image.FromFile("BishopBlack.png"), 170, 570);
                graph.DrawImage(Image.FromFile("BishopWhite.png"), 410, 10);
                graph.DrawImage(Image.FromFile("BishopWhite.png"), 170, 10);
                graph.DrawImage(Image.FromFile("KingBlack.png"), 250, 570);
                graph.DrawImage(Image.FromFile("KingWhite.png"), 250, 10);
                graph.DrawImage(Image.FromFile("QueenBlack.png"), 330, 570);
                graph.DrawImage(Image.FromFile("QueenWhite.png"), 330, 10);
            }
        }
    }
}