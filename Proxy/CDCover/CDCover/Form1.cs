using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace CDCover
{
    class Form1 : Form
    {
        public Button button1;
        PictureBox pictureBox;
        ImageProxy proxy;

        public Form1()
        {
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);

            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);

            proxy = new ImageProxy();
            pictureBox.Image = proxy.GetImage();
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetImage();
        }

        private void GetImage()
        {
            pictureBox.Image = proxy.GetImage();
        }
    }
}
