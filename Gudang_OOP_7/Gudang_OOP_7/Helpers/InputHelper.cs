using System;

namespace Gudang_OOP_7.Helpers
{
    public static class InputHelper
    {
        public static int AmbilStokValid()
        {
            while (true)
            {
                Console.Write("Stok: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int stok))
                {
                    if (stok >= 0)
                        return stok;

                    Console.WriteLine("Stok tidak boleh negatif!");
                }
                else
                {
                    Console.WriteLine("Input harus angka!");
                }
            }
        }
    }
}
