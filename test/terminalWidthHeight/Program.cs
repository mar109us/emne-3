while (true) {
    var width = Console.WindowWidth;
    var height = Console.WindowHeight;
    var screen = "";
    for (var i = 0; i < height - 1; i++) {
        for (var j = 0; j < width; j++) {
            screen += "█";
        }

        Console.WriteLine(screen);
    }

    Thread.Sleep(200);

    Console.Clear();
}