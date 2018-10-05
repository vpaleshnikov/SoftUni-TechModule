
import java.util.Arrays;
import java.util.Scanner;

import static java.lang.System.in;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {

        Scanner scan = new Scanner(in);


        int[] arrayOfIntegers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
int startIndex = 0;
int counter = 1;
int maxLenght = 1;

        for (int i = 1; i < arrayOfIntegers.length; i++) {

            if (arrayOfIntegers[i]>arrayOfIntegers[i-1]){
                counter++;
                continue;
            }
            if(maxLenght<counter){
                startIndex=i-counter;
                maxLenght=counter;
            }
            counter=1;
        }
        if(maxLenght<counter){
            startIndex=arrayOfIntegers.length-counter;
            maxLenght=counter;
        }

        for (int i = startIndex; i < startIndex+maxLenght; i++) {
            System.out.printf("%d ",arrayOfIntegers[i]);

        }
    }
}
