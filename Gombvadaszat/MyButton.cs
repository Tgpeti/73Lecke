using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gombvadaszat
{
    public partial class MyButton : Button
    {
        public int ClickCount { get; set; }
        

        public MyButton()
        {
            InitializeComponent();
            ClickCount = 0;
        }
        public void ButtonJump()
        {
            Random r = new Random();
            int randomTop = r.Next(0, 400);
            int randomRigth = r.Next(0, 700);
            Location = new Point(randomRigth, randomTop);
            this.Text = ClickCount.ToString();
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
