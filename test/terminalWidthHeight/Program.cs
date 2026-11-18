int[] dot = [0, 0];
var reverseHorizontal = false;
var reverseVertical = false;

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

    Thread.Sleep(10);

    Console.Clear();
    
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

    if (dot[0] == width) {
        reverseHorizontal = true;
    }

    if (dot[0] == 0) {
        reverseHorizontal = false;
    }

    if (dot[1] == height) {
        reverseVertical = true;
    }

    if (dot[1] == 0) {
        reverseVertical = false;
    }

  
}