namespace A315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Guess number");

            var random = new Random();
            var number = random.Next(1, 11);
            int guess;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out guess);

            int countGuess = 0;
            bool correctGuess = false;

            while (!correctGuess)
            {
                string overOrUnder;
                if (number == guess)
                {
                    Console.WriteLine("you guessed correct, number was: {0}", number);
                    correctGuess = true;
                }
                else
                {
                    countGuess += 1;
                    Console.WriteLine("Wrong, try again");
                    
                    if (guess < number)
                    {
                        overOrUnder = "higher";
                    }
                    else
                    {
                        overOrUnder = "lower";
                    }
                    
                    Console.WriteLine("{0} tries. Number is {1} than {2}", countGuess, overOrUnder, guess);
                    Int32.TryParse(Console.ReadLine(), out guess);
                }
            }
        }
    }
}
