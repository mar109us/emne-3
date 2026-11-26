namespace StampCardApp;

class Program {
    static void Main(string[] args) {
        var names = new List<string> { "Kari", "Ola", "Per" };
        var cards = new List<StampCard>();
        
        foreach (var name in names) {
            var card = new StampCard(name);
            cards.Add(card);
        }
        
        foreach (var card in cards) {
            Console.WriteLine($"{card.Name} {card.Count}");
        }
    }
}