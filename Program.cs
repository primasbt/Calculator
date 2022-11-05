using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Masukkan Angka, dan tekan Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka berikutnya, dan tekan Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Silahkan pilih opsi dan list berikut: ");

            Console.WriteLine("\ta - Tambah");
            Console.WriteLine("\ts - Pengurangan");
            Console.WriteLine("\tm - Perkalian");
            Console.WriteLine("\td - Pembagian");
            Console.Write("Pilihan Anda? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Hasil : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Hasil : {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Hasil : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Hasil : {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Tekan tombol apapun untuk menutup aplikasi...");
            Console.ReadKey();


        }
    }
}
