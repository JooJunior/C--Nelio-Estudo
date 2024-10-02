using System;
using System.Globalization;
using System.Security.Cryptography;

//using System Globalization; para usar ponto como separadaor (questão de idioma);

namespace Course{
    class Program
    {
        public static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            
            /*
            //string nome = string.Parse(Console.ReadLine());
            string nome = Console.ReadLine();
            char sexo = char.Parse(Console.ReadLine());
            int idade = int.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            if (sexo != 'F' && sexo != 'M')
            {
                return;
            }
            //Nesse código, a condição if (sexo != 'F' && sexo != 'M')
            //verifica se sexo não é 'F' e não é 'M'. Se qualquer uma
            //dessas condições for verdadeira, o programa vai retornar (ou seja, sair).
            
            Console.WriteLine("Você digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");


            /*
            string frase = Console.ReadLine();
            string[] vet = frase.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            string p4 = vet[3];
            

            */

            //frase completa v2
            string[] vet = Console.ReadLine().Split(' ');
            string nomev2 = vet[0];
            char sexov2 = char.Parse(vet[1]);
            int idadev2 = int.Parse(vet[2]);
            double alturav2 = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nomev2);
            Console.WriteLine(sexov2);
            Console.WriteLine(idadev2);
            Console.WriteLine(alturav2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}