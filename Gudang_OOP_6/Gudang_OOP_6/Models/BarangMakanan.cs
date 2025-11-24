using System;

namespace Gudang_OOP_6.Models
{
    public class BarangMakanan : ItemGudang, IPeriksaKadaluarsa
    {
        public DateTime TanggalKadaluarsa { get; set; }

        public BarangMakanan(string kode, string nama, DateTime kadaluarsa)
            : base(kode, nama)
        {
            TanggalKadaluarsa = kadaluarsa;
        }

        public override string EvaluasiResiko()
        {
            return "Perlu suhu penyimpanan stabil.";
        }

        public bool ApakahKadaluarsa()
        {
            return TanggalKadaluarsa < DateTime.Today;
        }
    }
}
