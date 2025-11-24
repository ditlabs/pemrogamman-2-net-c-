using System;
using Gudang_OOP_7.Models;
using Gudang_OOP_7.Helpers;

namespace Gudang_OOP_7.Services
{
    public class InputBarang
    {
        public Barang AmbilInput()
        {
            Console.Write("Kode: ");
            string kode = Console.ReadLine() ?? "";

            Console.Write("Nama: ");
            string nama = Console.ReadLine() ?? "";

            int stok = InputHelper.AmbilStokValid();

            Console.Write("Kategori: ");
            string kategori = Console.ReadLine() ?? "";

            return new Barang(kode, nama, stok, kategori);
        }
    }
}
