string pangram = "The quick brown fox jumps over the lazy dog.";
bool final = pangram.Contains(" Fox".Trim().ToLower());

int saleAmount = 1000;
int discount = saleAmount > 1000 ? 100 : 50;

int toss = new Random().Next(0, 2);
string result = toss == 0 ? "heads" : "tails";
Console.WriteLine(result);
