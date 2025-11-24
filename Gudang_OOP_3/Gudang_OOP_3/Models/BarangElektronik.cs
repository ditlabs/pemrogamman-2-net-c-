using System;

namespace Gudang_OOP_3.Models
{
    // BarangElektronik mewarisi Barang (inheritance)
    public class BarangElektronik : Barang
    {
        // Properti tambahan khusus barang elektronik
        public int DayaListrik { get; set; } // dalam Watt

        // Constructor berparameter yang memanggil constructor base
        public BarangElektronik(string kode, string nama, int stok, string kategori, int daya)
            : base(kode, nama, stok, kategori) // panggil constructor Barang
        {
            DayaListrik = daya;
        }

        // Constructor default (optional)
        public BarangElektronik() : base()
        {
            DayaListrik = 0;
        }

        // Override method TampilkanInfo untuk menambah info DayaListrik
        public override void TampilkanInfo()
        {
            // Tampilkan info umum dari class Barang dulu
            base.TampilkanInfo();

            // Tambah informasi spesifik elektronik
            Console.WriteLine($"Daya Listrik : {DayaListrik} Watt");
        }
    }
}
