using System;

namespace Gudang_OOP_2.Models
{
    public class Barang
    {
        // Auto-property
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }

        // Private field untuk enkapsulasi
        private int jumlahStok;

        // Property dengan validasi
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value >= 0)
                    jumlahStok = value;
            }
        }

        // Auto-property
        public string Kategori { get; set; }

        // Constructor berparameter (PERBAIKAN)
        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;   // otomatis tervalidasi
            Kategori = kategori;
        }

        // Constructor tanpa parameter (default)
        public Barang()
        {
            KodeBarang = "UNKNOWN";
            NamaBarang = "Barang Baru";
            JumlahStok = 0;
            Kategori = "Umum";
        }

        // Method untuk menampilkan data
        public void TampilkanInfo()
        {
            Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
        }

        // Method status stok
        public string StatusStok()
        {
            return JumlahStok > 50 ? "Stok Aman" : "Perlu Reorder";
        }
    }
}
