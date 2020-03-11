using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'w') 
            {
                pictureBox1.Top = pictureBox1.Top - 10;
                return;
            }
            if (e.KeyChar == 's')
            {
                pictureBox1.Top = pictureBox1.Top + 10;
                return;
            }
            if (e.KeyChar == 'a')
            {
                pictureBox1.Left = pictureBox1.Left - 10;
                return;
            }
            if (e.KeyChar == 'd')
            {
                pictureBox1.Left = pictureBox1.Left + 10;
                return;
            }
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
