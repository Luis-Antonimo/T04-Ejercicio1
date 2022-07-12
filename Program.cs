using System;

namespace T04Ejercicio1
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = a + b + b;
            Console.WriteLine("Las variables originales son A:{0} B:{1} C:{2}", a, b, c);
            Console.WriteLine("La suma de las variables es: " + d);
        }
    }
}