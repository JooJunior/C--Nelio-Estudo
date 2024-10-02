// See https://aka.ms/new-console-template for more informationp

using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30; 
int codigo = 5290; 
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine("Computador, cujo preço é $ {0}", preco1);
Console.WriteLine($"Mesa de escritório, cujo preço é $ {preco2}\n");

Console.WriteLine($"Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero + "\n");

Console.WriteLine($"Medidade com oito casas decimais: {medida}" );
Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
Console.WriteLine($"Arredo ndado (três casas decimais): {medida.ToString("F3", CultureInfo.InvariantCulture)}");