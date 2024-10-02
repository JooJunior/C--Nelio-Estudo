using System;
using System.Globalization;
using System.Security.Cryptography;

Console.WriteLine("Entre com seu nome completo: ");
string nomeCompleto = Console.ReadLine(); 
//string[] nomeSeparado = nomeCompleto.Split(' ');
//string ultimoNome = nomeSeparado[1];

Console.WriteLine("Quandos quartos tem sua casa ?");;
int quantosQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");

//string ultimoNome = Console.ReadLine();
//int idade = int.Parse(Console.ReadLine());
//double altura = double.Parse(Console.ReadLine());

string entradaCompleta = Console.ReadLine();
string[] unicaFrase = entradaCompleta.Split(" ");
string ultimoNome = unicaFrase[0];
int idade = int.Parse(unicaFrase[1]);
double altura = double.Parse(unicaFrase[2], CultureInfo.InvariantCulture);

Console.WriteLine($"{ultimoNome} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
