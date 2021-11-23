using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOrnekOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matematik adında bir class oluşturun
            //Bir menü hazırlayın metod ile menüde:
            //"****Menü*****"
            //"1-Toplama"
            //"2-Çıkarma"
            //"3-Çarpma"
            //"4-Bölme"
            //"Lütfen bir değer seçiniz:"
            //Metod ile 4 işlemleri ekrana yazdır
            //public static void main içinde matematik sınıfının bir instance ' ını al
            //Kullanıcıdan iki değer iste ve matematik sınıfındaki 4 işlem metodunu kullanarak sonuçları ekrana yazdır
            //Yeniden işlem yapmak istiyor musunuz?(e/h) sor


            Matematik islem = new Matematik();
            Console.WriteLine("Hoşgeldiniz\n");
            char decision;
            int secim = 0;
            int no1 = 0, no2 = 0;




            do
            {
                Console.WriteLine("****Menü****");
                Console.WriteLine("1 - Toplama\n2 - Çıkarma\n3 - Çarpma\n4 - Bölme");
                secim = int.Parse(Console.ReadLine());
                Console.WriteLine("İşlem yapacağınız 1. sayıyı girin :");
                no1 = int.Parse(Console.ReadLine());
                Console.WriteLine("İşlem yapacağınız 2. sayıyı girin :");
                no2 = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        islem.Toplama(no1, no2);
                        break;
                    case 2:
                        islem.Cikarma(no1, no2);
                        break;
                    case 3:
                        islem.Carpma(no1, no2);
                        break;
                    case 4:
                        islem.Bolme(no1, no2);
                        break;
                    default:
                        break;
                }


                Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
                decision = char.Parse(Console.ReadLine());
            } while (char.ToLower(decision) == 'e');
        }
    }

    class Matematik
    {
        public void Toplama(int no1, int no2)
        {
            Console.WriteLine(no1 + no2);
        }

        public void Cikarma(int no1, int no2)
        {
            Console.WriteLine(no1 - no2);
        }
        public void Carpma(int no1, int no2)
        {
            Console.WriteLine(no1 * no2);
        }
        public void Bolme(double no1, double no2)
        {
            Console.WriteLine(no1 / no2);
        }
    }
}
