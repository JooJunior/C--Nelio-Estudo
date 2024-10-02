/*
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

import java.util.Locale;
import java.util.Scanner;

public class teste {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        scanner.useLocale(Locale.US);

        // 1
        System.out.println("Digite o código da peça1");
        int codPeca1 = scanner.nextInt();

        System.out.println("Digite o numero de peças 1");
        int numPeca1 = scanner.nextInt();

        System.out.println("Digite o valor unitario de peças 1");
        double valorUnitario1 = scanner.nextDouble();

        //2
        System.out.println("Digite o código de peça2");
        int codPeca2 = scanner.nextInt();

        System.out.println("Digite o número de peças 2");
        int numPeca2 = scanner.nextInt();

        System.out.println("Digite o valor unitário de peças 2");
        double valorUnitario2 = scanner.nextDouble();


        // calculando
        double calculo1 = (numPeca1 * valorUnitario1);
        double calculo2 = (numPeca2 * valorUnitario2);
        double calculoTotal = (calculo1+calculo2);
        System.out.printf("VALOR A PAGAR: R$ %.2f%n " , calculoTotal);


    }
}
