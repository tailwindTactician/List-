List<string> items = new List<string>{ "apple", "banana", "cherry" };
string foundItem = items.Find(item => item == "banana");
 bool found = foundItem != null;
 Console.WriteLine("Is the element found? " + found);