//string goAgain = string.Empty;
//do
//{
//	Console.Write("I am a anagram tester. Give two strings and I'll tell you if it's an anagram! Message 1:");
//	string messageOne = Console.ReadLine().ToLower();
//	Console.Write("Message 2:");
//	string messageTwo = Console.ReadLine().ToLower();
//	string ns1 = String.Concat(messageOne.OrderBy(c => c)).TrimStart().TrimEnd();
//	string ns2 = String.Concat(messageTwo.OrderBy(c => c)).TrimStart().TrimEnd();

//	if (/*messageOne.Length == messageTwo.Length && */ ns1 == ns2)
//	{
//		Console.WriteLine("both length and values are the same, it is an anagram. Want to go again? Y/N?");
//        goAgain = Console.ReadLine().ToUpper();
//    }
//} while (goAgain == "Y");

while (true)
{
	Console.Write("I am an anagram tester. \nGive two strings and I'll tell you if it's an anagram! \nMessage 1:");
	string message1 = Console.ReadLine().ToLower();
	Console.Write("Message 2:");
	string message2 = Console.ReadLine().ToLower();
	string string1 = String.Concat(message1.OrderBy(c => c)).TrimStart().TrimEnd();
	string string2 = String.Concat(message2.OrderBy(c => c)).TrimStart().TrimEnd();

	string result = (string1 == string2) ? "Values have the same length and letters, it's an anagram. " : "Not an anagram. ";
	Console.Write(result + "\nDo you want to restart the tester? (Y/N):");

	string response = Console.ReadLine().ToLower();
	if (response != "y")
	{
		Console.WriteLine("Goodbye!");
		break;
	}
}


//Same letters, same length, different arrangement
//Sort the letters alphabetically, if it matches its anagram

//Examples:

//    Listen → Silent
//    Race → Care
//    God → Dog
//    Tea → Eat
//    Cinema → Iceman

//Anagram Phrases:

//    A gentleman → Elegant man
//    Clint Eastwood → Old west action
//    Debit card → Bad credit