using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Final_ve_Harf_Notu_Hesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vize - Final ve Harf Notu Hesaplayıcı";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();                      

            Console.WriteLine("VİZE - FİNAL VE HARF NOTU HESAPLAYICI");
            Console.WriteLine("-------------------------------------");

            Console.Write("Adınız: ");
            Console.ReadLine();
           
            Console.Write("Soyadınız: ");
            Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            Console.Write("Vize Notunuz: ");
            double vizeNot = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notunuz: ");
            double finalNot = Convert.ToDouble(Console.ReadLine());
                    
            double ortalama = (vizeNot * 0.4) + (finalNot * 0.6);

            if (ortalama >= 85)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Notunuz: AA BAŞARILI");
            }
            else if (ortalama >= 70 && ortalama < 85)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Notunuz: BB BAŞARILI");
            }
            else if (ortalama >= 50 && ortalama < 69)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Notunuz: CC GEÇTİNİZ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;                
                Console.Clear();
                Console.WriteLine("Ortalamanız: " + ortalama);
                Console.WriteLine("Notunuz: FF KALDINIZ");
            }
            
            Console.ReadLine();            
        }
    }
}
