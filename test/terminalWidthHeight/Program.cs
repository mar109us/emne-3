var width = Console.WindowWidth;
var height = Console.WindowHeight;

Console.WriteLine($"{width} {height}");

var screen = "";

for (var i = 0; i < height; i++) {
    for (var j = 0; j < width; j++) {
        screen += "█";
    }
}

Console.WriteLine(screen);