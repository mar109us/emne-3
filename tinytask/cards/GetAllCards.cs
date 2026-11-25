namespace cards;

public class GetAllCards {
    public static void Loop() {
        foreach (Rank rank in Enum.GetValues<Rank>()) {
            foreach (var suit in Enum.GetValues<Suit>()) {
                Console.WriteLine($"{rank} of {suit}");
            }
        }
    }
}