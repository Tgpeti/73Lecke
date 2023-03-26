namespace Gombvadaszat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void myButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (myButton1.ClickCount == 9)
            {
                MessageBox.Show("Gratulálunk nyertél");
                Environment.Exit(0);
            }
            myButton1.ClickCount++;
            myButton1.ButtonJump();
            timer1.Interval = 1000 - myButton1.ClickCount * 60;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            myButton1.ButtonJump();
        }
    }
}