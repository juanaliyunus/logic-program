package piramida;

public class PiramidaApp {
    public static void main(String[] args) {
        printPiramida(8);
    }

    public static void printPiramida(int n){
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i; j++) {
                System.out.print(" ");
            }
            for (int j = 0; j < i; j++) {
                System.out.print("*");
            }
            System.out.println(" ");
        }
    }
}
<