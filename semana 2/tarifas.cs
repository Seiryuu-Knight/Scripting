using System;

namespace t
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese su SMMLV sin puntos: ");
            double salario = double.Parse(Console.ReadLine());

            //salario minimo 2021 es de $908.526 en Colombia
            if (salario <= 1817051)
            {
                Console.WriteLine("usted pertenece a la tarifa A");
            }

            else if (1817052 <= salario && salario <= 3634104 )
            {
                Console.WriteLine("usted pertenece a la tarifa B");
            }

            else if (salario >= 3634104)
            {
                Console.WriteLine("usted pertenece a la tarifa c");
            }
        }
    }
}

