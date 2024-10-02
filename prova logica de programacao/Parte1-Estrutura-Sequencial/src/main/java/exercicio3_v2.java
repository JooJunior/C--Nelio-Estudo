import java.util.Scanner;

public class exercicio3_v2 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite sua senha:");
        int senhaFor = sc.nextInt(); // adicional treino

        for (; senhaFor != 69; ) {
            System.out.println("Senha incorreta!");
            senhaFor = sc.nextInt();
            // Minha duvida no for e no while, é por que não iteramos ++ para a pergunta da senha, para que a pergunta venha de nov
            if (senhaFor == 69) {
                System.out.println("Acesso permitido");
            }
        }
    }
}

