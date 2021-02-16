using System;
using System.Globalization;
namespace Uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area, perimetro;

            string[] vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (a >= b + c)
            {
                area = a + b;
                Console.WriteLine();
                Console.WriteLine("Area = " + area.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                perimetro = a + b + c;
                Console.WriteLine();
                Console.WriteLine("Perimetro = " + perimetro.ToString(CultureInfo.InvariantCulture));
            }

        }
    }
}
