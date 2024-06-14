// Declaring and Initailizing
using System.Text;

string greeting = "Hello, world";
string copiedString = new string(greeting.ToCharArray());

Console.WriteLine(copiedString);

/* String operations */

// Concatenation
string part1 = "hello";
string part2 = "world";
string message1 = part1 + part2;
string message2 = String.Concat(part1, part2);

Console.WriteLine("Message 2", message2);

// Formatting
int age = 27;
string name = "John";
string greeting2 = String.Format("Hello my name is {0} and I'm {1} years old", name, age);
Console.WriteLine("Greeting2", greeting2);

// Accesing characters
char lastChar = greeting[greeting.Length - 1];
Console.WriteLine("Last character", lastChar);

// Substrings
string sub1 = greeting.Substring(0, 4);
Console.WriteLine("Sub1", sub1);


// Searching
bool containsWorld = greeting.Contains("world");
int indexOfComma = greeting.IndexOf(",");
bool startWithHello = greeting.StartsWith("hello");
bool endWithWorld = greeting.EndsWith("world");

// Replacing
string newGreeting = greeting.Replace("world", "C#");

// Splitting
string[] words = greeting.Split(' ');
Console.WriteLine("Splitting", words);

// Joining
string[] words2 = { "This", "is", "a", "string" };
string sentence = String.Join(" ", words2);
Console.WriteLine("Joining", sentence);

// StringBuilder for mutable strings
// For performance-intensive scenarios where you need to modify a string frequently, use the StringBuilder 
StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(",");
sb.Append("world");

string result = sb.ToString();