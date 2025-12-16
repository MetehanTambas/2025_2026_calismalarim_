using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATİK_SINIFLAR__STATIC_CLASSES__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrencİslem oi = new Ogrencİslem();
            listBox1.Items.Add("1) ==========================");
            oi.OgrenciEkle(new ogrenci
            {
                numara = 100,
                adsoyad = "Nihal Öz"
            });
            listBox1.Items.Add("Öğrenci sayısı: " + Ogrencİslem.OgrenciSayisi);
            listBox1.Items.Add("2) ==========================");
            oi.OgrenciEkle(new ogrenci
            {
                numara = 200,
                adsoyad = "İbrahim Yurt"
            });
            listBox1.Items.Add("Öğrenci sayısı: " + Ogrencİslem.OgrenciSayisi);
            listBox1.Items.Add("3) ==========================");
            oi.OgrenciSil(100);
            listBox1.Items.Add("Öğrenci sayısı: " + Ogrencİslem.OgrenciSayisi);
        }
    }
}
