string name;


Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("Please type your name: ");
name = Console.ReadLine();

Console.Clear();

string album;

Console.WriteLine("Please type your favorite album: ");
album = Console.ReadLine();

Console.Clear();

string food;

Console.WriteLine("Please type your favorite food: ");
food = Console.ReadLine();

Console.Clear();

Console.WriteLine(name + " went to their local vinyl store to look for " + album + ", but was unable to find it. As sad as this was, " + name + " didn't mind too much because they would be cooking up " + food + ", their favorite food, for dinner.");
name = Console.ReadLine();