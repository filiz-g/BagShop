using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagShop
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kullanıcının sisteme giriş yapıp yapmadığı kontrol edilir.

            bool sistemeGirisYapmisMi=true;
            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Giriş Yap Butonu");

            } else  {

                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            //Giriş yaptıktan sonra kullanıcıya gösterilecek ekran

            string Entrance="Hoş Geldiniz";
            string KategoriEtiketi="Kategori";
            Console.WriteLine(Entrance);
            Console.WriteLine(KategoriEtiketi);

            //Çanta nesnesinin özelliklerini sınıf oluşturarak kullanıcıya gösterildi. 

            Bag bag1=new Bag();
            bag1.Adi="Omuz Çantası";
            bag1.Colour = "Beyaz";
            bag1.Fiyati=100;
            

            Bag bag2=new Bag();
            bag2.Adi="Sırt Çantası";
            bag2.Colour="Siyah";
            bag2.Fiyati=150;
            

            Bag bag3=new Bag();
            bag3.Adi="Cüzdan";
            bag3.Colour="Mavi";
            bag3.Fiyati=50;
            

            Bag[] bags=new Bag[]
            {bag1,bag2,bag3};

            foreach (Bag bag in bags)
	        {
		        Console.WriteLine(bag.Adi);
                Console.WriteLine(bag.Colour);
                Console.WriteLine(bag.Fiyati);
                Console.WriteLine("**********");

	        }
                Console.ReadLine();
        }

        class Bag
        {
            public string Adi { get; set; }
            public string Colour { get; set; }
            public int Fiyati { get; set; }
        }
    }
}
