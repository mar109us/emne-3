namespace cards;

public class GetAllCards {
    public static Loop() {
        public deck = new List<string>();
        foreach (Rank rank in Enum.GetValues<Rank>()) {
            foreach (var suit in Enum.GetValues<Suit>()) {
                deck.Add($"{rank} of {suit}");
                // Console.WriteLine($"{rank} of {suit}");
            }
        }
    }
}