namespace StampCardApp;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        
        var names = new List<string> { "Kari", "Ola", "Per" };
        BuildCards(names, out var cards);
        var selectedCard = cards[0];

        Menu(names, selectedCard);
    }

    private static void Menu(List<string> names, StampCard selectedCard) {
        while (true) { 
            Console.Clear();
            Console.WriteLine($"""
                              Q: Quit N: New Card V: View Cards
                              
                              Current card: {selectedCard.Name}
                              Stamps: {selectedCard.Count}
                              
                              Space: Buy Coffee
                              """);
            var keyInfo = Console.ReadKey(true);

            
            if (keyInfo.Key == ConsoleKey.Q) break;
            if (keyInfo.Key == ConsoleKey.Spacebar) {
                selectedCard.Count++;
            }
            if (keyInfo.Key == ConsoleKey.N) {
                Console.Clear();
                Console.WriteLine("""
                                  - Create new card -
                                  
                                  Name: 
                                  """);
                names.Add(Console.ReadLine());
                BuildCards(names, out var cards);
            }

            if (keyInfo.Key == ConsoleKey.V) {
                Console.Clear();
                Console.WriteLine("""
                                  - Card Overview -
                                  
                                  Backspace: Back
                                  
                                  """);
                BuildCards(names, out var cards);
                while (true) {
                    var viewKeyInfo = Console.ReadKey(true);
                    if (viewKeyInfo.Key == ConsoleKey.Backspace) break;
                }
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
            Console.WriteLine($"{cards.IndexOf(card) + 1}. {card.Name} {card.Count}");
        }
    }
}