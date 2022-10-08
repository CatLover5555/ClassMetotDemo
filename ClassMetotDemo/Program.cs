using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1=new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "catlover";
            musteri1.SoyIsim = "kedioğlu";
            musteri1.Yas = 2;





            MusteriManager musteriManager=new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriList(musteri1);
            musteriManager.MusteriSil(musteri1);


        }
    }
}
