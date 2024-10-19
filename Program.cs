namespace DiscussionPost {
    internal class Program {
        static void Main(string[] args) {
            int guesses = 0;
            int specialNumber = 74;

            do {
                Console.WriteLine("Guess the seceret number (less then 100): ");

                string input = Console.ReadLine();
                int currentNumber;

                // Guard statment
                if (input == null || int.TryParse(input, out currentNumber) == false) {
                    Console.WriteLine("Invalid input exiting!");
                    break;
                }

                if (currentNumber != specialNumber) {
                    guesses++;
                    if (currentNumber > specialNumber) {
                        Console.WriteLine("Your guess is too high try again.");
                    } else {
                        Console.WriteLine("Your guess is too low try again.");
                    }
                } else {
                    Console.WriteLine($"You guessed correctectly after {guesses} attempts.");
                    break;
                }
            } while (true);

        }
    }
}
