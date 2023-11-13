using System;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Ogrenci
    {
        private static int ogrenciSayisi;

        static Ogrenci()
        {
            ogrenciSayisi = 0;
        }

        private string ad;
        private string soyad;
        private int sinif;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad { get => soyad; set => soyad = value; }
        public string OgrenciNo { get => OgrenciNo; set => OgrenciNo = value; }
        public int Sinif { get => sinif; set => sinif = value; }

        public Ogrenci(string ad, string soyad, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            Sinif = sinif;
            ogrenciSayisi++;
             
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
