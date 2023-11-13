using System;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calisan calisan = new Calisan("ayşe", "kara", 1236);
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;

        public Calisan(string ad, string soyad, int no)
        {
            this.Ad= ad;
            this.Soyad= soyad;
            this.No = no;
        }
    }
}
