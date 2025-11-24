using System;

namespace Gudang_OOP_7.Interfaces
{
    public interface IPeriksaKadaluarsa
    {
        DateTime TanggalKadaluarsa { get; set; }
        bool ApakahKadaluarsa();
    }
}
