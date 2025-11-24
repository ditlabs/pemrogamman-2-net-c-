using System;

namespace Gudang_OOP_7.Models
{
    public class BarangElektronik : Barang
    {
        public int DayaListrik { get; set; }

        public BarangElektronik(string kode, string nama, int stok, string kategori, int daya)
            : base(kode, nama, stok, kategori)
        {
            DayaListrik = daya;
        }

        public override void TampilkanInfo()
        {
            // panggil versi parent dulu
            base.TampilkanInfo();
            // tambahkan info spesifik elektronik
            Console.WriteLine($"Daya Listrik : {DayaListrik} Watt");
        }
    }
}
