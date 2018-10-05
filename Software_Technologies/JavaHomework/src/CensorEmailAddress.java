import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String email = scan.nextLine();
        String text = scan.nextLine();
        String censuredEmail = GenerateCensur(email.substring(0, email.indexOf('@')).length()) + email.substring(email.indexOf('@'));

        System.out.print(text.replace(email,censuredEmail));

    }
    private static String GenerateCensur(int lenght){
        String result = "";
        for (int i = 0; i < lenght; i++) {
             result+="*";

        }
        return result;
    }
}
