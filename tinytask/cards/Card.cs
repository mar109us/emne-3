namespace cards;

public class Card {
        public Rank currentRank;
        public Suit currentSuit;

        public Card(Rank newRank, Suit newSuit) {
                currentRank = newRank;
                currentSuit = newSuit;
        }
}