int randomNumber;

Random dice = new();
randomNumber = dice.Next(0, 11);
Console.WriteLine(randomNumber);