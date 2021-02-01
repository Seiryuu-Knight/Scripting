using System;

namespace stats
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("ingrese el nivel del jugador: ");
            int level = int.Parse(Console.ReadLine());
            Console.Write("ingrese el daño recibido: ");
            double damage = double.Parse(Console.ReadLine());

            double saludI = 576.16;
            double saludN = 87;
            double armaduraI = 47;
            double armaduraN = 4;

            double salud = saludI + (saludN * level);
            double armadura = armaduraI + (armaduraN * level);
            double dañoR = damage * (100.0 / (100.0 + armadura));

            Console.WriteLine("Tu salud actual: " + salud);
            Console.WriteLine("Tu armadura actual: " + armadura);
            Console.WriteLine("Daño ejercido: " + dañoR);
        }
    }
}
