import java.util.Scanner;

public class exercicio3 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("Insira a senha:");
        int senha = scanner.nextInt();


        while (senha != 2002) {
            System.out.println("Senha incorreta!");
            senha = scanner.nextInt();
            if (senha == 2002)
                System.out.println("Acesso permitido");

        }
    }
}

