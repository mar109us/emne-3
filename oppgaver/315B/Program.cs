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

        while (!IsValidNumber(possibleSelections, answer))
        {
            Console.WriteLine("Må være mellom 1 og 3");
            isNumber = int.TryParse(Console.ReadLine(), out answer);
        }

        while (!isNumber)
        {
            Console.WriteLine("Det er ikke et tall. Skriv 1, 2 eller 3:");
            isNumber = int.TryParse(Console.ReadLine(), out answer);
        }

        var number = new Random();
        var CPU = number.Next(1, 4);
        Console.WriteLine(CPU);
    }

    private static bool IsValidNumber(int[] array, int answer)
    {
        foreach (var value in array)
            if (answer == value)
                return true;

        return false;
    }
}