﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for(int i=0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write(" *");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("* * * * * * * * * *");                
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region TersDik Üçgen

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j >= i; j--)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  dik üçgen ve ters üçgen bir arada

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            #endregion

            #region baklava dilimi

            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=4; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {   
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}

            //for(int i=4; i>=1; i--)
            //{
            //    for(int j = 4; j > 0; j-- )
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            #endregion

            #region piramit
            //for(int i=1; i<=5; i++)
            //{
            //boşluklar
            //    for (int j=5-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //yıldızlar
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters piramit

            //for(int i=5; i>0; i--)
            //{
            //    //boşluklar
            //    for(int j=5-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 

            //for(int i=1; i<=10; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //for(int i=1; i<=10; i++)
            //{
            //    for(int j=10; j>=i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= 5; i++)
            //{
            //        for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //        for (int k = 0; k <=  i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=0;i<10; i++)
            //{
            //    for(int j=0;j<10; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();

        }
    }
}
