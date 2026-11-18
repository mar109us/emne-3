using System.Text;

int[] dot = [1, 1];
var reverseHorizontal = false;
var reverseVertical = false;

Console.CursorVisible = false;
Console.Clear();

while (true) {
    var width = Console.WindowWidth;
    var height = Console.WindowHeight;
    var screen = new StringBuilder();
    for (var i = 0; i < height - 1; i++) {
        for (var j = 0; j < width; j++) {
            if (dot[0] == j && dot[1] == i) {
                screen.Append("████");
                j += 3;
            }

            if (dot[0] == j && dot[1] == i + 1) {
                screen.Append("████");
                j += 3;
            }
            else {
                screen.Append(" ");
            }
        }
    }

    if (reverseHorizontal) {
        dot[0]--;
    }
    else {
        dot[0]++;
    }

    if (reverseVertical) {
        dot[1]--;
    }
    else {
        dot[1]++;
    }

    if (dot[0] >= width - 4) {
        reverseHorizontal = true;
    }

    if (dot[0] == 0) {
        reverseHorizontal = false;
    }

    if (dot[1] >= height - 1) {
        reverseVertical = true;
    }

    if (dot[1] == 0 + 1) {
        reverseVertical = false;
    }

    Console.SetCursorPosition(0, 0);
    Console.Write(screen.ToString());

    Thread.Sleep(12);
}