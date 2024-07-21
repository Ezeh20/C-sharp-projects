DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
}

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidLength();
    ValidateZeros();
    ValidateRange();

    if (ValidLength() && ValidateZeros() && ValidateRange())
    {
        Console.WriteLine($"ip is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"ip is an invalid IPv4 address");
    }
}

bool ValidLength()
{
    return address.Length == 4;
}

bool ValidateZeros()
{
    foreach (string ip in address)
    {
        if (ip.Length > 1 && ip.StartsWith("0"))
        {
            return false;
        }
    }
    return true;
}

bool ValidateRange()
{
    foreach (string ip in address)
    {
        if (int.Parse(ip) < 0 || int.Parse(ip) > 255)
        {
            return false;
        }
    }
    return true;
}



string[,] corporate =
{
    { "Robert", "Bavin" },
    { "Simon", "Bright" },
    { "Kim", "Sinclair" },
    { "Aashrita", "Kamath" },
    { "Sarah", "Delucchi" },
    { "Sinan", "Ali" }
};

string[,] external =
{
    { "Vinnie", "Ashton" },
    { "Cody", "Dysart" },
    { "Shay", "Lawrence" },
    { "Daren", "Valdes" }
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    EmailAddress(firstName: corporate[i, 0], lastName: corporate[i, 1], domain: "contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++)
{
    EmailAddress(firstName: external[i, 0], lastName: external[i, 1]);
}

string EmailAddress(string firstName, string lastName, string domain = "hayworth.com")
{
    Console.WriteLine(firstName.ToLower().Substring(0, 2) + lastName.ToLower() + "@" + domain);
    return firstName.Substring(0, 2) + lastName + domain;
}
