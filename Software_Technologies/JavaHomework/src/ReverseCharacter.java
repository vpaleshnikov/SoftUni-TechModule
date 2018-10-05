import java.util.Scanner;

public class ReverseCharacter {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String firstLetter = scan.nextLine();
        String secondLetter = scan.nextLine();
        String thirdLetter = scan.nextLine();
        System.out.print(thirdLetter+secondLetter+firstLetter);
    }
}
