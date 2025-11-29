using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Ödevi
{
    public partial class Form2 : Form
    {
        int sayac = 3;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "metehan123")
            {
                Form3 y = new Form3();
                y.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE DENEME HAKKI ", sayac.ToString());
                sayac = sayac - 1;
            }
            if (sayac == 0)
            {
                MessageBox.Show("DENEME HAKKINIZ BİTTİ UYGULAMADAN ÇIKILIYOR...");
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
