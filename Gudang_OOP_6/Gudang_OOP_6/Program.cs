using System;
using System.Collections.Generic;
using System.IO;
using Gudang_OOP_6.Models;

namespace Gudang_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRAKTIKUM BAB 6: EXCEPTION HANDLING & FILE I/O ===\n");

            // List untuk menyimpan barang-barang
            List<Barang> daftarBarang = new List<Barang>();

            // Input dengan logika Try-Catch
            Console.Write("Masukkan kode barang: ");
            string kode = Console.ReadLine() ?? "";

            Console.Write("Masukkan nama barang: ");
            string nama = Console.ReadLine() ?? "";

            int stok = 0;

            try
            {
                Console.Write("Masukkan jumlah stok: ");
                stok = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Input stok harus angka!");
                Console.WriteLine("Stok otomatis diset 0.");
                stok = 0;
            }

            Console.Write("Masukkan kategori: ");
            string kategori = Console.ReadLine() ?? "";

            // ====== LANGKAH 2: Gunakan Custom Exception ======
            try
            {
                Barang b = new Barang(kode, nama, stok, kategori);
                daftarBarang.Add(b);

                Console.WriteLine("\nBarang berhasil ditambahkan:");
                b.TampilkanInfo();
            }
            catch (StokNegatifException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            // Tambahkan beberapa barang dummy seperti di modul
            daftarBarang.Add(new Barang("B001", "Laptop", 30, "Elektronik"));
            daftarBarang.Add(new Barang("B002", "Smartphone", 60, "Elektronik"));
            daftarBarang.Add(new Barang("B003", "Kulkas", 20, "Elektronik"));
            daftarBarang.Add(new Barang("B004", "Televisi", 10, "Elektronik"));
            daftarBarang.Add(new Barang("B005", "Mesin Cuci", 5, "Elektronik"));

            // ====== LANGKAH 3: Simpan Daftar Barang ke File ======
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data_barang.txt");

            // Tulis header
            File.WriteAllText(path, "Kode\tNama\tStok\tKategori\n");

            // Append data tiap barang
            foreach (var item in daftarBarang)
            {
                File.AppendAllText(
                    path,
                    $"{item.KodeBarang}\t{item.NamaBarang}\t{item.JumlahStok}\t{item.Kategori}\n"
                );
            }

            Console.WriteLine($"\n>> Data berhasil disimpan ke file: {path}");

            // Read data Output dari file
            Console.WriteLine("\n=== Isi File data_barang.txt ===");

            if (File.Exists(path))
            {
                string[] isi = File.ReadAllLines(path);

                foreach (string baris in isi)
                {
                    Console.WriteLine(baris);
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan.");
            }

            Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}
