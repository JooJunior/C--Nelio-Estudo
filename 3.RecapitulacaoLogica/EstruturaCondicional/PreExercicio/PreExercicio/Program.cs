using System;

// Qual a hora atual
Console.WriteLine("Qual a hora atual");
int horaAtual = int.Parse(Console.ReadLine());

if (horaAtual < 12)
{
    Console.WriteLine("Bom dia!");
}
else if (horaAtual >= 12 && horaAtual < 18)
{
    Console.WriteLine("Boa tarde!");
}
else //(horaAtual >= 18)
     //Em uma estrutura de controle if-else, a cláusula else não deve
     //ter uma condição, pois ela captura todos os casos que não são
     //cobertos pelas condições if e else if anteriores.
{
    Console.WriteLine("Boa noite!");
}



