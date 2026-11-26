namespace StampCardApp;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello world!");

        var card = new StampCard("Kari");
        Console.WriteLine($"{card.Name} {card.Count}");
        
    }
}