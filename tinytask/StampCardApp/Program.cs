namespace StampCardApp;

class Program {
    static void Main(string[] args) {
        
        
        var names = new List<string> { "Kari", "Ola", "Per" };

        while (true) {
            Console.Clear();
            Console.WriteLine("Q: Quit N: New Card V: View Cards");
            var keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Q) break;
            if (keyInfo.Key == ConsoleKey.N) {
                Console.Clear();
                Console.WriteLine("- Create new card -");
                Console.WriteLine("Name: ");
                names.Add(Console.ReadLine());
                BuildCards(names, out var cards);
            }
            if (keyInfo.Key == ConsoleKey.V) { Console.Clear();
                BuildCards(names, out var cards);
            }
        }
    }

    private static void BuildCards(List<string> names, out List<StampCard> cards) {
        cards = new List<StampCard>();
        
        foreach (var name in names) {
            var card = new StampCard(name);
            cards.Add(card);
        }
        
        foreach (var card in cards) {
            Console.WriteLine($"{card.Name} {card.Count}");
        }
    }
}