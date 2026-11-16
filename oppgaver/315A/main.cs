namespace A315
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 100);
            Console.WriteLine(number);
        }
    }
}
