string goAgain = string.Empty;
do
{
	Console.Write("I am a anagram tester. Please give me two strings and I will tell you if it indeed is an anagram! Message 1:");
	string messageOne = Console.ReadLine().ToLower();
	Console.Write("Message 2:");
	string messageTwo = Console.ReadLine().ToLower();

	string ns1 = String.Concat(messageOne.OrderBy(c => c)).TrimStart().TrimEnd();
	string ns2 = String.Concat(messageTwo.OrderBy(c => c)).TrimStart().TrimEnd();

	if (/*messageOne.Length == messageTwo.Length && */ ns1 == ns2)
	{
		Console.WriteLine("both length and values are the same, it is an anagram. Want to go again? Y/N?");
        goAgain = Console.ReadLine().ToUpper();
    }
} while (goAgain == "Y");


//Same letters, same length, different arrangement
//Sort the letters alphabetically, if it matches its anagram

