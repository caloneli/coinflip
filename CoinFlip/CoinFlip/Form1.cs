using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flip_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int broj = random.Next(0, 2);
            if (broj == 0)
            {
                
                
                tekst.Text = Convert.ToString("It's heads!");
            }

            else if (broj == 1)
                tekst.Text = Convert.ToString("It's tails!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
