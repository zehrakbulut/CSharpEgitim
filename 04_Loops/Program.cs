using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("seni seviyorum");
            //}



            //int i;
            //for(i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //for (int i = 3; i <= 50; i += 3){
            //    Console.WriteLine(i);
            //}



            //Console.Write("Lütfen ekrana yazılmasını istediğiniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i=1; i<=finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region for Karar Yapıları

            //for (int i=1; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}




            //int totalValue = 0;
            //for(int i=1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);




            //int sayi = 0;
            //for(int i=0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sayi += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---");
            //Console.WriteLine(sayi);





            //int count = 0;
            //for(int i = 1; i <= 88; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            //1-2-4-8-16 ...

            //int bacterium = 1;
            //for(int i=1; i<=24 ; i++)
            //{
            //    bacterium *=2;
            //    Console.WriteLine(i+".Saat Sonunda: "+bacterium);
            //}

            #endregion


            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i+". merhabalar");
            //    i++;
            //}



            //int i=1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion


            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10; //birler basamağı bulundu
            tens = (number % 100) / 10;
            hundreds = number / 100;  //yüzler basamağı bulundu

            Console.WriteLine("Birler basamağı: "+ones);
            Console.WriteLine("Onlar basamağı: "+tens);
            Console.WriteLine("Yüzler basamağı: "+hundreds);

            sum=ones+tens+hundreds;
            Console.WriteLine("Rakamları toplamı: "+sum);





            #endregion

            Console.Read();
        }
    }
}
