namespace cards;

class Program {
    static void Main(string[] args) {
        var aCard = new Card((Rank)2, (Suit)2);
        Console.WriteLine($"{aCard.currentRank} of {aCard.currentSuit}");
    }
}