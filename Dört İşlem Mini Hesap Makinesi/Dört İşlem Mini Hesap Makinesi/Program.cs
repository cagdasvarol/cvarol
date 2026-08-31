using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dört_İşlem_Mini_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dört İşlem Mini Hesap Makinesi";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("DÖRT İŞLEM MİNİ HESAP MAKİNESİ");
            Console.WriteLine("-------------------------------------");

            Console.Write("1. Sayı: ");
            double sayi1 = Convert.ToDouble (Console.ReadLine());

            Console.Write("2. Sayı: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            Console.Write("Toplama: (+)\nÇıkartma: (-)\nÇarpma: (*)\nBölme: (/)\n\nLütfen yapacağınız işlemi klavye tuşu ile seçiniz:");

            ConsoleKey keySecim = Console.ReadKey().Key;

            if (sayi1 == 0)
            {
                Console.Clear();
                Console.WriteLine($"Bölme Sonucu: {sayi1 / sayi2}");
            }

            switch (keySecim)
            {
                case ConsoleKey.Add:
                     Console.Clear();
                     Console.WriteLine($"Toplama Sonucu: {sayi1 + sayi2}");
                     break;

                case ConsoleKey.Subtract:
                     Console.Clear();
                     Console.WriteLine($"Çıkarma Sonucu: {sayi1 - sayi2}");
                     break;

                case ConsoleKey.Multiply:
                     Console.Clear();
                     Console.WriteLine($"Çarpma Sonucu: {sayi1 * sayi2}");
                     break;

                case ConsoleKey.Divide:
                     Console.Clear();
                        if (sayi2 == 0)
                        {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("! ! ! BİR SAYI 0'a BÖLÜNEMEZ ! ! !");                        
                    }
                        else
                     Console.WriteLine($"Bölme Sonucu: {sayi1 / sayi2}");
                     break;
            }




            Console.ReadKey();
        }
    }
}
