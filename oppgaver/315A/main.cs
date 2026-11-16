namespace A315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Guess number");

            var random = new Random();
            var number = random.Next(1, 100);
            int guess;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out guess);

            int countGuess = 0;
            bool correctGuess = false;

            while (!correctGuess)
            {
                if (number == guess)
                {
                    Console.WriteLine("you guessed correct, number was: {0}", number);
                    correctGuess = true;
                }
                else
                {
                    countGuess += 1;
                    Console.WriteLine(
                        "you guessed wrong, random number was: {0}. you have tried {1} times",
                        number,
                        countGuess
                    );
                    Int32.TryParse(Console.ReadLine(), out guess);
                }
            }
        }
    }
}
