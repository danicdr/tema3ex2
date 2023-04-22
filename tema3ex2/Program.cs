using System;
//Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul
namespace MyFirstProgram2._1
{
    class Program
    {
        public static bool EsteNumarPrim(int numar)
        {
            if (numar < 2)
            {
                return false;
            }

            for (int i = 2; i <= numar; i++)
            {
                if (numar % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int numar = int.Parse(Console.ReadLine());
            bool estePrim = EsteNumarPrim(numar);

            if (estePrim)
            {
                Console.WriteLine("prim");
            }
            else
            {
                Console.WriteLine(" nu este prim.");
            }
        }
    }
}