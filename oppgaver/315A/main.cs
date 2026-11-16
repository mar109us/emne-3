namespace A315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var random = new Random();
            var number = random.Next(1, 100);
            Console.WriteLine("Guess number");
            int guess = Int32.Parse(Console.ReadLine());
            if (number == guess)
            {
                Console.WriteLine("you guessed correct, number was: {0}", number);
            }
            else
            {
                Console.WriteLine("you guessed wrong, random number was: {0}", number);
            }
        }
    }
}
