using System;

namespace Gudang_OOP_6.Models
{
    public class BarangKimia : ItemGudang
    {
        public BarangKimia(string kode, string nama)
            : base(kode, nama)
        {
        }

        public override string EvaluasiResiko()
        {
            return "Perlu penyimpanan khusus bahan berbahaya.";
        }
    }
}
