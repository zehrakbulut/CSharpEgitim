using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double

            //double number;
            //number=4.86;
            //Console.WriteLine(number);

            #endregion

            #region doubleDegiskenlerOrnek

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Elma birim fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("Portakal birim fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("Çilek birim fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("Patates birim fiyatı: " + potatoPrice + " ₺");
            //Console.WriteLine("Domates birim fiyatı: " + tomatoPrice + " ₺");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double totalApplePrice = appleGram * applePrice;
            //double totalOrangePrice = orangeGram * orangePrice;
            //double totalStrawberryPrice=strawberryGram * strawberryPrice;
            //double totalPotatoPrice=potatoGram * potatoPrice;
            //double totalTomatoPrice=tomatoGram * tomatoPrice;

            //double topTotal=totalApplePrice+totalOrangePrice+totalStrawberryPrice+totalPotatoPrice+totalTomatoPrice;

            //Console.WriteLine("Alınan ürün: Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + totalApplePrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + totalOrangePrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + totalStrawberryPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + " Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + totalPotatoPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + " Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + "  Toplam Tutar: " + totalTomatoPrice);

            //Console.WriteLine();
            //Console.WriteLine("Tompam Tutar: " + topTotal + " ₺");

            #endregion

            #region Char

            //char symbol;
            //symbol = 'Z';

            //Console.WriteLine(symbol);

            #endregion

            #region klavyedenVeriGirişleri(double)

            //Console.WriteLine("***** Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();
            //Console.Write("Soyadı: ");
            //passengerSurname=Console.ReadLine();
            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Merhaba " + passengerName + " " + passengerSurname + " hoşgeldiin :)");
            //Console.WriteLine("Lütfen girilen bilgileri kontrol ediniz: ");
            //Console.WriteLine("Kimlik numaranız: " + passengerIdentityNumber);
            //Console.WriteLine("Ad Soyadınız: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Gidilicek İlçe: " + passengerDistrict +"/"+ " Gidilicek Şehir: "+ passengerCity);
            //Console.WriteLine("Yaşınız: " + passengerAge);

            #endregion

            #region klavyedenTamSayiGirisleriVeDönüsümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse((Console.ReadLine()));

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse((Console.ReadLine()));

            //Console.Write("Lütfen aldığınız televisyon sayısını giriniz: ");
            //tvCount = int.Parse((Console.ReadLine()));

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("Toplam harcanan tutar: "+ totalPrice);
            #endregion

            #region klavyedenOndalikliSayiİslemleri

            double exam1, exam2, exam3, result;
            Console.Write("1.Sınav: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("2.Sınav: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("3.Sınav: ");
            exam3=double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine("Ortalama: "+result);
            #endregion
            Console.Read();
        }
    }
}
