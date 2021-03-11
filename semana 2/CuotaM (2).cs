using System;

namespace Tarifa
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("ingrese su SMMLV sin puntos: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 1817051)
            {
                Console.WriteLine("usted pertenece a la tarifa A");
                Console.WriteLine("su cuota moderadora es de $3500");
            }

            else if (1817052 <= salario && salario <= 4542631)
            {
                Console.WriteLine("usted pertenece a la tarifa B");
                Console.WriteLine("su cuota moderadora es de $14000");
            }
            else if (salario > 4542631)
            {
                Console.WriteLine("usted pertenece a la tarifa c");
                Console.WriteLine("su cuota moderadora es de $36800");
            }
        }
    }
}
