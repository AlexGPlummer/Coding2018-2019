using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Random rand = new Random();
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.BigChungus);
            b1.Add(Properties.Resources.Funny_Computers_38);
            b1.Add(Properties.Resources.mouse_in_a_mouse);
            b1.Add(Properties.Resources.pika);
            b1.Add(Properties.Resources.potato_computer_funny_);
            b1.Add(Properties.Resources.sponge);
            b1.Add(Properties.Resources.yeee);
            pictureBox1.Click += (o, e) => this.BackgroundImage = b1[rand.Next(0, 6)];
            InitializeComponent();
        }   
    }
}
