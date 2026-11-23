namespace clicker;

internal class Program {
    public static void Main(string[] args) {
        var click1 = new Clicker();
        var click2 = new Clicker();
        var click3 = new Clicker();
        Console.WriteLine("""
                          Clicker 1: 1 = click | Q = upgrade
                          Clicker 2: 2 = click | W = upgrade
                          Clicker 3: 3 = click | E = upgrade 
                          """);
        while (true) {
            var input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.D1) {
                click1.Increase();
                click1.Print();
            }if (input.Key == ConsoleKey.D2) {
                click2.Increase();
                click2.Print();
            }if (input.Key == ConsoleKey.D3) {
                click3.Increase();
                click3.Print();
            }
            if (input.Key == ConsoleKey.Q) {
                click1.Upgrade();
            }
            if (input.Key == ConsoleKey.W) {
                click2.Upgrade();
            }
            if (input.Key == ConsoleKey.E) {
                click3.Upgrade();
            }
        }
    }
}