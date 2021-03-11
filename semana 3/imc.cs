using System;

namespace IMC
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese su altura en cm: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su peso en Kilogramos: ");
            double peso = double.Parse(Console.ReadLine());

            //dividir peso/altura2
            double IMC = (peso) / ((altura) * (altura));
            Console.WriteLine("Su IMC es: " + IMC);

            if (IMC < 18.5)
            {
                Console.WriteLine("Usted esta bajo de peso");
            }
            else
            {
                if (18.9<=IMC && IMC< 24.9)
                {
                    Console.WriteLine("Su peso es normal");
                }

                if (25.0<= IMC && IMC <= 29.9)
                {
                    Console.WriteLine("Usted tiene Sobrepeso");
                }

                if (IMC > 30.0)
                {
                    Console.WriteLine("Usted esta obeso");
                }
            }

        }
    }
}
