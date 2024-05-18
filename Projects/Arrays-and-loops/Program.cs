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

int[] ages = { 30, 50, 26, 27, 30 };
int total = 0;

//sum of ages
foreach (int age in ages)
{
    total += age;
}
Console.WriteLine($"The total age of students is {total}");
Console.WriteLine($"There are {users.Length} fraudulent orders ");
