using System;

Console.WriteLine("Insira a hora inicial e depois a hora final de um jogo: ");

/*
 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
   começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
   Entrada:
   16 2         Saída: O JOGO DUROU 10 HORA(S)
   Entrada: 0 0 Saída: O JOGO DUROU 24 HORA(S)
   Entrada: 2 16Saída: O JOGO DUROU 14 HORA(S)
 */

int horaInicial = int.Parse(Console.ReadLine());
int horaFinal = int.Parse(Console.ReadLine());

int duracaoJogo = horaInicial - horaFinal;

if (duracaoJogo > horaInicial)
{
    duracaoJogo = horaFinal - horaInicial;
}
else {
    duracaoJogo = 24 - horaInicial + horaFinal;
}

if (duracaoJogo < 1)
    duracaoJogo = 24;

    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
