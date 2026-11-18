internal class Program
{
    private static void Main()
    {
        Console.WriteLine("""
                          1. Stein
                          2. Saks
                          3. Papir
                          """);

        int answer;
        int[] possibleSelections = [1, 2, 3];
        var isNumber = int.TryParse(Console.ReadLine(), out answer);
        var number = new Random();
        var cpu = number.Next(1, 4);

        while (!IsValidNumber(possibleSelections, answer))
        {
            Console.WriteLine("Må være et tall mellom 1 og 3");
            isNumber = int.TryParse(Console.ReadLine(), out answer);
        }

        GetResult();

        void GetResult()
        {
            if (answer == cpu) Console.WriteLine("Uavgjort");

            if (answer == 1 && cpu == 2) Console.WriteLine("Du vant med stein mot saks");
            if (answer == 1 && cpu == 3) Console.WriteLine("Du tapte med stein mot papir");

            if (answer == 2 && cpu == 1) Console.WriteLine("Du tapte med saks mot stein");
            if (answer == 2 && cpu == 3) Console.WriteLine("Du vant med saks mot papir");

            if (answer == 3 && cpu == 1) Console.WriteLine("Du vant med papir mot stein");
            if (answer == 3 && cpu == 2) Console.WriteLine("Du tapte med papir mot saks");
            Main();
        }
    }

    private static bool IsValidNumber(int[] array, int answer)
    {
        foreach (var value in array)
            if (answer == value)
                return true;

        return false;
    }
}