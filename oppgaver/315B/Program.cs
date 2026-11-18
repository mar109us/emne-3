Console.WriteLine("""
                  1. Stein
                  2. Saks
                  3. Papir
                  """);

int answer;
bool isNumber = Int32.TryParse(Console.ReadLine(), out answer);

while (!isNumber)
{
    Console.WriteLine("Det er ikke et tall. Skriv 1, 2 eller 3:");
    isNumber = Int32.TryParse(Console.ReadLine(), out answer);
}


Random number = new Random();
int CPU  = number.Next(1, 4); 
Console.WriteLine(CPU);

int[] possibleSelections = [1, 2, 3];

foreach (int selection in possibleSelections) {
    // if (answer ==)
Console.WriteLine(selection);
}

// if (answer )