using System;

namespace Gudang_OOP_7
{
    public class StokNegatifException : Exception
    {
        public StokNegatifException(string pesan) : base(pesan)
        {
        }
    }
}
