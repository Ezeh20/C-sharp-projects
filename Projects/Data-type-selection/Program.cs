
using System;
using System.Linq;

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// A value type stores the copy of the data in the declared variable, the stack
// memory is used for this purpose (the values in the stack is removed after execution)

// The reference type usesthe heap memory which is controlled my the device operating system
// .Net under the hood makes an address allocation request which then points the declared variable to that address




/**
widening and narrowing are the two type of data type conversion where widening is implicit
which can be handled by the compiler automatically and narrowing being explicit (the instruction is given to the compiler by casting the data type you want to convert to)

widening - trying to convert a value from a data type that holds a lesser value to a data type that may hold a higher value (value isn't lost)
int to decimal
float to decimal

narrowing - trying to canvert a value from a data type that holds more value to a data type that holds a lesser value (value is lost)
decimal to int
decimal to float

eg decimal avgAge = 40.7m;
    int final = (int) avgAge;
*/
int adg = 0;
decimal age = 56.6m;
string ll = age.ToString();
string adl = "1";
int add =  Convert.ToInt32(adl) * Convert.ToInt32(age);


string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal valid = 0;
string message = "";
decimal final = 0;

for (int i = 0; i < values.Length; i++)
{
    if (decimal.TryParse(values[i], out valid))
    {
        final += decimal.Parse(values[i]);
    }
    else
    {
        message += values[i];
    }
}

Console.WriteLine($"Message:{message}, total:{final}");