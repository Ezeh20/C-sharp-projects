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
