using System;

namespace Course
{
    public class _20conversaoimplicitaecasting
    {
        public static void Main(string[] args)
        {
            // Casting explícito para truncar valores decimais
            double a;
            int b;

            a = 5.1;
            b = (int)a;
            Console.WriteLine(b); // Valores decimais foram truncados e vai imprimir só 5

            // Usando casting para obter um resultado decimal
            int x = 5;
            int y = 2;
            double resultado = (double)x / y;
            Console.WriteLine(resultado); // Imprime 2.5
        }
    }
}