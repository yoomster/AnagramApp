Console.Write("Hello, World! I am a anagram tester. Please give me two messages and I will tell you if it indeed is an anagram! Message 1:");
string messageOne = Console.ReadLine().ToLower();
Console.Write("Message 2:");
string messageTwo = Console.ReadLine().ToLower();

//Console.WriteLine(SortString(messageOne, messageTwo));

if (messageOne.Length == messageTwo.Length)
{
    Console.WriteLine("same length");
}
string ns1 = String.Concat(messageOne.OrderBy(c => c));
string ns2 = String.Concat(messageTwo.OrderBy(c => c));

if (ns1 == ns2)
{
    Console.WriteLine("same values");
}


//Same letters, same length, different arrangement
//Sort the letters alphabetically, if it matches its anagram

