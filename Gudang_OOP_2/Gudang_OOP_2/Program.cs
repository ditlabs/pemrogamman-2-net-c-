using System;
using Gudang_OOP_2.Models;

class Program
{
    static void Main()
    {
        // Object dengan constructor berparameter
        Barang b1 = new Barang("BRG001", "Karton", 120, "Kemasan");
        Barang b2 = new Barang("BRG002", "Bubble Wrap", 40, "Pelindung");

        // Object default
        Barang b3 = new Barang();

        Console.Write("Masukkan Nama Barang: ");
        b3.NamaBarang = Console.ReadLine() ?? "";

        Console.Write("Masukkan Kode Barang: ");
        b3.KodeBarang = Console.ReadLine() ?? "";

        Console.Write("Masukkan Jumlah Stok: ");
        string? inputStok = Console.ReadLine();
        int stok;
        if (!int.TryParse(inputStok, out stok))
        {
            stok = 0;
        }
        b3.JumlahStok = stok;

        Console.Write("Masukkan Kategori: ");
        b3.Kategori = Console.ReadLine() ?? "";

        Console.WriteLine("\n=== Data Barang Inputan User ===");
        b3.TampilkanInfo();
        Console.WriteLine($"Status: {b3.StatusStok()}");

        Console.WriteLine("\n=== Data Barang Default ===");
        b1.TampilkanInfo();
        b2.TampilkanInfo();
        Console.WriteLine($"Status: {b1.StatusStok()}");
        Console.WriteLine($"Status: {b2.StatusStok()}");

        Console.WriteLine("\n=== DATA SEMUA BARANG DALAM ARRAY ===");

        Barang[] daftarBarang = new Barang[3];
        daftarBarang[0] = b1;
        daftarBarang[1] = b2;
        daftarBarang[2] = b3;

        foreach (var barang in daftarBarang)
        {
            barang.TampilkanInfo();
            Console.WriteLine($"Status: {barang.StatusStok()}");
            Console.WriteLine("-------------------");
        }

        Console.WriteLine("\nProgram selesai.");
        Console.ReadLine();
    }
}
