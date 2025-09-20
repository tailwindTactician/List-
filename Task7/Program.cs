List<string> items = new List<string> { "apple", "banana", "cherry" };
items.Remove("apple");
System.Console.WriteLine("List after removal: ");
foreach (var item in items)
{
    System.Console.WriteLine(item);
}