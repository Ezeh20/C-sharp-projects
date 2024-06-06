using System;

// Random number = new();
// int current = number.Next(1, 11);

// do
// {
//     current = number.Next(1, 11);
//     if (current >= 8)
//         continue;
//     Console.WriteLine(current);
// } while (current != 10);


// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = number.Next(1, 11);
// }

// Console.WriteLine($"Last number : {current}");

Random random = new();

int attack = random.Next(1, 11);
int heroHealth = 10;
int heroDamage = 0;
int monstersHealth = 10;
int monsterDamage = 0;

while ((heroHealth >= 0) && (monstersHealth >= 0))
{
    attack = random.Next(1, 11);
    monsterDamage = monstersHealth - attack;
    monstersHealth = monsterDamage;
    Console.WriteLine(
        $"Monster was damaged and lost {attack} health and now has {monstersHealth} health."
    );

    attack = random.Next(1, 11);
    heroDamage = heroHealth - attack;
    heroHealth = heroDamage;
    Console.WriteLine(
        $"Hero was damaged and lost {attack} health and now has {heroHealth} health."
    );
}
