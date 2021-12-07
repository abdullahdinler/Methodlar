using System;

namespace Methodlar
{
    class Program
    {
        private const string V = "44 Kg";

        static void Main()
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 4.99;
            urun1.Aciklama = "Amasya elmasi";
            urun1.StokAdedi = "1 Kg";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Portakal";
            urun2.Fiyat = 3.99;
            urun2.Aciklama = "Hatay organik portakal";
            urun2.StokAdedi = "66 Kg";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Karpuz";
            urun3.Fiyat = 5.86;
            urun3.Aciklama = "Diyarbakir Karpuzu";
            urun3.StokAdedi = "34 Kg";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id + " " + urun.Adi + ": " + urun.Fiyat + " " + urun.Aciklama + " " + urun.StokAdedi); 
                
            }

            Console.WriteLine("   ");
            Console.WriteLine("-----------Metotlar------------");

            UrunSpeti urunler1 = new UrunSpeti ();
            urunler1.Ekle(urun1);
            urunler1.Ekle(urun2);
            urunler1.Ekle(urun3);





        }
    }
}
