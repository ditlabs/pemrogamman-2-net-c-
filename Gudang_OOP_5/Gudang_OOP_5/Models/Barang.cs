using System;

namespace Gudang_OOP_5.Models
{
    public class Barang
    {
        // Auto-properties untuk data umum
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }

        // Field private untuk enkapsulasi stok
        private int jumlahStok;

        // Property dengan validasi (tidak boleh negatif)
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value >= 0)
                    jumlahStok = value;
            }
        }

        // Auto-property lain
        public string Kategori { get; set; }

        // Property hanya-baca (read-only) untuk status stok
        public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";

        // Constructor berparameter
        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;   // tetap melewati validasi
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

        // Method virtual, supaya bisa dioverride di class turunan
        public virtual void TampilkanInfo()
        {
            Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}, Status: {Status}");
        }
    }
}
