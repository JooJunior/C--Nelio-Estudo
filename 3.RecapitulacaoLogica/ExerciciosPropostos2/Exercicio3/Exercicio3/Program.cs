using System;

/*
 *  Se o resto da divisão de um número pelo outro for zero,
 *  então o primeiro número é múltiplo do segundo.
 */

int A = int.Parse(Console.ReadLine()); 
int B = int.Parse(Console.ReadLine());

if ((A == 0) || (B == 0))
{
 Console.WriteLine("Não pode inserir valor 0");
 return;
}

if ((A % B == 0) || (B % A ==0)){

 Console.WriteLine("São Múltiplos");
 
}
else
{
 Console.WriteLine("Não são Múltiplos");
}