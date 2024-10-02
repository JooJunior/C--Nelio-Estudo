import java.util.Locale;
import java.util.Scanner;

public class exercicio1_2 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        scanner.useLocale(Locale.US);


        System.out.println("Insira o valor do raio de um circulo:");
        double raioCirculo = scanner.nextDouble();

        // Fórmular é -> área = pi.raio²
        // OBS: coloquei raiocirculo*raiocirculo pra fazer o raio², porém, deve ter outro jeito de elevar o número
        double areaCirculo = 3.14159*(raioCirculo*raioCirculo);
        System.out.printf("Valor da ára deste circulo com quatro casas decimais é: %.4f%n" , areaCirculo);

        //Usandi biblioteca do Math.pow
        double areaCirculoAlternativo = 3.14159 * Math.pow(raioCirculo,2); //Recebe (double a, double b) -> double b é o expoentel
        System.out.printf("Saída: %.4f%n" , areaCirculoAlternativo);

    }
}
