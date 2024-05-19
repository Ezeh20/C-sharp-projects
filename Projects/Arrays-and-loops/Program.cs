//declare an array of string with a length of 3

string[] users = new string[3];

users[0] = "Ezeh";
users[1] = "Ade";
users[2] = "Cole";
users[0] = "Buchi";

string[] users2 = { "Ade", "Tobi", "Kelechi" };

string[] jobs = { "Farmer", "Plumber", "Pilot", "Teacher" };

foreach (string job in jobs)
{
    Console.WriteLine(job);
}

//Get the total inventory of a store while giving live updates on each bin and the running total
int[] inventory = { 30, 50, 26, 27, 30 };
int sum = 0;
int bin = 0;

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"The are {sum} items in the store");
Console.WriteLine($"There are {users.Length} fraudulent orders");
