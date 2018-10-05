import java.util.Scanner;

public class VariableInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int converted = Integer.parseInt(scan.nextLine(),16);
        System.out.print(converted);
    }
}
