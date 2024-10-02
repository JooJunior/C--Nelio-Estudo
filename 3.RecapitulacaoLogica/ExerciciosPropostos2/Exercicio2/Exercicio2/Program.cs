using System;

// Fazer um programa para ler um num inteiro e dizer se este num é par ou ímpar

int numInt = int.Parse(Console.ReadLine());

if (numInt % 2 ==0)
Console.WriteLine("PAR");
else{
Console.WriteLine("ÍMPAR");
}