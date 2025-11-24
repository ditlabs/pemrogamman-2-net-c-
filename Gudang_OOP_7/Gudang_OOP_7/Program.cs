using System;
using Gudang_OOP_7.Models;
using Gudang_OOP_7.Services;
using Gudang_OOP_7.Interfaces;
using Gudang_OOP_7.Factories;

namespace Gudang_OOP_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRAKTIKUM BAB 7: FACTORY & REFACTORING ===\n");

            // 1. Input barang menggunakan class khusus
            var input = new InputBarang();
            Barang barang1 = input.AmbilInput();

            // 2. Cetak barang menggunakan interface
            IBarangPrinter printer = new PencetakBarang();
            printer.Cetak(barang1);

            // 3. Contoh penggunaan Factory Pattern
            Console.WriteLine("\n=== FACTORY PATTERN ===");
            Barang barangAuto = BarangFactory.BuatBarang("Elektronik");
            printer.Cetak(barangAuto);

            Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}
