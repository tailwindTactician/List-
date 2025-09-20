List<bool> values = new List<bool> { true, true, true};
bool allTrue = values.All(v => v == true);
System.Console.WriteLine("Are all the value in the list true? " + allTrue);