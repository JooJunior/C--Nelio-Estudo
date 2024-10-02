// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//
//SByte x = 100; //SByte->.NET -- byte->C#

byte n1 = 254;
//byte n2 = -126; // NÃO aceita negativo
//byte n3 = 256; // NÃO pode ser > 255

// byte n1 = 255; n1++; -> VAI DAR 0

bool completo = false;
char genero = 'F';
char letra = '\u0041';

int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L; //POE O "L" no final p mostrar que ta trab. com LONG
float n5 = 4.5f; //POE "F" pra especificar que é FLOAT;
double n6 = 4.5;

string nome = "Maria Green";
object obj1 = "Alex Brown"; //tipo genérico

int maxValue = int.MaxValue;
int minValue = int.MinValue;

Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(letra);

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(n6);

Console.WriteLine(nome);
Console.WriteLine(obj1);

Console.WriteLine(maxValue);
Console.WriteLine(minValue);

//Usando ToString

double saldo = 10.35784;

Console.WriteLine(saldo.ToString("F2"));

//### Placeholders, concatenação e interpolação

int idade = 32;
double grana = 10.35784;
string pessoa = "Maria";

//Placeholders
Console.WriteLine("{0} tem {1} e tem saldo igual a {2:F2} reais ", pessoa, idade, grana);

//Interpoçaão
Console.WriteLine($"{pessoa} tem {idade} e tem saldo igual a {grana:F2} reais");

//Concatenação
Console.WriteLine(pessoa + " tem " + (idade) + " e tem zsaldo igual a " + grana.ToString("F2") + " reais");



