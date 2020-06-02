using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geriye Değer Döndüren Metot
            //Bir metot geriye değer döndürecek ise void yerine geriye dönüş tipini belirtmeliyiz. Geriye dönüş tipimiz C Sharp tarafında tanımlı olan veri tipleri (string, int, bool, double vs.) veya bizim tanımladığımız nesne tipleri olabilir. Kendi nesnelerimizi tanımlamayı ilerde inceleyeceğiz(OOP). Geriye dönüş tipi belirtildikten sonra geriye değer döndürmek için return komutu kullanılır. Return anahtar kelimesi metodumuzun yapacağı işlem sonucunda geriye döndüreceği değeri belirler. 

            //string Bilgi()
            //{
            //    string ad;
            //    string soyad;
            //    Console.WriteLine("Lütfen adınızı yazın");
            //    ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen soyadınızı yazın");
            //    soyad = Console.ReadLine();

            //    return $"adınız {ad} soyadınız: {soyad}";
            //}

            ////Metot Kullanım
            //string kullaniciBilgisi = Bilgi();

            //Console.WriteLine(kullaniciBilgisi);
            //Console.Read();

            //Dışarıdan alınan iki sayının toplamını veren metot.

            int Topla(int s1, int s2)
            {
                int toplam = s1 + s2;
                return toplam;
            }

            int sonuc = Topla(5, 3);
            Console.WriteLine("Toplam sonuç= " + sonuc);
            Console.Read();
        }
    }
}
