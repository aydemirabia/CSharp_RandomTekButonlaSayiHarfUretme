using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = rnd.Next(5000, 10001);
            lblSayi.Text = sayi.ToString();

            //Rastgele Harf Üretme
            int harfUret = rnd.Next(65, 91);
            lblHarf.Text = Convert.ToChar(harfUret).ToString();
        }
    }
}
