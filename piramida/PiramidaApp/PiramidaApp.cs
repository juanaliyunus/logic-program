namespace Piramida
{
    class PiramidaApp
    {
        static void Main(string[] args)
        {
            PrintPiramida(8);  // Contoh memanggil dengan 8 baris
        }

        static void PrintPiramida(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Loop untuk mencetak spasi
                for (int j = 0; j < n - i - 1; j++)
                {
                    System.Console.Write(" ");
                }

                // Loop untuk mencetak bintang
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write("*");
                }

                // Pindah ke baris baru setelah mencetak satu baris piramida
                System.Console.WriteLine();
            }
        }
    }
}
