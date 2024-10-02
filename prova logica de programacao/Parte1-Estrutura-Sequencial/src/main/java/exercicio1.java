import java.util.Locale;
import java.util.Scanner;

public class exercicio1 {
    public static void main(String[] args) {

    Scanner scanner = new Scanner(System.in);
    scanner.useLocale(Locale.US);

    //Recebendo entradas do usuário

        //1
    System.out.println("Digite o código da peça 1");
    int codPeca1 = scanner.nextInt();

    System.out.println("Digite o número de peças 1");
    int numPeca1 = scanner.nextInt();

    System.out.println("Digite o valor unitário de cada peça 1");
    double valorPeca1 = scanner.nextDouble();

        //2
    System.out.println("Digite o código da peça 2");
    int codPeca2 = scanner.nextInt();

    System.out.println("Digite o número de peças 2");
    int numPeca2 = scanner.nextInt();

    System.out.println("Digite o valor unitário de cada peça 2");
    double valorPeca2 = scanner.nextDouble();

        //--------------------------------------
    double conta1 = (numPeca1 * valorPeca1);
    double conta2 = (numPeca2 * valorPeca2);
    //--------------------------------------
    double valorTotal = (conta1 + conta2);

    System.out.printf("VALOR TOTAL: R$ %.2f%n", valorTotal);

    }
}
