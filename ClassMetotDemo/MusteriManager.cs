using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim+" "+musteri.SoyIsim+" Müşteri eklendi.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Isim + " Müşteri silindi.");
        }

        public void MusteriList(Musteri musteri)
        {
            Console.WriteLine("Müşteri : "+musteri.Id + " " + musteri.Isim + " " + musteri.SoyIsim + " " + musteri.Yas);
        }
    }
}
