using System;

Random number = new();
int current = number.Next(1, 11);

do
{
    current = number.Next(1, 11);
    if (current >= 8)
        continue;
    Console.WriteLine(current);
} while (current != 10);


while (current >= 3)
{
    Console.WriteLine(current);
    current = number.Next(1, 11);
}

Console.WriteLine($"Last number : {current}");
