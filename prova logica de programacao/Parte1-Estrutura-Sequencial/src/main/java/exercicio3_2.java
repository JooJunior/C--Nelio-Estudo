import java.util.Scanner;

public class exercicio3_2 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int X = N;

        int in = X;
        int out = X;

        for (; X >= 10 && X <= 20; ) {
            out++;

            if (X >= 10 && X <= 20)
                in++;
        }
        System.out.println(in + "in");
        System.out.println(out + "out");
    }
}

