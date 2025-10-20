using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace dit_Gudang_OOP.Models
{
    public class Barang
    {
        public string KodeBarang;
        public string NamaBarang;
        public int JumlahStok;
        public string Kategori;

        // Constructor kosong (Langkah 5)
        public Barang()
        {
            KodeBarang = "UNKNOWN";
            NamaBarang = "Barang Baru";
            JumlahStok = 0;
            Kategori = "Umum";
        }

        // Constructor berparameter (Langkah 2–3)
        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;
            Kategori = kategori;
        }

        // Method untuk menampilkan info barang
        public void TampilkanInfo()
        {
            Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
        }

        // Method tambahan (Langkah 4)
        public string StatusStok()
        {
            return JumlahStok > 50 ? "Stok Aman" : "Perlu Reorder";
        }
    }
}

