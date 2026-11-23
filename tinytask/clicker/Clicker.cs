namespace clicker;

public class Clicker {
    private int points;
    private int increment = 1;
    private int incrementPrice = 10;

    public void Points() {
        points = 0;
    }

    public void Increase() {
       points += increment;
    }

    private void Decrease() {
        points -= incrementPrice;
    }

    public void Upgrade() {
        if (CanUpgrade()) {
            increment++;
            Decrease();
        }
        else Console.WriteLine("Need at least 10 points for upgrade");
    }

    private bool CanUpgrade() {
        if (points >= 10) {
            return true;
        }

        return false;
    }
    
    public void Print() {
        Console.WriteLine(points);
    }
}