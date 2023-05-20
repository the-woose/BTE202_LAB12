namespace BTE202_LAB12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSayac frm_sayac = new FrmSayac();
            frm_sayac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmZar frm_zar = new FrmZar();
            frm_zar.ShowDialog();
        }
    }
}