using System;

namespace Course
{
    class Program
    {
        static void Main(String[] args)
        {
            
            
            //Entrada facil
            string teste = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            //todo dado atribuido a variavel, é a frase inteira
            
            Console.WriteLine(teste + " xereca");
            Console.WriteLine(x);
            Console.WriteLine(y);
            
            //com Split
            string frase = Console.ReadLine();
            string[] fraseVetor = frase.Split(' ');
            string p1 = fraseVetor[0];
            string p2 = fraseVetor[1];
            string p3 = fraseVetor[2];
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            
            
            
            
            /* Exercício feito em aula
             
             
            //usando SPLIT para separar pela definição do split, no meio da frase inteira
            
            string frase = Console.ReadLine();//entrada de frase

            //separando por espaço vazio
            string[] vet = frase.Split(' '); 
            //vetor de string ->[]; .Split('espaçoVazio'); 
            //REGISTRIE O VALOR EM vet, agora vamos imprimir cada parte do vetor separado

            string parte1vetor = vet[0];
            string parte2vetor = vet[1];
            string parte3vetor = vet[2];

            Console.WriteLine(frase);
            
            */

        }
    }
}