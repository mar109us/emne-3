namespace StampCardApp;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        
        var names = new List<string> { "Kari", "Ola", "Per" };
        BuildCards(names, out var cards);
        var selectedCard = cards[0];

        Menu(cards, selectedCard);
    }

    private static void Menu(List<StampCard> cards, StampCard selectedCard) {
        while (true) { 
            Console.Clear();
            Console.WriteLine($"""
                              [Q]uit | [N]ew Card | [V]iew Cards
                              
                              
                              [SPACE] Buy Coffee
                              
                              Current card: {selectedCard.Name}
                              Stamps: {selectedCard.Count}
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
                cards.Add(new StampCard(Console.ReadLine()));
            }

            if (keyInfo.Key == ConsoleKey.V) {
                Console.Clear();
                Console.WriteLine("""
                                  [B]ack | Select: 1-4
                                  
                                  - Card Overview -
                                  
                                  """);
                PrintCards(cards);
                while (true) {
                    var viewKeyInfo = Console.ReadKey(true);
                    if (viewKeyInfo.Key == ConsoleKey.B) break;
                    if (viewKeyInfo.Key == ConsoleKey.D1) {
                        selectedCard = cards[0];
                        break;
                    }
                    if (viewKeyInfo.Key == ConsoleKey.D2) {
                        selectedCard = cards[1];
                        break;
                    }
                    if (viewKeyInfo.Key == ConsoleKey.D3) {
                        selectedCard = cards[2];
                        break;
                    }
                    if (viewKeyInfo.Key == ConsoleKey.D4) {
                        selectedCard = cards[3];
                        break;
                    }
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
    }

    private static void PrintCards(List<StampCard> cards) {
        foreach (var card in cards) {
            Console.WriteLine($"{cards.IndexOf(card) + 1}. {card.Name} {card.Count}");
        }
    }
}