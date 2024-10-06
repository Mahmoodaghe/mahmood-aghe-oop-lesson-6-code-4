using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace محمود_اغا_lessons_6_code_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap my_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x, y;
            for (x = 0; x < 100; x++)
            {
                y = x;
                my_bitmap.SetPixel(x, y, Color.Red);
            }
   
            pictureBox1.Image = my_bitmap;
            this.BackgroundImage = my_bitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
