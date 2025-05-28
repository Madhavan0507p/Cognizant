import java.util.Random;
import java.util.Scanner;
class NumberGuessingGame {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Random rand = new Random();
        int numberToGuess = rand.nextInt(100) + 1;
        int guess;

        System.out.println("Guess the number between 1 and 100");

        do {
            System.out.print("Enter your guess: ");
            guess = sc.nextInt();

            if (guess > numberToGuess)
                System.out.println("Too high!");
            else if (guess < numberToGuess)
                System.out.println("Too low!");
            else
                System.out.println("Correct! You guessed it.");
        } while (guess != numberToGuess);
    }
}
