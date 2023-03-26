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
            myButton1.ClickCount++;
            myButton1.ButtonJump();
        }
    }
}