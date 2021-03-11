using System;

namespace ArreglodeDatos
{
    class Program
    {
        public static void Main()
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            double totalE = 0;
            double promedioE;
            for (int e = 0; e < estatura.Length; e++)
            {
                totalE += estatura[e];

            }

            promedioE = totalE / estatura.Length;

            double[] distanciaE = new double[estatura.Length];
            for (int d = 0; d < estatura.Length; d++) 
            {
                distanciaE [d]= Math.Sqrt((estatura[d] - promedioE) * (estatura[d] - promedioE));
                Console.WriteLine(distanciaE [d]);
            }

            Console.WriteLine(promedioE);

            string mini = "";
            double min = 200;
            double mD;
            for (int x = 0; x < estatura.Length; x++)
            {
                if (distanciaE[x] < min)
                {
                    min = distanciaE[x];
                    mini = nombres[x];
                }
                
            }

            Console.WriteLine(mini);


        }
    }
}
