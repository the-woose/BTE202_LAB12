using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTE202_LAB12
{
    public partial class FrmZar : Form
    {
        public FrmZar()
        {
            InitializeComponent();
        }
        public int rollCount = 0;

        private void buttonDondur_Click(object sender, EventArgs e)
        {
            buttonDondur.Enabled = false;
            rollCount = 1;
            timer1.Enabled = true;
        }

        private void Timer1_Timer(object sender, EventArgs e)
        {
            Random sayi = new Random();
            if (rollCount > 10)
            {
                timer1.Enabled = false;
                buttonDondur.Enabled = true;
            }
            switch (sayi.Next(1, 6))
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Properties.Resources._6;
                    break;
            }
            rollCount++;
        }
    }
}
