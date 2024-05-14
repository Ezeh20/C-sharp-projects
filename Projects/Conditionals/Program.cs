
int total;
int firstNumber;
int secondNumber;
int thirdNumber;
string firstPrice = "Car";
string secondPrice = "Laptop";
string thirdPrice = "trip";
string fourthPrice = "kitten";

Random dice = new();

firstNumber = dice.Next(1, 7);
secondNumber = dice.Next(1, 7);
thirdNumber = dice.Next(1, 7);

total = firstNumber + secondNumber + thirdNumber;

if ((firstNumber == secondNumber) || (firstNumber == thirdNumber) || (secondNumber == thirdNumber))
{
    if ((firstNumber == secondNumber) && (secondNumber == thirdNumber))
    {
        total += 6;
        Console.WriteLine(
            $"Congrats! you rolled a triple {firstNumber} {secondNumber} {thirdNumber} total : {total}"
        );
    }
    else
    {
        total += 3;
        Console.WriteLine(
            $"Congrats! you rolled a double {firstNumber} {secondNumber} {thirdNumber} total : {total}"
        );
    }
}

// if (total >= 16)
// {
//     Console.WriteLine($"Congrats! you won a {firstPrice}");
// }
// else if (total >= 10)
// {
//     Console.WriteLine($"Congrats! you won a {secondPrice}");
// }
// else if (total == 7)
// {
//     Console.WriteLine($"Congrats! you won a {thirdPrice}");
// }
// else
// {
//     Console.WriteLine($"Congrats! you won a {fourthPrice}");
// }

/**
* Improve renewal rate of subscriptions
* Improve the renewal rate of subscription for a company
* A random number will be generated to denote the number of days left for the user's sub (max 11 days)
* 6 rules were given; display the required message
*
* if days left is 10 days or less, log Your subscription will expire soon. Renew now!
* if days left is 5 days or less, log Your subscription expires in _ days. Renew now and save 10%!
* if days left is 1 day, log Your subscription expires within a day! Renew now and save 20%!
* if days is 0, log Your subscription has expired.
*/

int daysUntilExpiration = 0;
int discountPercentage = 0;
Random days_left = new();
daysUntilExpiration = days_left.Next(12);

Console.WriteLine(daysUntilExpiration);


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}


if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
