using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-else

            //string password;

            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "123456")
            //{
            //    Console.WriteLine("Girilen şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Şifre Yanlış");
            //}





            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country== "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");  
            //}




            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //Console.Read();
            #endregion

            #region
            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if(average>=0 & average < 50)
            //{
            //    result = "Çok çalışman gerek dostum";
            //}
            //else if(average>=50 & average < 70)
            //{
            //    result = "Normal, ama daha başarılı olabilirsiin";
            //}
            //else if(average>=70 & average < 100)
            //{
            //    result = "Harıkasın";
            //}
            //else
            //{
            //    result = "Hata";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana" |  city=="ankara" | city=="bursa" | city == "mersin")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");    
            //}



            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username=Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz");
            //}
            //Console.Read();
            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile if else
            //char team;
            //Console.Write("Lütfen takımınızın ilk karakteriniz giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //else if(team=='f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //else if(team=='b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("girilen takım bilinemedi");
            //}

            //Console.Read();

            #endregion

            #region Örnek Proje Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- İçecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            string menuItem;
            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("----------Ana Yemekler----------");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Fasulye Pilav");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- Patlıcan Musakka");
                Console.WriteLine();
                Console.WriteLine("----------Ana Yemekler----------");
                Console.WriteLine();
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Ezogelin Çorbası");
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza");
                Console.WriteLine("2- Margaritha");
                Console.WriteLine("2- Tavuklu Pizza");
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
                Console.WriteLine("1- Kola");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("2- Su");
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
                Console.WriteLine("1- Triliçe");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("2- Sütlaç");
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
            }


            #endregion

            #region switch case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs");break;
            //    case 6: Console.Write("Haziran");break;
            //    case 7: Console.Write("Temmuz");break;
            //    case 8: Console.Write("Ağustos");break;
            //    case 9: Console.Write("Eylül");break;
            //    case 10: Console.Write("Ekim");break;
            //    case 11: Console.Write("Kasım");break;
            //    case 12: Console.Write("Aralık");break;
            //    default: Console.Write("hatalı veri girişi");break;
            //}

            #endregion

            #region switch-case HesapMakinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemleri giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam= " + result);
            //        break;

            //    case '-':
            //        result= number1 - number2;
            //        Console.WriteLine("Fark= " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım= "+result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm= " + result);
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
