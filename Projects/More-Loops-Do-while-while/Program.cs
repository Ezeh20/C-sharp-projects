using System;
using System.Linq;

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

Random random = new();

int attack = random.Next(1, 11);
int heroHealth = 10;
int monstersHealth = 10;

while ((heroHealth > 0) && (monstersHealth > 0))
{
    attack = random.Next(1, 11);
    monstersHealth = monstersHealth - attack;

    Console.WriteLine(
        $"Monster was damaged and lost {attack} health and now has {monstersHealth} health."
    );
    if (monstersHealth <= 0)
    {
        Console.WriteLine("Hero wins");
        break;
    }

    attack = random.Next(1, 11);
    heroHealth = heroHealth - attack;

    Console.WriteLine(
        $"Hero was damaged and lost {attack} health and now has {heroHealth} health."
    );
    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins");
        break;
    }
}

string? userInput;
bool validInput = false;

Console.WriteLine("Enter a word > 3");
do
{
    userInput = Console.ReadLine();

    if (userInput != null)
    {
        if (userInput.Length > 3)
        {
            validInput = true;
            Console.WriteLine("Thankyou");
            continue;
        }
        else
        {
            Console.WriteLine("You entered an invalid input");
        }
    }
} while (validInput == false);



//Code 1, This validates user's input which must be between 5 and 10

string? userInput;
int userValidateValue = 0;
bool validInput = false;

Console.WriteLine("Enter a value between 5 and 10.");

do
{
    userInput = Console.ReadLine();
    validInput = int.TryParse(userInput, out userValidateValue);

    if (validInput == true)
    {
        if (userValidateValue < 5 || userValidateValue > 10)
        {
            Console.WriteLine("The number must be between 5 and 10");
            validInput = false;
        }
        else if ((userValidateValue >= 5) && (userValidateValue <= 10))
        {
            validInput = true;
            continue;
        }
    }
    else
    {
        Console.WriteLine("You have entered an invalid number, try again");
    }
} while (validInput == false);

Console.WriteLine($"Your input {userValidateValue} has been accepted");

//Code 2; a code that validates string input

string? userInput2;
bool validInput2 = false;
string[] roles = { "Administrator", "Manager", "User" };
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput2 = Console.ReadLine();
    if (userInput2 != null)
    {
        string[] lowerCaseRole = roles.Select(role => role.ToLower()).ToArray();
        if (lowerCaseRole.Contains(userInput2.Trim().ToLower()))
        {
            validInput2 = true;
            continue;
        }
        else
        {
            Console.WriteLine(
                $"The role name that you entered, {userInput2} is not valid. Enter your role name (Administrator, Manager, or User)"
            );
        }
    }
} while (validInput2 == false);

Console.WriteLine($"Your input value ({userInput2.Trim()}) has been accepted.");




