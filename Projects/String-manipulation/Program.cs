
using System.Linq;

string message = "Find what is (inside the parentheses)";

int opening = message.IndexOf("(");
int closing = message.IndexOf(")");
opening++;

int length = closing - opening;

// Console.Write(message.Substring(opening, length));

string message2 = "What is the value <span>between the tags</span>?";

const string opn = "<span>";
const string cls = "</span>";

int starting = message2.IndexOf(opn);
int ending = message2.IndexOf(cls);

starting += opn.Length;
Console.WriteLine(message2.Substring(starting, (ending - starting)));



string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int opn = message.IndexOf("(");
    if (opn == -1)
        break;
    opn++;
    int cls = message.IndexOf(")");
    Console.WriteLine(message.Substring(opn, (cls - opn)));
    message = message.Substring(cls + 1);
}

string data = "The big black fox";
const string updatedData = "fox";
int opn = data.IndexOf(updatedData);

// opn = opn + updatedData.Length;

Console.WriteLine(data.Replace("fox", "penis"));


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";

const string startingStr = "<span>";
const string closingStr = "</span>";
const string startingDiv = "<div>";
const string closingDiv = "</div>";

int qtyStr = input.IndexOf(startingStr);
qtyStr = qtyStr + startingStr.Length;
int qtyEnd = input.IndexOf(closingStr);
quantity = input.Substring(qtyStr, (qtyEnd - qtyStr));

int divStr = input.IndexOf(startingDiv);
divStr = divStr + startingDiv.Length;
int divEnd = input.IndexOf(closingDiv);
output = input.Substring(divStr, (divEnd - divStr)).Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
