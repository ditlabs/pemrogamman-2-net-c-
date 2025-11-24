using System;
using Gudang_OOP_7.Models;
using Gudang_OOP_7.Interfaces;

namespace Gudang_OOP_7.Services
{
    public class PencetakBarang : IBarangPrinter
    {
        public void Cetak(Barang barang)
        {
            Console.WriteLine("=== INFORMASI BARANG ===");
            Console.WriteLine($"Kode     : {barang.KodeBarang}");
            Console.WriteLine($"Nama     : {barang.NamaBarang}");
            Console.WriteLine($"Stok     : {barang.JumlahStok}");
            Console.WriteLine($"Kategori : {barang.Kategori}");
            Console.WriteLine("=========================");
        }
    }
}
