using System;
using System.Collections.Generic;
using Gudang_OOP_5.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== PRAKTIKUM BAB 5: COLLECTION & GENERIC ===\n");

        // Membuat List untuk menyimpan banyak objek Barang
        List<Barang> daftarBarang = new List<Barang>();

        // Mengisi list dengan beberapa data barang
        daftarBarang.Add(new Barang("BRG001", "Karton", 100, "Kemasan"));
        daftarBarang.Add(new Barang("BRG002", "Peti Kayu", 50, "Penyimpanan"));
        daftarBarang.Add(new Barang("BRG003", "Bubble Wrap", 30, "Pelindung"));
        daftarBarang.Add(new Barang("BRG004", "Pallet Plastik", 70, "Penyimpanan"));

        // Menampilkan semua barang dari List
        Console.WriteLine(">> Daftar semua barang (List<Barang>):");
        foreach (var barang in daftarBarang)
        {
            barang.TampilkanInfo();
        }

        // Mencari barang menggunakan List.Find() dengan lambda predicate
        Console.WriteLine("\n>> Cari barang dengan KodeBarang == \"BRG002\" menggunakan List.Find():");
        Barang? hasilKode = daftarBarang.Find(b => b.KodeBarang == "BRG002");
        if (hasilKode != null)
        {
            Console.WriteLine("Ditemukan:");
            hasilKode.TampilkanInfo();
        }
        else
        {
            Console.WriteLine("Barang dengan kode BRG002 tidak ditemukan.");
        }

        // Menggunakan generic method untuk mencari barang berdasarkan kategori
        Console.WriteLine("\n>> Cari barang dengan Kategori == \"Penyimpanan\" menggunakan Generic Method:");
        Barang? hasilKategori = CariData(daftarBarang, b => b.Kategori == "Penyimpanan");
        if (hasilKategori != null)
        {
            Console.WriteLine("Ditemukan:");
            hasilKategori.TampilkanInfo();
        }
        else
        {
            Console.WriteLine("Tidak ada barang dengan kategori Penyimpanan.");
        }

        // Membuat Dictionary untuk akses cepat berdasarkan kode barang
        Console.WriteLine("\n>> Bangun indeks barang berdasarkan KodeBarang (Dictionary<string, Barang>):");

        Dictionary<string, Barang> indeksBarang = new Dictionary<string, Barang>();

        // Memindahkan seluruh data list ke Dictionary
        foreach (var barang in daftarBarang)
        {
            indeksBarang[barang.KodeBarang] = barang;
        }

        // Mencari barang di Dictionary berdasarkan input user
        Console.WriteLine("Masukkan kode barang yang ingin dicari (misal: BRG003): ");
        string? kodeCari = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(kodeCari) && indeksBarang.ContainsKey(kodeCari))
        {
            Console.WriteLine($"Barang dengan kode {kodeCari} ditemukan di Dictionary:");
            indeksBarang[kodeCari].TampilkanInfo();
        }
        else
        {
            Console.WriteLine("Kode barang tidak ditemukan di Dictionary.");
        }

        Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar...");
        Console.ReadLine();
    }

    // Generic method untuk mencari data dalam List berdasarkan predicate tertentu
    public static T? CariData<T>(List<T> list, Predicate<T> predicate)
    {
        return list.Find(predicate);
    }
}
