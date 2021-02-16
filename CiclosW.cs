using System;

namespace ciclosW
{
    class Program
    {
        public static void Main()
        {
            double total = 0;
            Console.Write("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string mayor = "";
            string menor = "";

            while (i<n)
            {
                Console.Write("Nombre: ");
                string nombre = (Console.ReadLine());
                
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = edad;
                    min = edad; 
                }

                if (edad > max)
                {
                    max = edad;
                    mayor = nombre;
                }

                if (edad < min)
                {
                    min = edad;
                    menor = nombre;
                }
                
                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("promedio = " + promedio);
            Console.WriteLine("Mayor = " + max);
            Console.WriteLine("Menor = " + min);
            Console.WriteLine("Persona menor = " + menor);
            Console.WriteLine("Persona mayor = " + mayor);
        }
    }
}
