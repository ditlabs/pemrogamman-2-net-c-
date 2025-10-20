using System;

using System;
using dit_Gudang_OOP_2.Models;

class Program
{
    static void Main()
    {

        // Langkah 3: Membuat object dengan constructor berparameter
        Barang b1 = new Barang("BRG001", "Karton", -120, "Kemasan");
        Barang b2 = new Barang("BRG002", "Bubble Wrap", 40, "Pelindung");

        b1.TampilkanInfo();
        Console.WriteLine($"Status: {b1.StatusStok()}");

        b2.TampilkanInfo();
        Console.WriteLine($"Status: {b2.StatusStok()}");

        // Langkah 5: Membuat object dengan constructor kosong
        Barang b3 = new Barang();
        b3.TampilkanInfo();
        Console.WriteLine($"Status: {b3.StatusStok()}");

        // Langkah 6: Mengisi object b3 lewat input user
        Console.WriteLine("\n=== Input Data Barang Baru ===");

        // Validasi Nama Barang dengan try-catch + loop
        while (true)
        {
            Console.Write("Masukkan Nama Barang: ");
            try
            {
                b3.NamaBarang = Console.ReadLine();
                break; // keluar loop kalau sukses
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Input tidak valid: {ex.Message}");
            }
        }

        Console.Write("Masukkan Kode Barang: ");
        b3.KodeBarang = Console.ReadLine();

        while (true)
        {
            Console.Write("Masukkan Jumlah Stok: ");
            if (int.TryParse(Console.ReadLine(), out int stok) && stok >= 0)
            {
                b3.JumlahStok = stok;
                break;
            }
            else
            {
                Console.WriteLine("Stok harus angka >= 0, coba lagi.");
            }
        }

        Console.Write("Masukkan Kategori: ");
        b3.Kategori = Console.ReadLine();

        Console.WriteLine("\nData Barang Baru:");
        b3.TampilkanInfo();
        Console.WriteLine($"Status: {b3.StatusStok()}");

        // Langkah 7: Menyimpan beberapa barang dalam array
        Barang[] daftarBarang = new Barang[3];
        daftarBarang[0] = b1;
        daftarBarang[1] = b2;
        daftarBarang[2] = b3;

        Console.WriteLine("\n=== Daftar Barang di Gudang ===");
        foreach (var barang in daftarBarang)
        {
            barang.TampilkanInfo();
            Console.WriteLine($"Status: {barang.StatusStok()}");
        }


    }
}
