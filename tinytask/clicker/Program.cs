namespace clicker;

internal class Program {
    public static void Main(string[] args) {
        var click1 = new Clicker();
        var click2 = new Clicker();
        var click3 = new Clicker();
        while (true) {
            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.D1) {
                click1.Increase();
                click1.Print();
            }if (keyInfo.Key == ConsoleKey.D2) {
                click2.Increase();
                click2.Print();
            }if (keyInfo.Key == ConsoleKey.D3) {
                click3.Increase();
                click3.Print();
            }
        }
    }
}