using Gudang_OOP_7.Models;

namespace Gudang_OOP_7.Factories
{
    public static class BarangFactory
    {
        public static Barang BuatBarang(string tipe)
        {
            if (tipe == "Elektronik")
                return new Barang("ELK001", "Scanner", 10, "Elektronik");

            if (tipe == "Makanan")
                return new Barang("MAK001", "Susu", 50, "Makanan");

            return new Barang("GEN001", "Barang Umum", 20, "Umum");
        }
    }
}
