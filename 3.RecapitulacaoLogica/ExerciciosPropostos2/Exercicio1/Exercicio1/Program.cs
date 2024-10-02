using System;

//Fazer programa para ler um núm inteiro, e depois dizer se é negativo ou não


int numInt = int.Parse(Console.ReadLine());

if (numInt < 0)
Console.WriteLine("NEGATIVO");

else
{
    Console.WriteLine("NÃO NEGATIVO");
}