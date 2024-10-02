import java.util.Locale;
import java.util.Scanner;

import static java.util.Locale.US;

public class exercicio2_2 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        scanner.useLocale(Locale.US);

        System.out.println("Insira o valor de a: ");double a = scanner.nextDouble();
        System.out.println("Insira o valor de b: ");double b = scanner.nextDouble();
        System.out.println("Insira o valor de c: ");double c = scanner.nextDouble();

        //ax² + bx + c = 0
        // delta = b² -4ac

        //double delta = b*b - 4*a*c;
        double delta = Math.pow(b, 2) - 4 * a * c;
        double raizDelta = Math.sqrt(delta);

        if (a==0 || delta <0)
            System.out.println("Impossível calcular");

        double x1 = (-b + raizDelta)/(2*a);
        double x2 = (-b - raizDelta)/(2*a);

        if (delta >0 && a>0 )
            System.out.printf("X1 = %.5f%n" + "\nX2 = %.5f%n" ,x1, x2);


    }
}
