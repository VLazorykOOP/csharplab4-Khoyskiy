using Lab4CSharp;

Console.WriteLine("Lab4 C# ");
Romb romb = new Romb(4, 4 * Math.Sqrt(2), "Red");

Console.WriteLine(romb[0]);
Console.WriteLine(romb[1]);
Console.WriteLine(romb[2]);

// Перевантаження true і false
Console.WriteLine(romb ? "Is Square" : "Is not Square");

++romb;
Console.WriteLine($"After ++: {romb}");

//--romb;
Console.WriteLine($"After --: {romb}");

// Перевантаження оператору *
romb = romb * 2;
Console.WriteLine($"After * 2: {romb}");

// Перетворення типу Romb в string і навпаки
string rombString = romb;
Console.WriteLine($"Romb as string: {rombString}");

Romb newRomb = rombString;
Console.WriteLine($"String as Romb: {newRomb}");
Console.ReadLine();

