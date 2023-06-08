namespace fukuv0608
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -5;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "ç‚ñ{Å@ïj";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx + (vx / 10));

            }
            if (label1.Right > ClientSize.Width) //ïù
            {
                vx = -Math.Abs(vx + (vx / 10));
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy + (vy / 10));

            }
            if (label1.Bottom > ClientSize.Height)Å@//çÇÇ≥
            {
                vy = -Math.Abs(vy + (vy / 10));
            }
        }
    }
}