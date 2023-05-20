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
    public partial class FrmSayac : Form
    {
        public FrmSayac()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void buttonSay_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            if (radioButton1.Checked)
            {
                for (int i = 1; i <= 20; i++){textBox1.Text += i+"\r\n";}
            }
            else if (radioButton2.Checked)
            {
                for (int i = 2; i <= 20; i+=2) { textBox1.Text += i + "\r\n"; }
            }
            else if (radioButton5.Checked)
            {
                for (int i = 5; i <= 20; i += 5) { textBox1.Text += i + "\r\n"; }
            }
            else if (radioButton10.Checked)
            {
                for (int i = 10; i <= 20; i += 10) { textBox1.Text += i + "\r\n"; }
            }
            else
            {
                textBox1.Text = "Hata!";
            }
        }
    }
}
