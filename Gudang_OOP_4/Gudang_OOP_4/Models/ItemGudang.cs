using System;

namespace Gudang_OOP_4.Models
{
    public abstract class ItemGudang
    {
        public string Kode { get; set; }
        public string Nama { get; set; }

        protected ItemGudang(string kode, string nama)
        {
            Kode = kode;
            Nama = nama;
        }

        public void CetakInfo()
        {
            Console.WriteLine($"[{Kode}] {Nama}");
        }

        // Wajib dioverride di class turunan
        public abstract string EvaluasiResiko();
    }
}
