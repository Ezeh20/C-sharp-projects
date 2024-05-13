
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

if (total >= 16)
{
    Console.WriteLine($"Congrats! you won a {firstPrice}");
}
else if (total >= 10)
{
    Console.WriteLine($"Congrats! you won a {secondPrice}");
}
else if (total == 7)
{
    Console.WriteLine($"Congrats! you won a {thirdPrice}");
}
else
{
    Console.WriteLine($"Congrats! you won a {fourthPrice}");
}
