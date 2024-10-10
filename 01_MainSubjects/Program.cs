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

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine("");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hamburger : " + hamburgerPrice + "₺");
            Console.WriteLine("Kola : " + cokePrice + "₺");
            Console.WriteLine("Su : " + waterPrice + "₺");
            Console.WriteLine("Kızartma : " + friesPrice + "₺");
            Console.WriteLine("Pizza : " + pizzaPrice + "₺");
            Console.WriteLine("Limonata : " + lemonadePrice + "₺");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount,lemonadeCount;

            hamburgerCount = 2;
            cokeCount = 2;
            waterCount = 2;
            friesCount = 1;
            pizzaCount=1;
            lemonadeCount = 0;

            int totalHamburger, totalCoke, totalWater, totalFrie, totalPizza, totalLemonade;

            totalHamburger = hamburgerPrice * hamburgerCount;
            totalCoke = cokePrice * cokeCount;
            totalWater = waterPrice * waterCount;
            totalFrie = friesPrice * friesCount;
            totalPizza= pizzaPrice * pizzaCount;
            totalLemonade= lemonadePrice * lemonadeCount;

            int topTutar=totalHamburger+totalCoke+totalWater+totalFrie+totalPizza;

            Console.WriteLine("Toplam harcanan tutar: "+topTutar+"₺");

            Console.Read();
        }
    }
}
