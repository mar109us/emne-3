namespace clicker;

public class Clicker {
    private int points;

    public void Points() {
        points = 0;
    }

    public void Increase() {
       points++;
    }
    
    public void Print() {
        Console.WriteLine(points);
    }
}