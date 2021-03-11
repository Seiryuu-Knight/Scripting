using System;

namespace Intercambio1
{
    class Program
    {
        public static void Main()
        {

            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            for (int j = 0; j < estatura.Length; j++)
            {

                for (int i = 0; i < estatura.Length - 1; i++)
                {

                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;

                        string nm = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = nm;

                    }

                }

            }

            for (int h = 0; h < estatura.Length; h++)
            {

                Console.WriteLine(nombres[h]);
                Console.WriteLine(estatura[h]);

            }

        }
    }
}
