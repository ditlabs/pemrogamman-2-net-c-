using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace dit_Gudang_OOP_2.Models
{
    public class Barang
    {
        public string KodeBarang;
        public string Kategori { get; set; }

        private string namaBarang;

        public string NamaBarang
        {
            get => namaBarang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama barang tidak boleh kosong!");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Nama barang maksimal 15 karakter!");
                }
                else
                {
                    namaBarang = value;
                }
            }
        }

        private int jumlahStok;
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value >= 0) jumlahStok = value;
            }
        }
        public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";


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
            Console.WriteLine($"Stok: {JumlahStok}");
        }

        // Method tambahan (Langkah 4)
        public string StatusStok()
        {
            return JumlahStok > 50 ? "Stok Aman" : "Perlu Reorder";
        }
    }
}

