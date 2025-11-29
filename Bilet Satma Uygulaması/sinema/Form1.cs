using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form1 : Form
    {
        double tamFiyat;
        double indirimliFiyat;

        Sinema salon;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Sinema sınıfına fiyatları da gönderiyoruz
                salon = new Sinema(
                    textBox1.Text,
                    Convert.ToInt32(textBox2.Text),
                    tamFiyat,
                    indirimliFiyat
                );

                textBox3.Text = "Evet,Koltuk Sayısı: " + salon.BosKoltukOgren();
                if (salon.BosKoltukOgren() >= 1)
                {
                    salon.BiletSat(checkBox1.Checked);
                    richTextBox1.Text = " Kalan koltuk sayısı : " + salon.BosKoltukOgren();
                }
                else { richTextBox1.Text = ("Lütfen En Az 1 Adet Kolduk Sayısı Giriniz"); }
                if (salon.BosKoltukOgren() <= 1)
                {
                    richTextBox3.Text = "1 Adet Boş Koltuk Kaldı";
                }
                else
                {
                    richTextBox3.Text = "Boş koltuk sayısı " + salon.BosKoltukOgren();
                }
                richTextBox2.Text = "Şu anki bakiye " + "0" + " TL";
            }
            catch
            {
                label3.Text = "Salon Oluşturulamadı. Bilgileri kontrol edin.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (salon.BosKoltukOgren() >= 1)
            {
                salon.BiletSat(checkBox1.Checked);
                richTextBox1.Text = "Bilet satıldı. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
            }
            else
            {
                richTextBox1.Text = "Boş Koltuk Kalmadı.Bilet Satılamadı!!";
            }
            if (salon.BosKoltukOgren() <= 0)
            {
                richTextBox3.Text = "Boş Koltuk Kalmadı!!";
            }
            else
            {
                richTextBox3.Text = "Boş koltuk sayısı " + salon.BosKoltukOgren();
            }
            richTextBox2.Text = "Şu anki bakiye " + salon.BakiyeOgren() + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (salon.BosKoltukOgren() <= 1)
            {
            salon.BiletIptal(checkBox1.Checked);
            richTextBox1.Text = "Bilet iptal edildi. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
            }
            else { richTextBox1.Text = "Hiç Bilet Satılmadı,Bilet İptal Edilemedi"; }
            if (salon.BosKoltukOgren() <= 0)
            {
                richTextBox3.Text = "Boş Koltuk Kalmadı!!";
            }
            else
            {
                richTextBox3.Text = "Boş koltuk sayısı " + salon.BosKoltukOgren();
            }
            richTextBox2.Text = "Şu anki bakiye " + salon.BakiyeOgren() + " TL";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button6_Click(object sender, EventArgs e)
        {
            
            tamFiyat = Convert.ToDouble(textBox4.Text);
            indirimliFiyat = Convert.ToDouble(textBox5.Text);
        }
    }
}
