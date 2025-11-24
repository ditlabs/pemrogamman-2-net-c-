using System;
using Gudang_OOP_4.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== DEMO ABSTRACT CLASS & INTERFACE (BAB 4) ===\n");

        // Contoh item gudang kimia & makanan
        ItemGudang item1 = new BarangKimia("KIM001", "Asam Sulfat");
        ItemGudang item2 = new BarangMakanan(
            "MAK001",
            "Susu Kental",
            DateTime.Parse("2023-12-01")
        );

        // Cetak info & evaluasi resiko
        item1.CetakInfo();
        Console.WriteLine(item1.EvaluasiResiko());
        Console.WriteLine();

        item2.CetakInfo();
        Console.WriteLine(item2.EvaluasiResiko());

        // Cek apakah item2 juga punya perilaku interface IPeriksaKadaluarsa
        if (item2 is IPeriksaKadaluarsa periksa)
        {
            Console.WriteLine(periksa.ApakahKadaluarsa()
                ? "Kadaluarsa"
                : "Masih berlaku");
        }

        Console.WriteLine("\n=== Program Selesai ===");
        Console.ReadLine();
    }
}
