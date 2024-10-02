// See https://aka.ms/new-console-template for more information

// Operadores Comparativos
/*
int a = 10;
int b = 2;
bool resultado = b<a;
bool resultado2 = a > 100;

Console.WriteLine(resultado);
Console.WriteLine(resultado2);
Console.WriteLine("---------------------------");

bool resultado3 = a <=10;
bool resultado4 = a >=10;
Console.WriteLine(resultado3);
Console.WriteLine(resultado4);
*/

// Operadores lógico
//bool c1 = 2 >3 && 4 !=5; -> 2 é maior que 3(FALSO) E 4 é diferente de 5(TRUE) => Falso
bool c1 = 2>3 || 4 !=5; // 2 é maior que 3(FALSO) OU 4 é diferende de 5(TRUE) => True
bool c2 = ! (2 >3) || 4 !=5; // 2 é maior que 3(FALSO) (VIRANDO TRUE PELA NEGAÇÂO "!") OU 4 é diferende de 5(TRUE) => True
Console.WriteLine(c1);
Console.WriteLine(c2);
