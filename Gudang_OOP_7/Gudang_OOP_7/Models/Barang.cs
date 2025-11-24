using System;
using Gudang_OOP_7;

namespace Gudang_OOP_7.Models
{
    public class Barang
    {
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }

        private int jumlahStok;
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value < 0)
                    throw new StokNegatifException("Jumlah stok tidak boleh negatif.");

                jumlahStok = value;
            }
        }

        public string Kategori { get; set; }

        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;
            Kategori = kategori;
        }

        // Dibuat virtual supaya boleh dioverride di class turunan
        public virtual void TampilkanInfo()
        {
            Console.WriteLine("=== INFORMASI BARANG (BASE) ===");
            Console.WriteLine($"Kode     : {KodeBarang}");
            Console.WriteLine($"Nama     : {NamaBarang}");
            Console.WriteLine($"Stok     : {JumlahStok}");
            Console.WriteLine($"Kategori : {Kategori}");
            Console.WriteLine("===============================");
        }
    }
}
