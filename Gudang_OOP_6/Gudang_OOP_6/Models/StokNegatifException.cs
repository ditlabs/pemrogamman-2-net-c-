using System;

namespace Gudang_OOP_6.Models
{
    public class StokNegatifException : Exception
    {
        public StokNegatifException(string pesan) : base(pesan) { }
    }
}
