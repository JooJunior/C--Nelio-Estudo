
# Profissional Csharp

**Fundamentos**
1. Lógica de programação
-  Estruturas de dados e POO
2. Banco de dados
3. Análise e Design de sistemas

**Comercial**
Back end
Web
Mobile
Desktop
Games

## Utilitarios 

**Identação automátoca** -> CTRL + K + D;

*Método ou atributo estatico é algo como se fosse global, mesmo sem instanciar, ele existe*;



****

## Introdução

C# -> Linguagem de programação 
.NET é uma especificação que permite programação de várias linguagens

- .NET

BCL - Base class library

CLR - tipo a JVM do Java
possui garbage collection, diferente da jvm

- .NETStandard (especificação do .NET)
Implementações -> (NetFramework; 
Xamarin (Andoird, iOS, MacOs); 
Mono; 
NETcore)

****

## Compilação e Interpretação

**Como funciona os programas do C#**

**Bytecote:** *É através dele que é possível rodar o C# em diferentes máquinas de forma mais direta... é tipo a JVM do Java;
Basicamente ele roda o código dentro de uma máquina virtual de cada sistema;
+portabilidade*

compilação & compilador -> Commom Intermediate Language (CIL) -> compilação Just-in-time (JIT) && .NET Comommon Language Runtime (CLR) - do SO -> Código de máquina

## Estrutura

- **Namespace** = agrupamento LÓGICO de classes relacionadas

- **Assembly** (DLL ou EXE) = agrupamento FÍSICO de classes relacionadas (build)

- **Aplicação** ou **Solução** = Agrupamento de assemblies relacionados

- Aplicação -> Solução
- Assembly -> Projeto

****
## Estrutura do projeto

Um projeto C# é uma solução 
Estrutua de arquivos

***Console** pertence ao **System**;*

*namespace não é obrigatorio para o programa rodar, mas não é boa prática;*

*TODO código do C# tem que estar dentro de uma classe*;

### static void Main(string[] args)
Declaração padrão para identificarr o entre Ponte da Aplicação
~Onde a execução começa;
~Onde vai ser executado primeiro no programa;

****

## Recapitulação Lógica de Programação

- string é IMUTÁVEL
Depois de declarar, você não pode mudar as propriedades de uma String;

- Toda classe em C# é subclasse de object

**Função para valores mínimos e máximos**
int.MinValue
int.MaxValue
sbyte.MaxValue
long.MaxValue
decimal.MaxValue
etc. 

### Restrições para nomes de variáveis

não pode começar com dígito: use letra ou _
não use acentos
não pode espaço em branco

Use nomes com significados

**Convenções:**
CamelCase (parâmetro de métodos, var dentro de métodos)
PascalCase (==namespaces==, classe, properties e métodos)
Padrão_lastName (atriutos "internos" da classe)

```
namespace Curso   <- PascalCase
{
	classe ContaBancaria <- PascalCase
	public string Titular {get; set;} <- PascalCase

	public void Deposito (double quantia){
	_saldo += quantia;_<- "_" pois é atributo interno de classe
	}
	public double GetSaldo(){ <- PascalCase
	retirn_saldo;
	}
}
```
### Jeito de dar FORMAT no C#

*ToString e ("F2")* 

```
//Usando ToString  
  
double saldo = 10.35784;  
  
Console.WriteLine(saldo.ToString("F2"));

````


### Placeholders, concatenação e interpolação

```
int idade = 32;  
double grana = 10.35784;  
string pessoa = "Maria";  
  
//Placeholders  
Console.WriteLine("{0} tem {1} e tem saldo igual a {2:F2} reais ", pessoa, idade, grana);  
  
//Interpolação  
Console.WriteLine($"{pessoa} tem {idade} e tem saldo igual a {grana:F2} reais");  
  
//Concatenação  
Console.WriteLine(pessoa + " tem " + (idade) + " e tem zsaldo igual a " + grana.ToString("F2") + " reais");
```

****

## Operadores de atribuição

```
=
+=
-=
*=
/=
%=

ex: 
int a = 10;
a += 2;

vai retornar 
12

É tipo uma iteração sei lá
```

## Operador aritmétrico / iteração

**Incrementar**
++; a++ ou ++a; a = a+1;
**Decrementar**
a--; a-- ou --a; a = a-1;

*OBS: Se o operador ++ ou -- vier antes, vai incre/decre. antes*

****

## Conversão implícita e casting

- **Conversão** **implícita** entre tipos é quando um conteúdo de um certo tipo pode ser naturalmente atribuído pra uma variável de outro tipo;

Explicação prática:
Basicamente é converter um tipo de valor para outro. 
```
ex: passar valor int a para receber b double valor a;
ex de problema: 
double a; int b;
a = 5.1; 
b =a; 
impromir(b)
//se "a" é double, não pode converter para int; double tem 8 bytes, int tem 4.
``` 

- **Casting** é uma **conversão** **explícita** entre tipos compatíveis;

Explicação prática:
Quando eu for querer explicitar um valor, eu tenho que: 
```
//Usando Casting  
int a; int b;  
a = 5; b = 2;  
double resultado = (double) a / b;  
Console.WriteLine(resultado);
```
o **casting** é nesse caso, (double) **antes do valor**;
mesmo com o double atribuido ao resultado, iria imprimir "2"; 
por isso, precisa explicitar com o casting por que a e b tinham valor int.

ex2:
```// Usando casting para explicitar numInteiro em numDouble  
private int n3 = 10 / 8;  
private double n3casting = (double) 10 / 8;
```

****
## Operadores aritmeticos
```
+ - * / %(Mod que é o RESTO da divisão. Ex: 17/3 mod é 2 pois 17-15 = 2)

Ordem de precedência
+ / %
```

==Calcular **Raíz**==
**Math.sqrt**()
sqrt-> "raiz de..."

**Math.pow** (a, 2)
*"a elevado a 2"*

****

## Entrada de dados

Basicamente o ...ReadLine();

Parte importante: SPLIT

## Split
==IMPORTANTE!==
função para recortar string em vários pedacinhos conforme o caracter indicado entre ' ';

Ex de uso:
```
//ex1:
string frase = Console.ReadLine();      // -> Criei uma string (leitor) para ler dados; 
string[] fraseVetor = frase.Split(' '); // -> Criei um vetor de string atribuindo ao leitor(frase) uma split separada por espaço -> (' ')
// Criei p1, p2, p3 string e atribui a posição no vetor de string que criei
string p1 = fraseVetor[0]; 
string p2 = fraseVetor[1];  
string p3 = fraseVetor[2];  

Console.WriteLine(p1);  
Console.WriteLine(p2);  
Console.WriteLine(p3);

```

### ReadLine é string

Para converter uma entrada double, int, char, devemos: 
(tipo, variável = tipo.Parse(...))
```
int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

````

****

## Operadores Lógicos

&&  => E
||    => OU
!     => NÃO

**Precedência:**
! > && > ||
(Não >  E > OU)

ex:
```

//bool c1 = 2 >3 && 4 !=5; -> 2 é maior que 3(FALSO) E 4 é diferente de 5(TRUE) => Falso  

//bool c1 = 2 >3 || 4 !=5; // 2 é maior que 3(FALSO) OU 4 é diferende de 5(TRUE) => True
```

O ! (NÃO) transforma expressão verdadeira em falso e fasl em verdadeiro
ex:
```
2 > 3 || 4 !=5 ->True
!(2>3) && 4 !=5 -> True
```

****

## Estrutura Condicional

### Simples (SE)
if ( condição) {
	comando1
	comando2
}

### Composta (SE-NÃO)
if ( condição) {
	comando1
	comando2
}
else{
	comando3
	comando4
}


### Encadeamentos (SE ou SE-NÃO...- "Caso contrário")
if ( condição 1) {
	comando1
	comando2
}
else if (condição 2)
{
	comando3
	comando4
}
else (condição 3)
{
	comando5
	comando6
}

ex: 
```
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
     //Em uma estrutura de controle if-else, a cláusula else não deve     //ter uma condição, pois ela captura todos os casos que não são     //cobertos pelas condições if e else if anteriores.{  
    Console.WriteLine("Boa noite!");  
}
```


****

## Escopo e Inicialização

- Não podemos usar variável se não declararmos;
- Uma variável que existe apenas no escopo (ex: dentro de if), só vai existir durando a execução da estrutura e ao encerrar a estrutura, a variável some;

ex: O escopo maior é o Program>psvm e o menor é o if
```
Classe Program{
PSVM{

double preco = double.Parse(console.RD){
	if(preco > 100.0){
		double desconto = preco * 0.1;
	}
	Console.WrL(desconto); // ERRO, {desconto} ACABOU NA LINHA DE CIMA, ONDE ACABA O IF (escopo menor)
}
}
}

```
















