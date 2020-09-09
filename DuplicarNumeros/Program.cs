using System;

namespace DuplicarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero a Duplicar");
            string numeroval = Console.ReadLine();
            double numerodpl = Convert.ToDouble(numeroval);

            double duplicado = Math.Pow(numerodpl, 2.00);
            Console.WriteLine("El numero que eligio fue: {0} y su duplicado es: {1}",numerodpl,duplicado);
        }
    }
}
