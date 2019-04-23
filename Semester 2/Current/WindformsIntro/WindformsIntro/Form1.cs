using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindformsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SomethingUsefull.MouseEnter += (o, e) => ChangeColor(Color.FromArgb(36,106,81));
            SomethingUsefull.MouseLeave += (o, e) => ChangeColor(Color.FromArgb(250,108,114));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Checkbox_Failsafe.Checked && dateTimePicker_Pickel.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(picturebox_ye.Width, picturebox_ye.Height);
                Random rand = new Random();
                for( int x=0; x < picturebox_ye.Width; x++)
                {
                   for (int y = 0; y < picturebox_ye.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.FromArgb(250, 108, 114) : Color.FromArgb(36, 106, 81));
                    }
                }
                picturebox_ye.Image = b;
            }
        }

        public void ChangeColor(Color c)
        {
            SomethingUsefull.BackColor = c;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
        }

        private void picturebox_ye_Click(object sender, EventArgs e)
        {

        }
    }
}
