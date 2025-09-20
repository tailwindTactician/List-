List<string> words = new List<string>{ "hello", "world", "!" };
string concat = "";
foreach (string word in words)
    concat += word;
Console.WriteLine("The concatenated string is: " + concat);