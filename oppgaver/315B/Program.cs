Console.WriteLine("""
                  1. Stein
                  2. Saks
                  3. Papir
                  """);
string answer = Console.ReadLine();
Random number = new Random();
int CPU  = number.Next(1, 4); 
Console.WriteLine(CPU);
