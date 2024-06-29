using System;
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");

Array.Sort(pallets);

foreach (string pallet in pallets)
{
    Console.WriteLine($"---{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"---{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Clear...");
Array.Clear(pallets, 0, 2);
foreach (string pallet in pallets)
{
    Console.WriteLine($"---{pallet}");
}



string pangram = "The quick brown fox jumps over the lazy dog";
string revPangram ="";

string[] newPangram = pangram.Split(" ");

foreach (string newPangrams in newPangram)
{
    char[] charArry = newPangrams.ToCharArray();
    Array.Reverse(charArry);
    revPangram += new string(charArry) + " ";
}

Console.WriteLine(revPangram);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] arrOrderStream = orderStream.Split(",");
Array.Sort(arrOrderStream);
for (int i = 0; i < arrOrderStream.Length; i++)
{
    if (arrOrderStream[i].Length != 4)
    {
        Console.WriteLine($"{arrOrderStream[i]}\t- Error");
    }
    else
    {
        Console.WriteLine(arrOrderStream[i]);
    }
}
