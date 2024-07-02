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
