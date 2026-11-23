namespace clicker;

internal class Program {
    public static void Main(string[] args) {
        var click = new Clicker();
        click.Print();
        click.Increase();
        click.Print();
    }
}