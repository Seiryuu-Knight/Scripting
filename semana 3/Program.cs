using System;

namespace _0302
{
    public class program
    {
        public static void Main()
        {
            Console.Write("Ingrese el numero de votos partido a: ");
            int votosA = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de votos partido b: ");
            int votosB = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los votos en blanco: ");
            int Vblancos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los votos anulados: ");
            int Vanulados = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero total de la población: ");
            int poblacion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de la población que es mayor de edad: ");
            int porcentaje = int.Parse(Console.ReadLine());

            int Vtotales = votosA + votosB + Vblancos + Vanulados;

            int aptos = (poblacion * porcentaje);

            int abstinencia = aptos - (votosA + votosB + Vblancos + Vanulados);

            bool condicion1 = Vanulados < (votosA + votosB) * 30.0 / 100;
            bool condicion2 = (votosA + votosB) > Vblancos;
            bool condicion3 = abstinencia > Vtotales;
            
            if (Vtotales < abstinencia)
            {
                Console.WriteLine("Las votaciones se deben volver a realizar");
            }

        }


    }
}


