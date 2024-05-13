using Internal;

int firstNumber;
int secondNumber;
int thirdNumber;
int total;

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
            $"Congrats! you rolled a triple {firstNumber} {secondNumber} {thridNumber} total : {total}"
        );
    }
    else
    {
        total += 3;
        Console.WriteLine(
            $"Congrats! you rolled a double {firstNumber} {secondNumber} {thridNumber} total : {total}"
        );
    }
}


if (total >= 15)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("You lose");
}
