import java.util.Map;
import java.util.Scanner;

public class exercicio2 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("Informe o código do item:");
        int codigoItem = scanner.nextInt();

        System.out.println("Informe a quantidade do item:");
        int quantidadeItem = scanner.nextInt();

        double cachorroQuente = 4.00 * quantidadeItem;
        double xSalada = 4.50 * quantidadeItem;
        double xBacon = 5.00 * quantidadeItem;
        double torradaSimples = 2.00 *quantidadeItem;
        double refrigerante = 1.50 * quantidadeItem;

        //Para aparecer os emojis, pressione ctrl + alt + "/" -> No teclado de casa é o barra com interrogação

        if (codigoItem == 1)
            System.out.printf("Total: R$ %.2f%n" , cachorroQuente);
        if (codigoItem == 2)
            System.out.printf("Total: R$ %.2f%n", xSalada);
        if (codigoItem ==3) System.out.printf("Total: R$ %.2f%n" , xBacon);
        if (codigoItem ==4) System.out.printf("Total: R$ %.2f%n" , torradaSimples);
        if (codigoItem ==5) System.out.printf("Total: R$ %.2f%n" , refrigerante);

    }
}
