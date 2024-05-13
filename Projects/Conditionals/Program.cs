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
    total += 2;
    Console.WriteLine(
        $"You did a double {firstNumber} {secondNumber} {thirdNumber} total : {total}"
    );
}

if (total >= 15)
{
    Console.WriteLine("You win");
}

if (total < 15)
{
    Console.WriteLine("You lose");
}
