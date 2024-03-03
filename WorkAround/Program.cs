using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            // Diziler - Arrays

            string ogrenci1 = "Simge";
            string ogrenci2 = "Pınar";
            string ogrenci3 = "Tuana";

            // bunları tek tek WriteLine yazdırmamak için;

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Simge";
            ogrenciler[1] = "Pınar";
            ogrenciler[2] = "Tuana";
            //yeni öğrenci eklemek istiyorsak;
            ogrenciler = new string[4];
            ogrenciler[3] = "Gülay";
            //fakat bu şekilde yazdığımızda yalnızca bize 3.indexteki elemanı yazdırır, diğer elemanlar boş gelir.

            // örneğin liste almak istediğimizde de yine WriteLine yerine döngülere başvurabiliriz;

            for(int i = 0; i < ogrenciler.Length; i++) 
            {
            
            
            }

            // for(int i) - int yanındaki i: index yani sayaç tanımlamış oluruz.
            // i < ögrenciler.Length : şart
            // i++ : sayacın artış değeri

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach(string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            
            }

            // foreach döngüsüyle ; dizi formatındaki yapılara dönüyoruz.
            // bu döngüde verdiğimiz "sehir" bizim verdiğimiz bir takma isim,
            // sehirlerin tekil hali, genelde de tekil haller kullanılıyor.

            // Yukardakiler yerine aşağıdaki yazım şekli daha günceldir.
            List<string> yeniSehirler= new List<string> {"Ankara1", "İstanbul1", "İzmir1"};
            yeniSehirler.Add("Muğla");
            // dediğimizde artık sorunsuzca 4. elemanı da eklemiş oluyoruz.
            foreach(var sehir in yeniSehirler) 
            { 
                Console.WriteLine(sehir); 
            
            }

            Console.ReadLine();
        
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        
        }

        static int Topla(int sayi1, int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc);
            return sonuc;
    
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool GirisYapilmisMi = false;

            string ad = "Simge";
            string soyad = "Gök";
            int DogumYili = 2003;
            long TcNo = 12345678910;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get; set;}
        public long TcNo { get; set;}


    }




}



