using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Console Kalkulator";
            Console.WriteLine("Aplikasi Console Kalkulator");
            int a = 0;
            int b = 0;


            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");


            int i;

            Console.Write("input pilihan (1-4): ");
            i = int.Parse(Console.ReadLine());



            switch (i)
            {
                case 1:
                    Console.Write("Masukkan angka a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan angka b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + penjumlahan(a, b));
                    Console.WriteLine("Tekan apa saja untuk untuk keluar");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Masukkan angka a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan angka b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
                    Console.WriteLine("Tekan apa saja untuk untuk keluar");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Masukkan angka a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan angka b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan " + a + " * " + b + " = " + perkalian(a, b));
                    Console.WriteLine("Tekan apa saja untuk untuk keluar");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("Masukkan angka a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan angka b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan " + a + " / " + b + " = " + pembagian(a, b));
                    Console.WriteLine("Tekan apa saja untuk untuk keluar");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Input tidak tersedia");
                    Console.WriteLine("Tekan apa saja untuk untuk keluar");
                    Console.ReadKey();
                    break;

            }
        }

        static int penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
