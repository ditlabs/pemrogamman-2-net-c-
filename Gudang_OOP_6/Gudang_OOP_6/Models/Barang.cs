using System;

namespace Gudang_OOP_6.Models
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

        // ⬇⬇⬇ kuncinya di sini: pakai virtual
        public virtual void TampilkanInfo()
        {
            Console.WriteLine(
                $"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}"
            );
        }
    }
}
