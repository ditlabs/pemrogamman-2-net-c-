using System;
using Gudang_OOP_3.Models;

class Program
{
    static void Main()
    {
        // Objek dari class parent (Barang)
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");

        // Objek dari class child (BarangElektronik) tapi disimpan dalam variabel bertipe Barang (polymorphism)
        Barang b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);

        // Objek child lain
        BarangElektronik e1 = new BarangElektronik("ELK002", "Printer Barcode", 5, "Elektronik", 300);

        Console.WriteLine("=== DEMO INHERITANCE & POLYMORPHISM ===\n");

        // Polymorphism: method yang dipanggil menyesuaikan jenis objek sebenarnya
        b1.TampilkanInfo();
        Console.WriteLine("--------------------");
        b2.TampilkanInfo();   
        Console.WriteLine("--------------------");
        e1.TampilkanInfo();
        Console.WriteLine("--------------------");

        // Array Barang berisi campuran Barang & BarangElektronik
        Console.WriteLine("\n=== DAFTAR BARANG DALAM ARRAY===");

        Barang[] daftarBarang = new Barang[]
        {
            new Barang("BRG002", "Box Kardus", 50, "Kemasan"),
            new BarangElektronik("ELK003", "CCTV Gudang", 12, "Elektronik", 60),
            new BarangElektronik("ELK004", "Lampu Sorot Gudang", 30, "Elektronik", 100)
        };

        foreach (Barang item in daftarBarang)
        {
            item.TampilkanInfo();  // kalau item = BarangElektronik → override yang jalan
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
