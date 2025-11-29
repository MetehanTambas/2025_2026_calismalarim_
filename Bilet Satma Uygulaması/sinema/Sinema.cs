using System;
using System.Windows.Forms;

namespace sinema
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        double tamBilet;
        double indirimliBilet;

        // Kurucu Metot
        public Sinema(string salonn, int koltukSayisi, double tam, double indirimli)
        {
            toplamKoltukSayisi = koltukSayisi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;

            tamBilet = tam;
            indirimliBilet = indirimli;
        }

        // Bilet satılınca
        public void BiletSat(bool indirimliMi)
        {
            bosKoltukSayisi--;

            if (indirimliMi)
                bakiye += indirimliBilet;
            else
                bakiye += tamBilet;
        }

        // Bilet iptal edilince
        public void BiletIptal(bool indirimliMi)
        {
            bosKoltukSayisi++;

            if (indirimliMi)
                bakiye -= indirimliBilet;
            else
                bakiye -= tamBilet;
        }

        // Kalan boş koltuk sayısı
        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }

        // Mevcut bakiye
        public double BakiyeOgren()
        {
            return bakiye;
        }

        // yıkıcı metot
        ~Sinema()
        {
            MessageBox.Show("Program Sonlandırıldı");
        }
    }
}
