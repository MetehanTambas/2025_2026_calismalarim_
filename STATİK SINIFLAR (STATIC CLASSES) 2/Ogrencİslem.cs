using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATİK_SINIFLAR__STATIC_CLASSES__2
{
    public class Ogrencİslem
    {
        public List<ogrenci> ogrenciler;
        public static int OgrenciSayisi { get; set; }
        static Ogrencİslem()
        {
            OgrenciSayisi = 0;
            MessageBox.Show("Statik Yapıcı Çalıştı");
        }

        public Ogrencİslem()
        {
            ogrenciler=new List<ogrenci>();
            MessageBox.Show("Yapıcı Çalıştı");
        }

        public void OgrenciSil(int numara)
        {
            var ogr = ogrenciler.FirstOrDefault(x => x.numara == numara);
            if (ogr != null)
            {
                ogrenciler.Remove(ogr);
                OgrenciSayisi--;
                MessageBox.Show("Öğrenci Silindi");
            }
        }

        public void OgrenciEkle(ogrenci ogr)
        {
            ogrenciler.Add(ogr);
            OgrenciSayisi++;
            MessageBox.Show("Öğrenci eklendi.");
        }
    }
}
