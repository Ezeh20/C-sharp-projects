string pangram = "The quick brown fox jumps over the lazy dog.";
bool final = pangram.Contains(" Fox".Trim().ToLower());

int saleAmount = 1000;
int discount = saleAmount > 1000 ? 100 : 50;

int toss = new Random().Next(0, 2);
string result = toss == 0 ? "heads" : "tails";

string permission = "Admin";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
