int[] dot = [0, 0];

while (true) {
    var width = Console.WindowWidth;
    var height = Console.WindowHeight;
    var screen = "";
    for (var i = 0; i < height - 1; i++) {
        for (var j = 0; j < width; j++) {
            if (dot[0] == i && dot[1] == j) {
                screen += "█";
            }
            else {
                screen += " ";
            }
        }
    }

    Console.WriteLine(screen);

    Thread.Sleep(200);

    Console.Clear();

    dot[0]++;
    dot[1]++;
}