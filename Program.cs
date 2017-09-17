using System;

namespace Botellas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Altura, Mínimo, Espacio, Bloque;
            Console.WriteLine ("¿Cuál es la altura a la que deseas la torre? (Límite de mínimo de 1 y máximo de 23)");
            Altura = Convert.ToInt32 (Console.ReadLine());
            while (Altura > 23 || Altura < 1)
            {
                Console.WriteLine ("Intenta otro número dentro el límite");
                int.TryParse (Console.ReadLine (), out Altura);
            }
            for (Mínimo = 1; Mínimo <= Altura; Mínimo++)
            {
                for (Espacio = (Altura - Mínimo); Espacio > 0; Espacio--)
                {
                    Console.Write (" ");
                }
                for (Bloque = 1; Bloque <= 2 * Mínimo; Bloque++)
                {
                    Console.Write ("#");
                }
                Console.WriteLine ();
            }
        }
    }
}
