using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Console.WriteLine("Yazdırma")
            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;


            //Console.WriteLine("***** Restoran Menü Fiyatı *****");
            //Console.WriteLine("");
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hamburger : " + hamburgerPrice + "₺");
            //Console.WriteLine("Kola : " + cokePrice + "₺");
            //Console.WriteLine("Su : " + waterPrice + "₺");
            //Console.WriteLine("Kızartma : " + friesPrice + "₺");
            //Console.WriteLine("Pizza : " + pizzaPrice + "₺");
            //Console.WriteLine("Limonata : " + lemonadePrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine("********************************");
            //Console.WriteLine();

            //int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount,lemonadeCount;

            //hamburgerCount = 2;
            //cokeCount = 2;
            //waterCount = 2;
            //friesCount = 1;
            //pizzaCount=1;
            //lemonadeCount = 0;

            //int totalHamburger, totalCoke, totalWater, totalFrie, totalPizza, totalLemonade;

            //totalHamburger = hamburgerPrice * hamburgerCount;
            //totalCoke = cokePrice * cokeCount;
            //totalWater = waterPrice * waterCount;
            //totalFrie = friesPrice * friesCount;
            //totalPizza= pizzaPrice * pizzaCount;
            //totalLemonade= lemonadePrice * lemonadeCount;

            //int topTutar=totalHamburger+totalCoke+totalWater+totalFrie+totalPizza;

            //Console.WriteLine("Toplam harcanan tutar: "+topTutar+"₺");

            #endregion

            #region Alıştırma-1.video
            int canta = 1000;
            int kalemlik = 250;
            int suluk = 300;
            int kareliDefter = 80;
            int cizgiliDefter = 70;
            int resimDefteri = 100;
            int notDefteri = 50;
            int suluBoya = 280;
            int kalemBoya = 200;
            int kalem = 60;
            int silgi = 30;

            int cantaSayisi, kalemlikSayisi, sulukSayisi, kareliDefterSayisi, cizgiliDefterSayisi,
                resimDefterSayisi, notDefterSayisi, suluBoyaSayisi, kalemBoyaSayisi, kalemSayisi, silgiSayisi;

            cantaSayisi = 1;
            kalemlikSayisi = 1;
            sulukSayisi = 1;
            kareliDefterSayisi = 4;
            cizgiliDefterSayisi = 3;
            resimDefterSayisi = 2;
            notDefterSayisi = 1;
            suluBoyaSayisi = 1;
            kalemBoyaSayisi = 1;
            kalemSayisi = 6;
            silgiSayisi = 3;

            int totalCanta, totalKalemlik, totalSuluk, totalKareliDefter, totalCizgiliDefter, totalResimDefter, totalNotDefter, totalSuluBoya,
                totalKalemBoya, totalKalem, totalSilgi;

            totalCanta = canta * cantaSayisi;
            totalKalemlik = kalem * kalemlikSayisi;
            totalSuluk = suluk * sulukSayisi;
            totalKareliDefter = kareliDefter * kareliDefterSayisi;
            totalCizgiliDefter = cizgiliDefter * cizgiliDefterSayisi;
            totalResimDefter = resimDefteri * resimDefterSayisi;
            totalNotDefter = notDefteri * notDefterSayisi;
            totalSuluBoya = suluBoya * suluBoyaSayisi;
            totalKalemBoya = kalemBoya * kalemBoyaSayisi;
            totalKalem = kalem * kalemSayisi;
            totalSilgi = silgi * silgiSayisi;

            int topTotal = totalCanta + totalKalemlik + totalSuluk + totalKareliDefter + totalCizgiliDefter + totalResimDefter + totalNotDefter +
                 totalSuluBoya + totalKalemBoya + totalKalem + totalSilgi;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("***** OKUL ALIŞVERİŞ LİSTESİ *****");
            Console.WriteLine();
            Console.WriteLine("Çanta: " + canta + " ₺");
            Console.WriteLine("Kalemlik: " + kalemlik + " ₺");
            Console.WriteLine("Suluk: " + suluk + " ₺");
            Console.WriteLine("Kareli Defter: " + kareliDefter + " ₺");
            Console.WriteLine("Çizgili Defter: " + cizgiliDefter + " ₺");
            Console.WriteLine("Resim Defteri: " + resimDefteri + " ₺");
            Console.WriteLine("Not Defteri: " + notDefteri + " ₺");
            Console.WriteLine("Sulu Boya: " + suluBoya + " ₺");
            Console.WriteLine("Kalem Boya: " + kalemBoya + " ₺");
            Console.WriteLine("Kalem: " + kalem + " ₺");
            Console.WriteLine("Silgi: " + silgi + " ₺");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: " + topTotal + " ₺");
            Console.WriteLine("***** ***** ***** *****");

            #endregion
            Console.Read();
        }
    }
}
