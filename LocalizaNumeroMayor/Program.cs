using System;

namespace LocalizaNumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar el tamaño del arreglo");
            int[] arreglo = new int[int.Parse(Console.ReadLine())];
            
            for (int x =0; x < arreglo.Length; x++)
            {
                Console.WriteLine("Inrese el valor de la casilla "+x);
                 arreglo[x] = int.Parse(Console.ReadLine());
            }
            //
            Console.WriteLine("El arreglo es:\n");
            for (int x = 0; x<arreglo.Length; x++)
            {
                Console.WriteLine(arreglo[x] );
            }

            Console.WriteLine("\nLa casilla con el valor mas grande es: "+SacarMayor(arreglo).ToString());

            Console.ReadKey();
        }

        static int SacarMayor(int[] arreglo)
        {
            int CasillaMayor = 0, ValorMayor = 0;
            for (int x = 0; x < arreglo.Length; x++)
            {
                if (x == 0)
                {
                    CasillaMayor = x;
                    ValorMayor = arreglo[x];
                }
                else
                {
                    if (arreglo[x] >= ValorMayor)
                    {
                        if (arreglo[x] > ValorMayor)
                        {
                            CasillaMayor = x;
                            ValorMayor = arreglo[x];
                        }
                    }
                }
            }
            return CasillaMayor;
        }

    }
}
